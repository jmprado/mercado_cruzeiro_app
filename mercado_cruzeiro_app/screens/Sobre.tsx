import * as React from 'react';
 import { View, Text, Button } from 'react-native';

 const SobreScreen = ({navigation} : any) =>  {
     return (
     <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
         <Text>About Screen</Text>
         <Button title='Ir para Home' onPress={() => navigation.navigate('Home')} />
     </View>
     );
 }

 export default SobreScreen;
