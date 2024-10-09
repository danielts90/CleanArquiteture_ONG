namespace OngApi.Daos
{
    public class PedidoDAO
    {
        public int PedidoId { get; set; }
        public int Distribuidor { get; set; }
        public int Solicitante { get; set; }
        public DateTime? DataPedido { get; set; }
        public int StatusPedido { get; set; }
        public DateTime? DataProcessamento { get; set; }
    }
}
