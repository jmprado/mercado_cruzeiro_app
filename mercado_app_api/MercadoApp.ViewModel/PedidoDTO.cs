namespace MercadoApp.DTOs;

public class PedidoDTO
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public int IdLoja { get; set; }
    public int IdCliente { get; set; }
    public LojaDTO? Loja { get; set; }
    public ClienteDTO? Cliente { get; set; }
    public ICollection<PedidoProdutoDTO>? PedidoProdutos { get; set; }
}
