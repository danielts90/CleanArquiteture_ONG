using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IOngUseCase
    {
        IEnumerable<Produto> ListarEstoque(Ong ong);
        IEnumerable<Pedido> ListarPedidos(Ong ong);
    }
}
