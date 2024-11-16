using MercadoApp.DTOs;

namespace MercadoApp.Services.Abstraction;


public interface IProdutoService : IService<ProdutoDTO>
{
    Task<IEnumerable<ProdutoDTO>> GetByIdLojaAsync(int idLoja);
}
