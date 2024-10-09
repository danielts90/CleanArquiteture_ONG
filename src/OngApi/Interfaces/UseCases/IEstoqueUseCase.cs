using OngApi.Entities;

namespace OngApi.Interfaces.UseCases
{
    public interface IEstoqueUseCase
    {
        void BaixarEstoque(Pedido pedido);
        void AdicionarEstoque(Doacao doacao);
    }
}
