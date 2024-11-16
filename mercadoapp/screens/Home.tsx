import { GetLojaByEmail } from 'apiclient/Loja';
import { AuthContext } from 'providers/AuthProvider';
import { AxiosContext } from 'providers/AxiosProvider';
import React, { useContext, useEffect, useState } from 'react';
import { View, Text, SafeAreaView } from 'react-native';
import { DataTable, SegmentedButtons } from 'react-native-paper';
import { LojaDTO } from 'types/loja';

import { styles } from './styles/shared';

const HomeScreen = ({ navigation }: any) => {
  const axioxContext = useContext(AxiosContext);
  const authContext = useContext(AuthContext);
  const [loja, setLoja] = useState<LojaDTO>();
  const [segmentedValue, setSegmentedValue] = useState<string>('produtos');

  // Navegação entre as telas de Produtos, Pedidos e Sobre
  const handleSegmentedButton = (value: string) => {
    setSegmentedValue(value);

    navigation.navigate(value, {
      idLoja: loja?.id,
      nome: loja?.nome,
    });
  };

  useEffect(() => {
    const fetchLoja = async () => {
      try {
        if (axioxContext?.authHttp) {
          const email = authContext?.email ?? null;
          const response = await GetLojaByEmail(axioxContext.authHttp, email);
          console.log(response.data);
          setLoja(response.data);
        } else {
          throw new Error('Axios instance is undefined');
        }
      } catch (error) {
        console.error(error);
      }
    };

    if (authContext?.email) {
      fetchLoja();
    }
  }, [authContext]);

  return (
    <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
      <Text style={styles.title}>Bem Vindo {loja?.nomeProprietario}!</Text>
      <Text style={styles.title_2}>Confira abaixo os detalhes da sua loja.</Text>
      <DataTable>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Tipo Loja</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.tipoLoja}</Text>
          </DataTable.Cell>
        </DataTable.Row>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Nome</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.nome}</Text>
          </DataTable.Cell>
        </DataTable.Row>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Descricao</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.descricao}</Text>
          </DataTable.Cell>
        </DataTable.Row>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Telefone</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.telefone}</Text>
          </DataTable.Cell>
        </DataTable.Row>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Whatsapp</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.whatsapp}</Text>
          </DataTable.Cell>
        </DataTable.Row>
        <DataTable.Row>
          <DataTable.Cell>
            <Text style={styles.detalheLojaLabel}>Faz Delivery</Text>
          </DataTable.Cell>
          <DataTable.Cell>
            <Text>{loja?.delivery ? 'Sim' : 'Não'}</Text>
          </DataTable.Cell>
        </DataTable.Row>
      </DataTable>
      <SafeAreaView style={styles.homeButtons}>
        <SegmentedButtons
          value={segmentedValue}
          onValueChange={handleSegmentedButton}
          buttons={[
            {
              value: 'produtos',
              label: 'Produtos',
            },
            {
              value: 'pedidos',
              label: 'Pedidos',
            },
            {
              value: 'sobre',
              label: 'Sobre',
            },
          ]}
        />
      </SafeAreaView>
    </View>
  );
};

export default HomeScreen;
