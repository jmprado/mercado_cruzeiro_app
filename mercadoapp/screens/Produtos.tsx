import { RouteProp } from '@react-navigation/native';
import { ListaProdutosByLojaId } from 'apiclient/Produto';
import { AxiosContext } from 'providers/AxiosProvider';
import React, { useContext, useEffect, useState } from 'react';
import { View, StyleSheet } from 'react-native';
import { DataTable, Text } from 'react-native-paper';

import { ProdutoDTO } from '../types/produto';

type ProdutosScreenRouteProp = RouteProp<{ params: { idLoja: number; nome: string } }, 'params'>;

type Props = {
  route: ProdutosScreenRouteProp;
};

const ProdutosScreen: React.FC<Props> = ({ route }: { route: ProdutosScreenRouteProp }) => {
  const { idLoja: itemId, nome } = route.params;

  const [produtos, setProdutos] = useState<ProdutoDTO[]>([]);
  const axiosContext = useContext(AxiosContext);

  const [page, setPage] = React.useState<number>(0);
  const [numberOfItemsPerPageList] = React.useState([5, 10]);
  const [itemsPerPage, onItemsPerPageChange] = React.useState(numberOfItemsPerPageList[0]);

  const from = page * itemsPerPage;
  const to = Math.min((page + 1) * itemsPerPage, produtos.length);

  useEffect(() => {
    const fetchProdutos = async () => {
      try {
        if (axiosContext?.authHttp) {
          const response = await ListaProdutosByLojaId(itemId, axiosContext.authHttp);
          if (response && response.data) {
            setProdutos(response.data);
          }
        } else {
          console.error('Axios instance is undefined');
        }
      } catch (error) {
        console.error(error);
      }
    };

    fetchProdutos();
  }, []);

  const renderItem = ({ item }: { item: ProdutoDTO }) => (
    <DataTable.Row key={item.id}>
      <DataTable.Cell>{item.nome}</DataTable.Cell>
      <DataTable.Cell numeric>{item.preco}</DataTable.Cell>
    </DataTable.Row>
  );

  return (
    <View style={styles.container}>
      <Text variant="titleLarge">{nome}</Text>
      <Text variant="titleMedium">Lista de Produtos</Text>
      <DataTable>
        <DataTable.Header>
          <DataTable.Title>Nome</DataTable.Title>
          <DataTable.Title numeric>Preço</DataTable.Title>
        </DataTable.Header>
        {produtos.slice(from, to).map((item) => renderItem({ item }))}
        <DataTable.Pagination
          page={page}
          numberOfPages={Math.ceil(produtos.length / itemsPerPage)}
          onPageChange={(page) => setPage(page)}
          label={`${from + 1}-${to} of ${produtos.length}`}
          numberOfItemsPerPageList={numberOfItemsPerPageList}
          numberOfItemsPerPage={itemsPerPage}
          onItemsPerPageChange={onItemsPerPageChange}
          showFastPaginationControls
          selectPageDropdownLabel="Linhas por página"
        />
      </DataTable>
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
});

export default ProdutosScreen;
