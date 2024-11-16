import { LojaDTO, TipoLoja } from "./loja";
import { ProdutoDTO } from "./produto";

export type Cliente = {
  id: number;
  nome: string;
  email: string;
  telefone: number;
  logradouro: string;
  numero: number;
  complemento: string;
  bairro: string;
  cep: string;
  whatsapp: string;
};

type PedidoProdutoDTO = {
  id: number;
  idPedido: number;
  idProduto: number;
  quantidade: number;
  produto?: ProdutoDTO;
  pedido?: PedidoDTO;
};

export type PedidoDTO = {
  id: number;
  dataPedido: Date;
  idLoja: number;
  idCliente: number;
  atendido: boolean;
  dataAtendimento?: Date;
  lojaPedido?: LojaDTO;
  clientePedido?: Cliente;
  pedidoProdutos?: PedidoProdutoDTO[];
};
