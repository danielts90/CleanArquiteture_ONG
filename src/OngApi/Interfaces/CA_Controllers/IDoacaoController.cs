using OngApi.Entities;

namespace OngApi.Interfaces.CA_Controllers
{
    public interface IDoacaoController
    {
        void RegistrarDoacao(int ongId, List<Produto> produtos);
    }
}
