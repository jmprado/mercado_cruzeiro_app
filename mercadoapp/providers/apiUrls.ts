const apiServer = process.env.REACT_APP_API_SERVER || 'https://b2c7-177-182-139-159.ngrok-free.app';

const base = {
  authentication: 'api/auth',
  loja: 'loja',
  cliente: 'cliente',
  produto: 'produto',
};

export const ApiUrls = {
  Login: () => `${apiServer}/${base.authentication}/login`,
  GetLojaByEmail: (email: string) => `${apiServer}/api/${base.loja}/getbyemail/${email}`,
  ListProdutosByLojaId: (lojaId: number) => `${apiServer}/api/${base.produto}/${lojaId}`,
  GetAllLojas: () => `${apiServer}/api/${base.loja}`,
  GetApiServer: () => `${apiServer}/api`,
} as const;
