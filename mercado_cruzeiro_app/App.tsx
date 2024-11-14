import * as React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import HomeScreen from './screens/Home';
import SobreScreen from './screens/Sobre';

const Stack = createNativeStackNavigator();

const App  = () => {
    return (
    <NavigationContainer>
        <Stack.Navigator>
        <Stack.Screen name="Home" component={HomeScreen} />
        <Stack.Screen name="About" component={SobreScreen} />
        </Stack.Navigator>
    </NavigationContainer>
    );
};

export default App;