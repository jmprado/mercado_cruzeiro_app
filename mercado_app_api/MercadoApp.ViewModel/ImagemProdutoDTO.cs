namespace MercadoApp.DTOs;

public class ImagemProdutoDTO
{
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public string Path { get; set; } = "";
    public ProdutoDTO? Produto { get; set; }
}
