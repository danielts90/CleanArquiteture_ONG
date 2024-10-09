using OngApi.Entities;

namespace OngApi.Interfaces.Gateways
{
    public interface IDoacaoGateway
    {
        void SalvarDoacao(Doacao doacao);
        Doacao ObterDoacaoPorId(int id);
        List<Doacao> ObterTodasDoacoes();
    }
}
