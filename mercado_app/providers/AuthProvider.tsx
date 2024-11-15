import React, {createContext, useContext, useState} from 'react';
import {NavigationProp, useNavigation} from '@react-navigation/native';
import {loginUrl} from '../apiClient/apiUrls';
import AsyncStorage from '@react-native-async-storage/async-storage';

interface AuthContextType {
  token: string;
  user: string | null;
  loginAction: (authData: AuthModel) => Promise<void>;
  logOut: () => void;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

import {ReactNode} from 'react';
import {AuthModel} from '../types/AuthModel';

interface Props {
  navigation: NavigationProp<any>;
}

const AuthProvider = ({children}: {children: ReactNode}) => {
  const [user, setUser] = useState(null);
  const [token, setToken] = useState(localStorage.getItem('site') || '');
  const navigation = useNavigation<NavigationProp<any>>();

  const loginAction = async (authData: AuthModel) => {
    try {
      const response = await fetch(loginUrl, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          login: authData.login,
          senha: authData.senha,
        }),
      });
      const res = await response.json();
      if (res.data) {
        setUser(res.data.user);
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
    setUser(null);
    setToken('');
    await AsyncStorage.removeItem('site';
    navigation.navigate('/login');
  };

  return (
    <AuthContext.Provider value={{token, user, loginAction, logOut}}>
      {children}
    </AuthContext.Provider>
  );
};

export default AuthProvider;

export const useAuth = () => {
  return useContext(AuthContext);
};
