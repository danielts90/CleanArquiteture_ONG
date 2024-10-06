
namespace OngApi.Entities
{
    public class Pedido
    {
        public Pedido(Ong solicitante, Ong distribuidor, List<Produto> produtos)
        {
            Solicitante = solicitante;
            Distribuidor = distribuidor;
            Produtos = produtos;
            DataPedido = DateTime.Now;
            Situacao = StatusPedido.Novo;
        }

        public int Id { get; set; }
        public Ong Solicitante { get; }
        public Ong Distribuidor { get; }
        public List<Produto> Produtos { get; }
        public DateTime? DataPedido { get; }
        public DateTime? DataProcessamento { get; set; }
        public StatusPedido? Situacao { get; set; }
        
    }

    public enum StatusPedido
    {
        Novo = 1,
        Processado = 2,
        Recusado = 3
    }
}
