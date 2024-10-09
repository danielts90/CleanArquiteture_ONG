using OngApi.Entities;
using OngApi.Interfaces.CA_Controllers;
using OngApi.Interfaces.Gateways;
using OngApi.Interfaces.UseCases;

namespace OngApi.CA_Controllers
{
    public class DoacaoController : IDoacaoController
    {
        private readonly IDoacaoUseCase _doacaoUseCase;
        private readonly IEstoqueUseCase _estoqueUseCase;
        private readonly IDoacaoGateway _doacaoGateway;
        private readonly IOngGateway _ongGateway;
        private readonly IEstoqueGateway _estoqueGateway;

        public DoacaoController(IDoacaoUseCase doacaoUseCase, 
                                IEstoqueUseCase estoqueUseCase, 
                                IDoacaoGateway doacaoGateway, 
                                IOngGateway ongGateway, 
                                IEstoqueGateway estoqueGateway)
        {
            _doacaoUseCase = doacaoUseCase;
            _estoqueUseCase = estoqueUseCase;
            _doacaoGateway = doacaoGateway;
            _ongGateway = ongGateway;
            _estoqueGateway = estoqueGateway;
        }

        public void RegistrarDoacao(int ongId, List<Produto> produtos)
        {
            var ong = _ongGateway.ObterPorId(ongId);
            var doacao = _doacaoUseCase.RegistrarDoacao(ong, produtos);
            _estoqueUseCase.AdicionarEstoque(doacao);

            _doacaoGateway.SalvarDoacao(doacao);
            _estoqueGateway.UpdateEstoque(ongId, doacao.Produtos);
        }
    }
}
