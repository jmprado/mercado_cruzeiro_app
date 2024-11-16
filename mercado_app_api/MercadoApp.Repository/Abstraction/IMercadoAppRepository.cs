using MercadoApp.Entities;

namespace MercadoApp.Repository.Abstraction;

public interface ITipoLojaRepository
{
    Task<IEnumerable<TipoLoja>> GetAllAsync();
    Task<TipoLoja?> GetByIdAsync(int id);
    Task<TipoLoja> AddAsync(TipoLoja entity);
    Task<bool> UpdateAsync(TipoLoja entity);
    Task<bool> DeleteAsync(int id);
}

public interface ILojaRepository
{
    Task<IEnumerable<Loja>> GetAllAsync();
    Task<Loja?> GetByIdAsync(int id);
    Task<Loja> AddAsync(Loja entity);
    Task<Loja?> AuthenticateAsync(string email, string senha);
    Task<bool> UpdateAsync(Loja entity);
    Task<bool> DeleteAsync(int id);
    Task<Loja?> GetByEmailAsync(string email);
}

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<Produto?> GetByIdAsync(int id);
    Task<Produto> AddAsync(Produto entity);
    Task<bool> UpdateAsync(Produto entity);
    Task<bool> DeleteAsync(int id);
    Task<IEnumerable<Produto>> GetByIdLojaAsync(int idLoja);
}

public interface IUnidadeProdutoRepository
{
    Task<IEnumerable<UnidadeProduto>> GetAllAsync();
    Task<UnidadeProduto?> GetByIdAsync(int id);
    Task<UnidadeProduto> AddAsync(UnidadeProduto entity);
    Task<bool> UpdateAsync(UnidadeProduto entity);
    Task<bool> DeleteAsync(int id);
}

public interface IEstoqueRepository
{
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task<Estoque?> GetByIdAsync(int id);
    Task<Estoque> AddAsync(Estoque entity);
    Task<bool> UpdateAsync(Estoque entity);
    Task<bool> DeleteAsync(int id);
}

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> GetAllAsync();
    Task<Cliente?> GetByIdAsync(int id);
    Task<Cliente> AddAsync(Cliente entity);
    Task<bool> UpdateAsync(Cliente entity);
    Task<bool> DeleteAsync(int id);
}

public interface IPedidoRepository
{
    Task<IEnumerable<Pedido>> GetAllAsync();
    Task<Pedido?> GetByIdAsync(int id);
    Task<Pedido> AddAsync(Pedido entity);
    Task<bool> UpdateAsync(Pedido entity);
    Task<bool> DeleteAsync(int id);
}

public interface IPedidoProdutoRepository
{
    Task<IEnumerable<PedidoProduto>> GetAllAsync();
    Task<PedidoProduto?> GetByIdAsync(int id);
    Task<PedidoProduto> AddAsync(PedidoProduto entity);
    Task<bool> UpdateAsync(PedidoProduto entity);
    Task<bool> DeleteAsync(int id);
}

public interface IEntradaProdutoRepository
{
    Task<IEnumerable<EntradaProduto>> GetAllAsync();
    Task<EntradaProduto?> GetByIdAsync(int id);
    Task<EntradaProduto> AddAsync(EntradaProduto entity);
    Task<bool> UpdateAsync(EntradaProduto entity);
    Task<bool> DeleteAsync(int id);
}

public interface IImagemProdutoRepository
{
    Task<IEnumerable<ImagemProduto>> GetAllAsync();
    Task<ImagemProduto?> GetByIdAsync(int id);
    Task<ImagemProduto> AddAsync(ImagemProduto entity);
    Task<bool> UpdateAsync(ImagemProduto entity);
    Task<bool> DeleteAsync(int id);
}
