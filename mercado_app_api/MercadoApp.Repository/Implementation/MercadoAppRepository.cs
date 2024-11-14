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

    public async Task<TipoLoja?> GetByIdAsync(int id)
    {
        return await _context.TiposLoja.FindAsync(id);
    }

    public async Task<TipoLoja> AddAsync(TipoLoja entity)
    {
        await _context.TiposLoja.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(TipoLoja entity)
    {
        _context.TiposLoja.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.TiposLoja.FindAsync(id);
        if (entity != null)
        {
            _context.TiposLoja.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<Loja?> GetByIdAsync(int id)
    {
        return await _context.Lojas.FindAsync(id);
    }

    public async Task<Loja> AddAsync(Loja entity)
    {
        await _context.Lojas.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(Loja entity)
    {
        _context.Lojas.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Lojas.FindAsync(id);
        if (entity != null)
        {
            _context.Lojas.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
    }

    public async Task<Loja?> Authenticate(string email, string senha)
    {
        return await _context.Lojas.FirstOrDefaultAsync(x => x.Email == email && x.Senha == senha);
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

    public async Task<Produto?> GetByIdAsync(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task<Produto> AddAsync(Produto entity)
    {
        await _context.Produtos.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(Produto entity)
    {
        _context.Produtos.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Produtos.FindAsync(id);
        if (entity != null)
        {
            _context.Produtos.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<UnidadeProduto?> GetByIdAsync(int id)
    {
        return await _context.UnidadesProduto.FindAsync(id);
    }

    public async Task<UnidadeProduto> AddAsync(UnidadeProduto entity)
    {
        await _context.UnidadesProduto.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(UnidadeProduto entity)
    {
        _context.UnidadesProduto.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.UnidadesProduto.FindAsync(id);
        if (entity != null)
        {
            _context.UnidadesProduto.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<Estoque?> GetByIdAsync(int id)
    {
        return await _context.Estoque.FindAsync(id);
    }

    public async Task<Estoque> AddAsync(Estoque entity)
    {
        await _context.Estoque.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(Estoque entity)
    {
        _context.Estoque.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Estoque.FindAsync(id);
        if (entity != null)
        {
            _context.Estoque.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<Cliente?> GetByIdAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task<Cliente> AddAsync(Cliente entity)
    {
        await _context.Clientes.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(Cliente entity)
    {
        _context.Clientes.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Clientes.FindAsync(id);
        if (entity != null)
        {
            _context.Clientes.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<Pedido?> GetByIdAsync(int id)
    {
        return await _context.Pedidos.FindAsync(id);
    }

    public async Task<Pedido> AddAsync(Pedido entity)
    {
        await _context.Pedidos.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(Pedido entity)
    {
        _context.Pedidos.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Pedidos.FindAsync(id);
        if (entity != null)
        {
            _context.Pedidos.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<PedidoProduto?> GetByIdAsync(int id)
    {
        return await _context.PedidoProdutos.FindAsync(id);
    }

    public async Task<PedidoProduto> AddAsync(PedidoProduto entity)
    {
        await _context.PedidoProdutos.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(PedidoProduto entity)
    {
        _context.PedidoProdutos.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.PedidoProdutos.FindAsync(id);
        if (entity != null)
        {
            _context.PedidoProdutos.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<EntradaProduto?> GetByIdAsync(int id)
    {
        return await _context.EntradaProdutos.FindAsync(id);
    }

    public async Task<EntradaProduto> AddAsync(EntradaProduto entity)
    {
        await _context.EntradaProdutos.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(EntradaProduto entity)
    {
        _context.EntradaProdutos.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.EntradaProdutos.FindAsync(id);
        if (entity != null)
        {
            _context.EntradaProdutos.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
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

    public async Task<ImagemProduto?> GetByIdAsync(int id)
    {
        return await _context.ImagensProduto.FindAsync(id);
    }

    public async Task<ImagemProduto> AddAsync(ImagemProduto entity)
    {
        await _context.ImagensProduto.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(ImagemProduto entity)
    {
        _context.ImagensProduto.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.ImagensProduto.FindAsync(id);
        if (entity != null)
        {
            _context.ImagensProduto.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
    }
}
