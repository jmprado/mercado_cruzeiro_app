using MercadoApp.Entities;

namespace MercadoApp.DTOs;

public class TipoLojaDTO
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public ICollection<Loja>? Lojas { get; set; }
}
