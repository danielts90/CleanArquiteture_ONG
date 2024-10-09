using OngApi.Daos;
using OngApi.Entities;
using OngApi.Interfaces.Gateways;
using OngApi.Repositories;

namespace OngApi.Gateways
{
    public class DoacaoGateway : IDoacaoGateway
    {
        private readonly DoacaoRepository _doacaoRepository;

        public DoacaoGateway(DoacaoRepository doacaoRepository)
        {
            _doacaoRepository = doacaoRepository;
        }

        public Doacao ObterDoacaoPorId(int id)
        {
            var doacaoDAO = _doacaoRepository.GetById(id);
            var doacao = new Doacao(doacaoDAO);

            return doacao;
        }

        public List<Doacao> ObterTodasDoacoes()
        {
            var list = _doacaoRepository.GetAll();
            List<Doacao> doacoes = new();

            foreach (var dao in list) 
            {
                var doacao = new Doacao(dao);
                doacoes.Add(doacao);
            }
            return doacoes;
        }

        public void SalvarDoacao(Doacao doacao)
        {
            var doacaoDAO = new DoacaoDAO(doacao);
            _doacaoRepository.Insert(doacaoDAO);

        }
    }
}
