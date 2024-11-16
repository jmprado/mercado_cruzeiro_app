import AsyncStorage from '@react-native-async-storage/async-storage';
import { NavigationProp, useNavigation } from '@react-navigation/native';
import React, { createContext, useContext, useState, ReactNode } from 'react';
import { Button, Portal, Dialog, Text } from 'react-native-paper';

import { ApiUrls } from './apiUrls';
import { AuthModel } from '../types/authModel';

interface AuthContextType {
  token: string | null;
  email: string | null;
  loginAction: (authData: AuthModel) => Promise<void>;
  logOut: () => void;
  getToken: () => string | null;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);
const { Provider } = AuthContext;

const AuthProvider = ({ children }: { children: ReactNode }) => {
  const [email, setEmail] = useState<string | null>(null);
  const [token, setToken] = useState<string | null>(null);
  const [showAlert, setShowAlert] = useState(false);
  const [errorText, setErrorText] = useState('');

  const showDialog = () => setShowAlert(true);

  const hideDialog = () => setShowAlert(false);

  const showError = (error: string) => {
    setErrorText(error);
    showDialog();
  };

  const hideError = () => {
    setErrorText('');
    hideDialog();
  };

  React.useEffect(() => {
    const fetchToken = async () => {
      const storedToken = await AsyncStorage.getItem('site');
      setToken(storedToken);
    };
    fetchToken();
  }, []);

  const getToken = () => {
    return token;
  };

  const navigation = useNavigation<NavigationProp<any>>();

  const loginAction = async (authData: AuthModel) => {
    try {
      console.log(ApiUrls.Login);
      const response = await fetch(ApiUrls.Login(), {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          email: authData.email,
          senha: authData.senha,
        }),
      });

      const res = await response.json();
      console.log(res);

      if (res.status === 400) {
        showError(`Erro ao tentar entrar: ${res.message}`);
        return;
      }

      if (res.status === 401) {
        showError('Erro ao tentar entrar: Credenciais inválidas.');
        return;
      }

      if (res.token) {
        setEmail(authData.email);
        setToken(res.token);
        await AsyncStorage.setItem('site', res.token);
        navigation.navigate('home');
        return;
      }
      throw new Error(res.message);
    } catch (err) {
      console.error(err);
    }
  };

  const logOut = async () => {
    setEmail(null);
    setToken(null);
    await AsyncStorage.removeItem('site');
    navigation.navigate('login');
  };

  return (
    <Provider value={{ token, email, loginAction, logOut, getToken }}>
      {children}
      <Portal>
        <Dialog visible={showAlert} onDismiss={hideError}>
          <Dialog.Title>Erro!</Dialog.Title>
          <Dialog.Content>
            <Text variant="bodyMedium">{errorText}</Text>
          </Dialog.Content>
          <Dialog.Actions>
            <Button onPress={hideError}>Fechar</Button>
          </Dialog.Actions>
        </Dialog>
      </Portal>
    </Provider>
  );
};

export { AuthProvider, AuthContext };

export const useAuth = () => {
  return useContext(AuthContext);
};
