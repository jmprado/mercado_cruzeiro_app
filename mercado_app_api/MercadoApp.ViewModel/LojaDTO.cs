using MercadoApp.Entities;

namespace MercadoApp.DTOs;

public class LojaDTO
{
    public int Id { get; set; }
    public int IdTipoLoja { get; set; }
    public required string Nome { get; set; }
    public required string NomeProprietario { get; set; }
    public required string Email { get; set; }
    public required string Telefone { get; set; }
    public required string Whatsapp { get; set; }
    public required string Descricao { get; set; }
    public required string ImagemLoja { get; set; }
    public bool Delivery { get; set; }
    public TipoLoja? TipoLoja { get; set; }
}
