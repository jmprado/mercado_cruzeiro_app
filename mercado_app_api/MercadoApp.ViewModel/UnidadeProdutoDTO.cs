namespace MercadoApp.DTOs;

public class UnidadeProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<EstoqueDTO>? Estoques { get; set; }
}
