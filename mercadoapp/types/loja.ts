type TipoLoja = {
  id: number;
  nome: string;
  descricao?: string;
};

type LojaDTO = {
  id: number;
  idTipoLoja: number;
  nome: string;
  nomeProprietario: string;
  email: string;
  telefone: string;
  whatsapp: string;
  descricao: string;
  imagemLoja: string;
  delivery: boolean;
  tipoLoja?: string;
};

export { TipoLoja, LojaDTO };
