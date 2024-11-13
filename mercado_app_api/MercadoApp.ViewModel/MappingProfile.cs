using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TipoLoja, TipoLojaDTO>().ReverseMap();
        CreateMap<Loja, LojaDTO>().ReverseMap();
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
        CreateMap<UnidadeProduto, UnidadeProdutoDTO>().ReverseMap();
        CreateMap<Estoque, EstoqueDTO>().ReverseMap();
        CreateMap<Cliente, ClienteDTO>().ReverseMap();
        CreateMap<Pedido, PedidoDTO>().ReverseMap();
        CreateMap<PedidoProduto, PedidoProdutoDTO>().ReverseMap();
        CreateMap<EntradaProduto, EntradaProdutoDTO>().ReverseMap();
        CreateMap<ImagemProduto, ImagemProdutoDTO>().ReverseMap();
    }
}