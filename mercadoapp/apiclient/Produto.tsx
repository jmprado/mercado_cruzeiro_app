import { AxiosInstance } from 'axios';
import { ApiUrls } from 'providers/apiUrls';

const ListaProdutosByLojaId = async (idLoja: number | null, authHttp: AxiosInstance) => {
  if (!idLoja) {
    throw new Error('Email is required');
  }

  const url = ApiUrls.ListProdutosByLojaId(idLoja);

  return authHttp.get(url);
};

export { ListaProdutosByLojaId };
