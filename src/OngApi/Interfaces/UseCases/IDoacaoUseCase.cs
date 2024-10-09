using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IDoacaoUseCase
    {
        Doacao RegistrarDoacao(Ong distribuidora, List<Produto> produtos);
    }
}
