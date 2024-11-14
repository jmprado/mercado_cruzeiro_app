using MercadoApp.Entities;

namespace MercadoApp.Repository.Abstraction;

public interface ITipoLojaRepository
{
    Task<IEnumerable<TipoLoja>> GetAllAsync();
    Task<TipoLoja?> GetByIdAsync(int id);
    Task AddAsync(TipoLoja entity);
    Task UpdateAsync(TipoLoja entity);
    Task DeleteAsync(int id);
}

public interface ILojaRepository
{
    Task<IEnumerable<Loja>> GetAllAsync();
    Task<Loja?> GetByIdAsync(int id);
    Task AddAsync(Loja entity);
    Task UpdateAsync(Loja entity);
    Task DeleteAsync(int id);
}

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<Produto?> GetByIdAsync(int id);
    Task AddAsync(Produto entity);
    Task UpdateAsync(Produto entity);
    Task DeleteAsync(int id);
}

public interface IUnidadeProdutoRepository
{
    Task<IEnumerable<UnidadeProduto>> GetAllAsync();
    Task<UnidadeProduto?> GetByIdAsync(int id);
    Task AddAsync(UnidadeProduto entity);
    Task UpdateAsync(UnidadeProduto entity);
    Task DeleteAsync(int id);
}

public interface IEstoqueRepository
{
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task<Estoque?> GetByIdAsync(int id);
    Task AddAsync(Estoque entity);
    Task UpdateAsync(Estoque entity);
    Task DeleteAsync(int id);
}

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> GetAllAsync();
    Task<Cliente?> GetByIdAsync(int id);
    Task AddAsync(Cliente entity);
    Task UpdateAsync(Cliente entity);
    Task DeleteAsync(int id);
}

public interface IPedidoRepository
{
    Task<IEnumerable<Pedido>> GetAllAsync();
    Task<Pedido?> GetByIdAsync(int id);
    Task AddAsync(Pedido entity);
    Task UpdateAsync(Pedido entity);
    Task DeleteAsync(int id);
}

public interface IPedidoProdutoRepository
{
    Task<IEnumerable<PedidoProduto>> GetAllAsync();
    Task<PedidoProduto?> GetByIdAsync(int id);
    Task AddAsync(PedidoProduto entity);
    Task UpdateAsync(PedidoProduto entity);
    Task DeleteAsync(int id);
}

public interface IEntradaProdutoRepository
{
    Task<IEnumerable<EntradaProduto>> GetAllAsync();
    Task<EntradaProduto?> GetByIdAsync(int id);
    Task AddAsync(EntradaProduto entity);
    Task UpdateAsync(EntradaProduto entity);
    Task DeleteAsync(int id);
}

public interface IImagemProdutoRepository
{
    Task<IEnumerable<ImagemProduto>> GetAllAsync();
    Task<ImagemProduto?> GetByIdAsync(int id);
    Task AddAsync(ImagemProduto entity);
    Task UpdateAsync(ImagemProduto entity);
    Task DeleteAsync(int id);
}
