public class Pedido
{
    public int PedidoId { get; set; }
    public DateTime DataPedido { get; set; }
    public int ClienteId { get; set; } 
    public Cliente Cliente { get; set; }
    public List<PedidoItem> Itens { get; set; } 
}