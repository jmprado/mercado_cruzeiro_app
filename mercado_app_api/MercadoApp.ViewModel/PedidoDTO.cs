using MercadoApp.Entities;

namespace MercadoApp.DTOs;

public class PedidoDTO
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public int IdLoja { get; set; }
    public int IdCliente { get; set; }
    public bool Atendido { get; set; }
    public DateTime? DataAtendimento { get; set; }
    public Loja? LojaPedido { get; set; }
    public Cliente? ClientePedido { get; set; }
    public List<PedidoProdutoDTO>? PedidoProdutos { get; set; }
}
