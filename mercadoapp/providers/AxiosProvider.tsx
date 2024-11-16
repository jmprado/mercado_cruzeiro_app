import axios, { AxiosInstance } from 'axios';
import { ApiUrls } from 'providers/apiUrls';
import React, { createContext, useContext, ReactNode } from 'react';

import { AuthContext } from './AuthProvider';

interface AxiosContextType {
  authHttp: AxiosInstance;
  http: AxiosInstance;
}

const AxiosContext = createContext<AxiosContextType | null>(null);
const { Provider } = AxiosContext;

const AxiosProvider = ({ children }: { children: ReactNode }) => {
  const authContext = useContext(AuthContext);
  const apiServer = ApiUrls.GetApiServer();

  const authAxios = axios.create({
    baseURL: apiServer,
  });

  const publicAxios = axios.create({
    baseURL: apiServer,
  });

  authAxios.interceptors.request.use(
    (config) => {
      if (authContext && config.headers && !config.headers.Authorization) {
        config.headers.Authorization = `Bearer ${authContext.getToken()}`;
      }

      return config;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  return (
    <Provider
      value={{
        authHttp: authAxios,
        http: publicAxios,
      }}>
      {children}
    </Provider>
  );
};

export { AxiosContext, AxiosProvider };
