namespace MercadoApp.DTOs;

public class EstoqueDTO
{
    public int Id { get; set; }
    public int IdProduto { get; set; }
    public int IdLoja { get; set; }
    public int IdUnidade { get; set; }
    public int Quantidade { get; set; }
    public ProdutoDTO? Produto { get; set; }
    public LojaDTO? Loja { get; set; }
    public UnidadeProdutoDTO? UnidadeProduto { get; set; }
}
