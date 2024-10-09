using OngApi.Entities;
using OngApi.Interfaces.UseCases;

namespace OngApi.UseCases
{
    public class DoacaoUseCase : IDoacaoUseCase
    {
        public Doacao RegistrarDoacao(Ong distribuidora, List<Produto> produtos)
        {
            if (distribuidora.Tipo != TipoOng.Distribuidora)
                throw new Exception("Apena ONGs distribuidoras podem receber doações.");

            if (!produtos.Any())
                throw new Exception("Doação deve conter pelo menos um produto.");

            return new Doacao(distribuidora, produtos);
        }
    }
}
