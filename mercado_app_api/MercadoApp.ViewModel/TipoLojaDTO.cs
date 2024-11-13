namespace MercadoApp.DTOs;

public class TipoLojaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<LojaDTO>? Lojas { get; set; }
}
