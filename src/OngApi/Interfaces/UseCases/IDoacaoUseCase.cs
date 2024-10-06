using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IDoacaoUseCase
    {
        Task ReceberDoacao(Doacao doacao);
    }
}
