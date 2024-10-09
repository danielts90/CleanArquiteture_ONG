using OngApi.Entities;
using OngApi.Interfaces.UseCases;

namespace OngApi.UseCases
{
    public class PedidoUseCase : IPedidoUseCase
    {
        public Pedido CriarPedido(Ong solicitante, Ong distribuidor, List<Produto> produtos)
        {
            if(solicitante.Tipo != TipoOng.Receptora)
                throw new Exception("Somente ONGs do tipo Receptora podem criar pedidos.");
            
            if(distribuidor.Tipo != TipoOng.Distribuidora)
                throw new Exception("Somente ONGs do tipo Distribuidora podem receber pedidos.");

            if(!produtos.Any())
                throw new Exception("O pedido deve conter pelo menos um item.");

            return new Pedido(solicitante, distribuidor, produtos);
        }

        public void ProcessarPedido(Pedido pedido)
        {
            pedido.DataProcessamento = DateTime.Now;
            pedido.Situacao = StatusPedido.Processado;
        }

        public void RecusarPedido(Pedido pedido)
        {
            pedido.DataProcessamento = DateTime.Now;
            pedido.Situacao = StatusPedido.Recusado;
        }

        public bool ValidarEstoquePedido(List<Produto> estoque, Pedido pedido)
        {
            foreach(var produto in pedido.Produtos)
            {
                var produtoEstoque = estoque.FirstOrDefault(prod => prod.Tipo == produto.Tipo);
                if(produtoEstoque == null || produtoEstoque.Quantidade <= produto.Quantidade)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
