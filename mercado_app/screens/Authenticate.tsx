// FILE: screens/AuthenticateScreen.tsx
import React, {useState} from 'react';
import {View, TextInput, StyleSheet} from 'react-native';
import {Formik} from 'formik';

import {NavigationProp} from '@react-navigation/native';
import {Button, Dialog, Portal, Text} from 'react-native-paper';
import * as yup from 'yup';
import { useAuth } from '../providers/AuthProvider';



const loginValidationSchema = yup.object().shape({
  email: yup
    .string()
    .email('Por favor digite um email válido')
    .required('Email Obrigatório'),
  password: yup
    .string()
    .min(8, ({min}) => `A senha deve ter pelo menos ${min} caracteres`)
    .required('Senha Obrigatória'),
});

const passwordLength = 6;

const AuthenticateScreen = () => {
  const [authData, setAuthData] = useState({login: '', senha: ''});
  const [showAlert, setShowAlert] = useState(false);
  const [errorText, setErrorText] = useState('');

  const auth = useAuth();

  const handleLogin = () => {
    if (authData.login.length > 0 && authData.senha.length > 0) {
      // Add authentication logic here
      if (authData.login.length > 0 && authData.senha.length > 0) {
        // Add authentication logic here
        if (authData.senha.length < passwordLength) {
          showError(
            `Erro ao tentar entrar: Senha muito curta.\nA senha deve ter pelo menos ${passwordLength} caracteres.`,
          );
          return;
        }
        if (auth) {
          auth.loginAction(authData);
        } else {
          showError('Erro ao tentar entrar: Serviço de autenticação não disponível.');
        }
        return;
      }
    }
    showError('Erro ao tentar entrar: Credenciais em branco.');
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
      <Text style={styles.title}>Mercado do Cruzeiro App</Text>
      <Text style={styles.title_2}>Digite suas Credenciais:</Text>
      <Formik
        validationSchema={loginValidationSchema}
        initialValues={{email: '', senha: ''}}
        onSubmit={handleLogin}>
        {({errors, touched}) => (
          <>
            <TextInput
              style={styles.input}
              placeholder="Username"
              value={authData.login}
              onChangeText={login => setAuthData({...authData, login})}
            />
            <TextInput
              style={styles.input}
              placeholder="Password"
              value={authData.senha}
              onChangeText={senha => setAuthData({...authData, senha})}
              secureTextEntry
            />
            {errors.email && touched.email && (
              <Text style={styles.errorText}>{errors.email}</Text>
            )}

            {errors.senha && touched.senha && (
              <Text style={styles.errorText}>{errors.senha}</Text>
            )}
            <Button
              onPress={handleLogin}
              style={styles.button}
              mode="contained">
              Entrar
            </Button>
          </>
        )}
      </Formik>
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

const styles = StyleSheet.create({
  button: {
    marginTop: 15,
  },
  container: {
    flex: 1,
    justifyContent: 'center',
    padding: 16,
  },
  title: {
    fontSize: 24,
    marginBottom: 16,
    textAlign: 'center',
  },
  title_2: {
    fontSize: 18,
    marginBottom: 12,
    textAlign: 'center',
  },
  input: {
    height: 40,
    borderColor: 'gray',
    borderWidth: 1,
    marginBottom: 12,
    paddingHorizontal: 8,
  },
  errorText: {
    marginTop: 5,
    marginBottom: 5,
    fontSize: 10,
    color: 'red',
  },
  errorInput: {
    borderColor: 'red',
  },
});

export default AuthenticateScreen;
