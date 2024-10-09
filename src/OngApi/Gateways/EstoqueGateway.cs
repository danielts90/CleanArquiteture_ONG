using OngApi.Daos;
using OngApi.Entities;
using OngApi.Interfaces.Gateways;
using OngApi.Repositories;

namespace OngApi.Gateways
{
    public class EstoqueGateway : IEstoqueGateway
    {
        private readonly EstoqueRepository _estoqueRepository;

        public EstoqueGateway(EstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public List<Produto> GetProdutosByOngId(int ongId)
        {
            List<EstoqueDAO> estoque = _estoqueRepository.GetByOngId(ongId);
            List<Produto> produtos = new();

            foreach (var item in estoque) 
            {
                var produto = new Produto(estoque);
                produtos.Add(produto);
            }
            return produtos;
        }

        public void UpdateEstoque(int ongId, List<Produto> produtos)
        {
            throw new NotImplementedException();
        }
    }
}
