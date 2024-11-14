using AutoMapper;
using MercadoApp.DTOs;
using MercadoApp.Entities;
using MercadoApp.ViewModel;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Loja, AuthenticationModel>()
            .ForMember(dest => dest.Email, src => src.MapFrom(d => d.Email))
            .ForMember(dest => dest.Senha, src => src.MapFrom(d => d.Senha));
        CreateMap<TipoLoja, TipoLojaDTO>().ReverseMap();
        CreateMap<Loja, LojaDTO>()
            .ForMember(dest => dest.Delivery, src => src.MapFrom(de => de.Delivery == 1))
            .ReverseMap()
            .ForMember(dest => dest.Delivery, src => src.MapFrom(c => c.Delivery ? 1 : 0));
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
        CreateMap<UnidadeProduto, UnidadeProdutoDTO>().ReverseMap();
        CreateMap<Estoque, EstoqueDTO>().ReverseMap();
        CreateMap<Cliente, ClienteDTO>().ReverseMap();
        CreateMap<Pedido, PedidoDTO>()
            .ForMember(dest => dest.Atendido, src => src.MapFrom(d => d.Atendido == 1))
            .ReverseMap()
            .ForMember(dest => dest.Atendido, src => src.MapFrom(c => c.Atendido ? 1 : 0)); ;
        CreateMap<PedidoProduto, PedidoProdutoDTO>().ReverseMap();
        CreateMap<EntradaProduto, EntradaProdutoDTO>().ReverseMap();
        CreateMap<ImagemProduto, ImagemProdutoDTO>().ReverseMap();
    }
}