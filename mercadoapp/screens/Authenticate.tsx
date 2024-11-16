// FILE: screens/AuthenticateScreen.tsx
import { NavigationProp } from '@react-navigation/native';
import React, { useEffect, useState } from 'react';
import { View } from 'react-native';
import { Button, Dialog, Portal, Text, TextInput } from 'react-native-paper';

import { useAuth } from '../providers/AuthProvider';
import { styles } from './styles/shared';
import { validateEmail } from '../validation/validators';

const passwordLength = 6;

const AuthenticateScreen = ({ navigation }: { navigation: NavigationProp<any> }) => {
  const [authData, setAuthData] = useState({ email: '', senha: '' });
  const [showAlert, setShowAlert] = useState(false);
  const [errorText, setErrorText] = useState('');

  const auth = useAuth();

  // Apaga os campos de email e senha ao entrar na tela
  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      setAuthData({ email: '', senha: '' });
    });

    return unsubscribe;
  }, [navigation]);

  // Valida os campos de email e senha e chama a função de login
  const handleLogin = () => {
    if (authData.email.length) {
      if (!validateEmail(authData.email)) {
        showError('Erro ao tentar entrar: Email inválido.');
        return;
      }
    }

    if (authData.senha.length && authData.senha.trim().length < passwordLength) {
      showError(
        `Erro ao tentar entrar: Senha muito curta.\nA senha deve ter pelo menos ${passwordLength} caracteres.`
      );
      return;
    }

    if (auth) {
      auth.loginAction(authData);
    } else {
      showError('Erro ao tentar entrar: Serviço de autenticação não disponível.');
    }
  };

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

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Mercado do Cruzeiro App Comerciantes</Text>
      <Text style={styles.title_2}>Digite suas Credenciais:</Text>
      <TextInput
        style={styles.input}
        placeholder="Email"
        value={authData.email}
        onChangeText={(email) => setAuthData({ ...authData, email })}
      />
      <TextInput
        style={styles.input}
        placeholder="Senha"
        value={authData.senha}
        onChangeText={(senha) => setAuthData({ ...authData, senha })}
        secureTextEntry
      />
      <Button onPress={handleLogin} style={styles.button} mode="contained">
        Entrar
      </Button>
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
    </View>
  );
};

export default AuthenticateScreen;
