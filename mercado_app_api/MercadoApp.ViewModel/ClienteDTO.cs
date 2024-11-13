namespace MercadoApp.DTOs;

public class ClienteDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cep { get; set; }
    public ICollection<PedidoDTO>? Pedidos { get; set; }
}
