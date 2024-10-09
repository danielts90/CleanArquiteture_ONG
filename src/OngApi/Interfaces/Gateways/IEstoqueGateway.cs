using OngApi.Entities;

namespace OngApi.Interfaces.Gateways
{
    public interface IEstoqueGateway
    {
        List<Produto> GetProdutosByOngId(int ongId);
        void UpdateEstoque(int ongId, List<Produto> produtos);
    }
}
