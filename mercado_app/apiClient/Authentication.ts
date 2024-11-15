import { AuthModel } from '../types/AuthModel';


const apiServer = process.env.REACT_APP_API_SERVER || 'https://10.0.2.2:7019';

const LoginRequest = async (authData: AuthModel): Promise<Response> => {
  const url = `${apiServer}/api/auth/login`;
  return fetch(url, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify({
      login: authData.login,
      senha: authData.senha,
    }),
  });
};

export default LoginRequest;
