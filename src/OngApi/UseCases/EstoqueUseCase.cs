using OngApi.Entities;
using OngApi.Interfaces.UseCases;

namespace OngApi.UseCases
{
    public class EstoqueUseCase : IEstoqueUseCase
    {
        public void AdicionarEstoque(Doacao doacao)
        {
            foreach(var produto in doacao.Produtos)
            {
                var produtoEstoque = doacao.Distribuidora.Estoque.FirstOrDefault(o => o.Tipo == produto.Tipo);
                if (produtoEstoque != null)
                    produtoEstoque.Quantidade += produto.Quantidade;
                else
                {
                    doacao.Distribuidora.Estoque.Add(produto);
                }
            }
        }

        public void BaixarEstoque(Pedido pedido)
        {
            foreach(var produto in pedido.Produtos)
            {
                var produtoEstoque = pedido.Distribuidor.Estoque.First(o => o.Tipo == produto.Tipo);
                produtoEstoque.Quantidade -= produto.Quantidade;
            }
        }
    }
}
