using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IOngUseCase
    {
        Task<IEnumerable<Produto>> ListarEstoque(Ong ong);
        Task BaixarEstoque(Ong ong, Pedido pedido);
        Task<IEnumerable<Pedido>> ListarPedidos(Ong ong);
    }
}
