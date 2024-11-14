using System.ComponentModel.DataAnnotations;

namespace MercadoApp.Entities;

public class TipoLoja
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";

    public virtual ICollection<Loja>? Lojas { get; set; } = [];
}

public class Loja
{
    [Key]
    public int Id { get; set; }
    public int IdTipoLoja { get; set; }
    public string Nome { get; set; } = "";
    public string NomeProprietario { get; set; } = "";
    public string Email { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Whatsapp { get; set; } = "";
    public string Descricao { get; set; } = "";
    public string ImagemLoja { get; set; } = "";
    public int Delivery { get; set; }

    public virtual TipoLoja TipoLoja { get; set; } = new TipoLoja();
    public virtual ICollection<Estoque>? Estoques { get; set; } = [];
    public virtual ICollection<Pedido>? Pedidos { get; set; } = [];
}

public class Produto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public int Preco { get; set; }

    public virtual ICollection<Estoque>? Estoques { get; set; } = [];
    public virtual ICollection<PedidoProduto>? PedidoProdutos { get; set; } = [];
    public virtual ICollection<EntradaProduto>? EntradaProdutos { get; set; } = [];
    public virtual ICollection<ImagemProduto>? ImagemProdutos { get; set; } = [];
}

public class UnidadeProduto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";

    public virtual ICollection<Estoque>? Estoques { get; set; } = new List<Estoque>();
}

public class Estoque
{
    [Key]
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public int IdLoja { get; set; }
    public int IdUnidade { get; set; }
    public int Quantidade { get; set; }

    public virtual Produto Produto { get; set; } = new Produto();
    public virtual Loja Loja { get; set; } = new Loja();
    public virtual UnidadeProduto UnidadeProduto { get; set; } = new UnidadeProduto();
}

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Email { get; set; } = "";
    public int Telefone { get; set; }
    public string Logradouro { get; set; } = "";
    public int Numero { get; set; }
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";
    public string Whatsapp { get; set; } = "";

    public virtual ICollection<Pedido>? Pedidos { get; set; } = [];
}

public class Pedido
{
    [Key]
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public int IdLoja { get; set; }
    public int IdCliente { get; set; }

    public virtual Loja Loja { get; set; } = new Loja();
    public virtual Cliente Cliente { get; set; } = new Cliente();
    public virtual ICollection<PedidoProduto>? PedidoProdutos { get; set; } = [];
}

public class PedidoProduto
{
    [Key]
    public int Id { get; set; }
    public int IdPedido { get; set; }
    public int IdProduto { get; set; }
    public int Quantidade { get; set; }

    public virtual Pedido Pedido { get; set; } = new Pedido();
    public virtual Produto Produto { get; set; } = new Produto();
}

public class EntradaProduto
{
    [Key]
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public int IdProduto { get; set; }
    public DateTime DataOperacao { get; set; }

    public virtual Produto Produto { get; set; } = new Produto();
}

public class ImagemProduto
{
    [Key]
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public string Path { get; set; } = "";

    public virtual Produto Produto { get; set; } = new Produto();
}
