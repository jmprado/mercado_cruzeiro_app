namespace MercadoApp.DTOs;

public class LojaDTO
{
    public int Id { get; set; }
    public int IdTipoLoja { get; set; }
    public string Nome { get; set; }
    public string NomeProprietario { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Whatsapp { get; set; }
    public string Descricao { get; set; }
    public string ImagemLoja { get; set; }
    public int Delivery { get; set; }
    public TipoLojaDTO TipoLoja { get; set; }
    public ICollection<EstoqueDTO> Estoques { get; set; }
    public ICollection<PedidoDTO> Pedidos { get; set; }
}
