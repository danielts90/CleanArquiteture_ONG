using OngApi.Entities;
using OngApi.Interfaces.UseCases;

namespace OngApi.UseCases
{
    public class OngUseCase : IOngUseCase
    {
        public Task BaixarEstoque(Ong ong, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ListarEstoque(Ong ong)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ListarPedidos(Ong ong)
        {
            throw new NotImplementedException();
        }
    }
}
