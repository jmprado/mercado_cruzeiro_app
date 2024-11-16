using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoApp.Entities;

public class TipoLoja
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string? Descricao { get; set; } = "";

    public virtual ICollection<Loja>? Lojas { get; set; } = null;
}

public class Loja
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(TipoLoja))]
    public int IdTipoLoja { get; set; }
    public string Nome { get; set; } = "";
    public string NomeProprietario { get; set; } = "";
    public string Email { get; set; } = "";
    public string Senha { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Whatsapp { get; set; } = "";
    public string Descricao { get; set; } = "";
    public string ImagemLoja { get; set; } = "";
    public int Delivery { get; set; }

    public virtual TipoLoja? TipoLoja { get; set; } = null;
    public virtual ICollection<Estoque>? Estoques { get; set; } = null;
    public virtual ICollection<Pedido>? Pedidos { get; set; } = null;
    public virtual ICollection<Produto>? Produtos { get; set; } = null;
}

public class Produto
{
    [Key]
    public int Id { get; set; }
    public int IdLoja { get; set; }
    public string Nome { get; set; } = "";
    public string? Descricao { get; set; } = "";
    public int Preco { get; set; }

    public virtual Loja? Loja { get; set; } = null;
    public virtual ICollection<Estoque>? Estoques { get; set; } = null;
    public virtual ICollection<PedidoProduto>? PedidoProdutos { get; set; } = null;
    public virtual ICollection<EntradaProduto>? EntradaProdutos { get; set; } = null;
    public virtual ICollection<ImagemProduto>? ImagemProdutos { get; set; } = null;
}

public class UnidadeProduto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; } = "";

    public virtual ICollection<Estoque>? Estoques { get; set; } = null;
}

public class Estoque
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(Produto))]
    public int IdProduto { get; set; }
    [ForeignKey(nameof(Loja))]
    public int IdLoja { get; set; }
    [ForeignKey(nameof(UnidadeProduto))]
    public int IdUnidade { get; set; }
    public int Quantidade { get; set; }

    public virtual Produto? Produto { get; set; } = null;
    public virtual Loja? Loja { get; set; } = null;
    public virtual UnidadeProduto? UnidadeProduto { get; set; } = null;
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

    public virtual ICollection<Pedido>? Pedidos { get; set; } = null;
}

public class Pedido
{
    [Key]
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    [ForeignKey(nameof(Loja))]
    public int IdLoja { get; set; }
    [ForeignKey(nameof(Cliente))]
    public int IdCliente { get; set; }
    public int Atendido { get; set; }
    public DateTime? DataAtendimento { get; set; }

    public virtual Loja? Loja { get; set; } = new Loja();
    public virtual Cliente? Cliente { get; set; } = new Cliente();
    public virtual ICollection<PedidoProduto>? PedidoProdutos { get; set; } = null;
}

public class PedidoProduto
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(Pedido))]
    public int IdPedido { get; set; }
    [ForeignKey(nameof(Produto))]
    public int IdProduto { get; set; }
    public int Quantidade { get; set; }

    public virtual Pedido? Pedido { get; set; } = new Pedido();
    public virtual Produto? Produto { get; set; } = new Produto();
}

public class EntradaProduto
{
    [Key]
    public int Id { get; set; }
    public int Quantidade { get; set; }
    [ForeignKey(nameof(Produto))]
    public int IdProduto { get; set; }
    public DateTime DataOperacao { get; set; }

    public virtual Produto? Produto { get; set; } = new Produto();
}

public class ImagemProduto
{
    [Key]
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public string Path { get; set; } = "";

    public virtual Produto? Produto { get; set; } = new Produto();
}
