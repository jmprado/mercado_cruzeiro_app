namespace MercadoApp.DTOs;

public class PedidoProdutoDTO
{
    public int Id { get; set; }
    public int IdPedido { get; set; }
    public int IdProduto { get; set; }
    public int Quantidade { get; set; }
    public ProdutoDTO? Produto { get; set; }
    public PedidoDTO? Pedido { get; set; }
}
