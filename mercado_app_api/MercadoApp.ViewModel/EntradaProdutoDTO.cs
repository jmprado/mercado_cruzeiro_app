namespace MercadoApp.DTOs;

public class EntradaProdutoDTO
{
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public int IdProduto { get; set; }
    public DateTime DataOperacao { get; set; }
    public ProdutoDTO? Produto { get; set; }
}
