import { Feather } from '@expo/vector-icons';
import { AuthContext } from 'providers/AuthProvider';
import { useContext } from 'react';
import { Text, View, StyleSheet } from 'react-native';

export const LogoutButton = () => {
  const authContext = useContext(AuthContext);

  const logout = () => {
    authContext?.logOut();
  };

  return (
    <View style={styles.LogoutButton}>
      <Feather name="log-out" size={16} color="#007AFF" />
      <Text style={styles.logoutButtonText} onPress={logout}>
        Sair
      </Text>
    </View>
  );
};
const styles = StyleSheet.create({
  LogoutButton: {
    flexDirection: 'row',
    paddingRight: 20,
  },
  logoutButtonText: {
    color: '#007AFF',
    marginLeft: 4,
  },
});
