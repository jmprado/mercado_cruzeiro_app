import * as React from 'react';
import {NavigationContainer, NavigationProp} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import HomeScreen from './screens/Home';
import SobreScreen from './screens/Sobre';
import AuthenticateScreen from './screens/Authenticate';
import {PaperProvider} from 'react-native-paper';
import AuthProvider from './providers/AuthProvider';

const Stack = createNativeStackNavigator();

interface Props {
  navigation: NavigationProp<any>;
}

const App = () => {
  return (
    <AuthProvider>
      <PaperProvider>
        <NavigationContainer>
          <Stack.Navigator>
            <Stack.Screen name="login" component={AuthenticateScreen} />
            <Stack.Screen name="home" component={HomeScreen} />
            <Stack.Screen name="about" component={SobreScreen} />
          </Stack.Navigator>
        </NavigationContainer>
      </PaperProvider>
    </AuthProvider>
  );
};

export default App;
