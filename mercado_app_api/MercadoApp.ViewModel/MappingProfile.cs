using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TipoLoja, TipoLojaDTO>().ReverseMap();
        CreateMap<Loja, LojaDTO>()
            .ForMember(dest => dest.Delivery, src => src.MapFrom(de => de.Delivery == 1))
            .ReverseMap();
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
        CreateMap<UnidadeProduto, UnidadeProdutoDTO>().ReverseMap();
        CreateMap<Estoque, EstoqueDTO>().ReverseMap();
        CreateMap<Cliente, ClienteDTO>().ReverseMap();
        CreateMap<Pedido, PedidoDTO>()
            .ForMember(dest => dest.Atendido, src => src.MapFrom(d => d.Atendido == 1))
            .ReverseMap();
        CreateMap<PedidoProduto, PedidoProdutoDTO>().ReverseMap();
        CreateMap<EntradaProduto, EntradaProdutoDTO>().ReverseMap();
        CreateMap<ImagemProduto, ImagemProdutoDTO>().ReverseMap();
    }
}