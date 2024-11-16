import { RouteProp } from '@react-navigation/native';
import React from 'react';
import { View, StyleSheet } from 'react-native';
import { Text } from 'react-native-paper';

import { PedidoDTO } from '../types/pedido';

export type PedidosScreenRouteProp = RouteProp<
  { params: { idLoja: number; nome: string } },
  'params'
>;

type Props = {
  route: PedidosScreenRouteProp;
};

const PedidosScreen: React.FC<Props> = ({ route }: { route: PedidosScreenRouteProp }) => {
  const { idLoja, nome } = route.params;

  return (
    <View style={styles.container}>
      <Text variant="titleLarge">{nome}</Text>
      <Text variant="titleMedium">Lista de Pedidos</Text>
      <Text variant="titleSmall">Em construção...</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 16,
    backgroundColor: '#fff',
  },
  title: {
    fontSize: 24,
    marginBottom: 16,
    textAlign: 'center',
  },
  itemContainer: {
    padding: 16,
    borderBottomWidth: 1,
    borderBottomColor: '#ccc',
  },
  itemText: {
    fontSize: 18,
  },
  emptyText: {
    fontSize: 18,
    textAlign: 'center',
    marginTop: 20,
  },
});

export default PedidosScreen;
