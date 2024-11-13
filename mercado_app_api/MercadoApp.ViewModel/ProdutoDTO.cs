namespace MercadoApp.DTOs;

public class ProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public int Preco { get; set; }
    public ICollection<EstoqueDTO>? Estoques { get; set; }
    public ICollection<PedidoProdutoDTO>? PedidoProdutos { get; set; }
    public ICollection<EntradaProdutoDTO>? EntradaProdutos { get; set; }
    public ICollection<ImagemProdutoDTO>? ImagemProdutos { get; set; }
}
