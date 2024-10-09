using OngApi.Entities;
using OngApi.Interfaces.UseCases;

namespace OngApi.UseCases
{
    public class OngUseCase : IOngUseCase
    {
        public IEnumerable<Produto> ListarEstoque(Ong ong)
        {
            return ong.Estoque;
        }

        public IEnumerable<Pedido> ListarPedidos(Ong ong)
        {
            throw new NotImplementedException();
        }
    }
}
