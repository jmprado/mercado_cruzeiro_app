import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { AuthContext, AuthProvider } from 'providers/AuthProvider';
import { AxiosProvider } from 'providers/AxiosProvider';
import { useContext } from 'react';
import { PaperProvider, Button } from 'react-native-paper';
import PedidosScreen from 'screens/Pedidos';
import ProdutosScreen from 'screens/Produtos';

import { BackButton } from '../components/BackButton';
import AuthenticateScreen from '../screens/Authenticate';
import HomeScreen from '../screens/Home';
import SobreScreen from '../screens/Sobre';
import { LogoutButton } from 'components/LogoutButton';

const Stack = createStackNavigator();

export type RootStackParamList = {
  Overview: undefined;
  Details: { name: string };
};

export default function RootStack() {
  const botaoVoltar = (navigation: any) => {
    return <BackButton onPress={navigation.goBack} />;
  };

  const botaoSair = () => {
    return <LogoutButton />;
  };

  return (
    <PaperProvider>
      <NavigationContainer>
        <AuthProvider>
          <AxiosProvider>
            <Stack.Navigator>
              <Stack.Screen
                name="login"
                component={AuthenticateScreen}
                options={{ title: 'Entrar' }}
              />
              <Stack.Screen
                name="home"
                component={HomeScreen}
                options={{ title: 'Home', headerLeft: () => '', headerRight: () => botaoSair() }}
              />
              <Stack.Screen
                name="sobre"
                component={SobreScreen}
                options={({ navigation }) => ({
                  headerLeft: () => botaoVoltar(navigation),
                  headerRight: () => botaoSair(),
                  title: 'Sobre',
                })}
              />
              <Stack.Screen
                name="produtos"
                component={ProdutosScreen}
                options={({ navigation }) => ({
                  headerLeft: () => botaoVoltar(navigation),
                  headerRight: () => botaoSair(),
                  title: 'Produtos',
                })}
              />
              <Stack.Screen
                name="pedidos"
                component={PedidosScreen}
                options={({ navigation }) => ({
                  headerLeft: () => botaoVoltar(navigation),
                  headerRight: () => botaoSair(),
                  title: 'Pedidos',
                })}
              />
            </Stack.Navigator>
          </AxiosProvider>
        </AuthProvider>
      </NavigationContainer>
    </PaperProvider>
  );
}
