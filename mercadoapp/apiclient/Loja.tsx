import { AxiosInstance } from 'axios';
import { ApiUrls } from 'providers/apiUrls';

const GetLojaByEmail = async (authHttp: AxiosInstance, email: string | null) => {
  if (!email) {
    throw new Error('Email is required');
  }

  const url = ApiUrls.GetLojaByEmail(email);

  return authHttp.get(url);
};

export { GetLojaByEmail };
