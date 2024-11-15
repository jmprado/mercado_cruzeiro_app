import * as React from 'react';
import {Button, Dialog, Portal, Text} from 'react-native-paper';
import {View} from 'react-native';

const Alert = (props: any) => {
  const {show, text} = props;

  return (
    <View>
      <Portal>
        <Dialog visible={show.showAlert} onDismiss={show.setShowAlert(false)}>
          <Dialog.Content>
            <Text variant="bodyMedium">{text}</Text>
          </Dialog.Content>
          <Dialog.Actions>
            <Button onPress={() => show.setShowAlert(false)}>Fechar</Button>
          </Dialog.Actions>
        </Dialog>
      </Portal>
    </View>
  );
};

export default Alert;
