namespace MercadoApp.DTOs;

public class ClienteDTO
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Email { get; set; }
    public int Telefone { get; set; }
    public required string Logradouro { get; set; }
    public int Numero { get; set; }
    public string? Complemento { get; set; }
    public required string Bairro { get; set; }
    public required string Cep { get; set; }
    public ICollection<PedidoDTO>? Pedidos { get; set; }
}
