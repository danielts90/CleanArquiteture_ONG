using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IPedidoUseCase
    {
        Pedido CriarPedido(Ong solicitante, Ong Distribuidor, List<Produto> produtos);
        void ProcessarPedido(Pedido pedido);
        void RecusarPedido(Pedido pedido);
        bool ValidarEstoquePedido(List<Produto> estoque, Pedido pedido);
    }
}
