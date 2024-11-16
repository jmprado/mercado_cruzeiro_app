import * as React from 'react';
import { View } from 'react-native';
import { Button, Text } from 'react-native-paper';

import { styles } from './styles/shared';

const SobreScreen = ({ navigation }: any) => {
  return (
    <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
      <Text variant="displayMedium" style={styles.sobreTextStyle}>
        Mercado do Cruzeiro App
      </Text>
      <Text variant="headlineMedium" style={styles.sobreTextStyle}>
        Análise e Desenvolvimento de Sistemas
      </Text>
      <Text variant="headlineMedium" style={styles.sobreTextStyle}>
        Projeto de Extensão Universitária
      </Text>
      <Text variant="headlineSmall" style={styles.sobreTextStyle}>
        Programação Para Dispositivos Móveis em Android
      </Text>
      <Text variant="titleLarge" style={styles.sobreTextStyle}>
        Aluno: João Márcio Gonçalves Prado
      </Text>
      <Text variant="titleLarge" style={styles.textCenter}>
        Novembro de 2024
      </Text>
      <Text variant="bodyMedium" style={styles.textPadding}>
        Desenvolver e implementar um aplicativo móvel para ajudar pequenos comerciantes do Mercado
        Distrital do Cruzeiro a aumentar suas vendas, melhorar o gerenciamento de inventário e
        fidelizar clientes, promovendo o desenvolvimento econômico local e o engajamento
        comunitário.
      </Text>
      <Button onPress={() => navigation.navigate('home')} mode="contained">Voltar para a Home</Button>
    </View>
  );
};

export default SobreScreen;
