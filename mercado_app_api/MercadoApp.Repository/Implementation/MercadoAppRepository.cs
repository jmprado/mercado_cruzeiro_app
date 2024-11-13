using MercadoApp.Entities;
using MercadoApp.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace MercadoApp.Repository.Implementation;

public class TipoLojaRepository : ITipoLojaRepository
{
    private readonly MercadoAppDbContext _context;

    public TipoLojaRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TipoLoja>> GetAllAsync()
    {
        return await _context.TiposLoja.ToListAsync();
    }

    public async Task<TipoLoja> GetByIdAsync(int id)
    {
        return await _context.TiposLoja.FindAsync(id);
    }

    public async Task AddAsync(TipoLoja entity)
    {
        await _context.TiposLoja.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TipoLoja entity)
    {
        _context.TiposLoja.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.TiposLoja.FindAsync(id);
        if (entity != null)
        {
            _context.TiposLoja.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class LojaRepository : ILojaRepository
{
    private readonly MercadoAppDbContext _context;

    public LojaRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Loja>> GetAllAsync()
    {
        return await _context.Lojas.ToListAsync();
    }

    public async Task<Loja> GetByIdAsync(int id)
    {
        return await _context.Lojas.FindAsync(id);
    }

    public async Task AddAsync(Loja entity)
    {
        await _context.Lojas.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Loja entity)
    {
        _context.Lojas.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Lojas.FindAsync(id);
        if (entity != null)
        {
            _context.Lojas.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class ProdutoRepository : IProdutoRepository
{
    private readonly MercadoAppDbContext _context;

    public ProdutoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> GetByIdAsync(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task AddAsync(Produto entity)
    {
        await _context.Produtos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Produto entity)
    {
        _context.Produtos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Produtos.FindAsync(id);
        if (entity != null)
        {
            _context.Produtos.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class UnidadeProdutoRepository : IUnidadeProdutoRepository
{
    private readonly MercadoAppDbContext _context;

    public UnidadeProdutoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UnidadeProduto>> GetAllAsync()
    {
        return await _context.UnidadesProduto.ToListAsync();
    }

    public async Task<UnidadeProduto> GetByIdAsync(int id)
    {
        return await _context.UnidadesProduto.FindAsync(id);
    }

    public async Task AddAsync(UnidadeProduto entity)
    {
        await _context.UnidadesProduto.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(UnidadeProduto entity)
    {
        _context.UnidadesProduto.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.UnidadesProduto.FindAsync(id);
        if (entity != null)
        {
            _context.UnidadesProduto.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class EstoqueRepository : IEstoqueRepository
{
    private readonly MercadoAppDbContext _context;

    public EstoqueRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Estoque>> GetAllAsync()
    {
        return await _context.Estoque.ToListAsync();
    }

    public async Task<Estoque> GetByIdAsync(int id)
    {
        return await _context.Estoque.FindAsync(id);
    }

    public async Task AddAsync(Estoque entity)
    {
        await _context.Estoque.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Estoque entity)
    {
        _context.Estoque.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Estoque.FindAsync(id);
        if (entity != null)
        {
            _context.Estoque.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class ClienteRepository : IClienteRepository
{
    private readonly MercadoAppDbContext _context;

    public ClienteRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente> GetByIdAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task AddAsync(Cliente entity)
    {
        await _context.Clientes.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Cliente entity)
    {
        _context.Clientes.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Clientes.FindAsync(id);
        if (entity != null)
        {
            _context.Clientes.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class PedidoRepository : IPedidoRepository
{
    private readonly MercadoAppDbContext _context;

    public PedidoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Pedido>> GetAllAsync()
    {
        return await _context.Pedidos.ToListAsync();
    }

    public async Task<Pedido> GetByIdAsync(int id)
    {
        return await _context.Pedidos.FindAsync(id);
    }

    public async Task AddAsync(Pedido entity)
    {
        await _context.Pedidos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Pedido entity)
    {
        _context.Pedidos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Pedidos.FindAsync(id);
        if (entity != null)
        {
            _context.Pedidos.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class PedidoProdutoRepository : IPedidoProdutoRepository
{
    private readonly MercadoAppDbContext _context;

    public PedidoProdutoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PedidoProduto>> GetAllAsync()
    {
        return await _context.PedidoProdutos.ToListAsync();
    }

    public async Task<PedidoProduto> GetByIdAsync(int id)
    {
        return await _context.PedidoProdutos.FindAsync(id);
    }

    public async Task AddAsync(PedidoProduto entity)
    {
        await _context.PedidoProdutos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PedidoProduto entity)
    {
        _context.PedidoProdutos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.PedidoProdutos.FindAsync(id);
        if (entity != null)
        {
            _context.PedidoProdutos.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class EntradaProdutoRepository : IEntradaProdutoRepository
{
    private readonly MercadoAppDbContext _context;

    public EntradaProdutoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<EntradaProduto>> GetAllAsync()
    {
        return await _context.EntradaProdutos.ToListAsync();
    }

    public async Task<EntradaProduto> GetByIdAsync(int id)
    {
        return await _context.EntradaProdutos.FindAsync(id);
    }

    public async Task AddAsync(EntradaProduto entity)
    {
        await _context.EntradaProdutos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(EntradaProduto entity)
    {
        _context.EntradaProdutos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.EntradaProdutos.FindAsync(id);
        if (entity != null)
        {
            _context.EntradaProdutos.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class ImagemProdutoRepository : IImagemProdutoRepository
{
    private readonly MercadoAppDbContext _context;

    public ImagemProdutoRepository(MercadoAppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ImagemProduto>> GetAllAsync()
    {
        return await _context.ImagensProduto.ToListAsync();
    }

    public async Task<ImagemProduto> GetByIdAsync(int id)
    {
        return await _context.ImagensProduto.FindAsync(id);
    }

    public async Task AddAsync(ImagemProduto entity)
    {
        await _context.ImagensProduto.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ImagemProduto entity)
    {
        _context.ImagensProduto.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.ImagensProduto.FindAsync(id);
        if (entity != null)
        {
            _context.ImagensProduto.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
