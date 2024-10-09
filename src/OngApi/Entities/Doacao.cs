using OngApi.Daos;

namespace OngApi.Entities
{
    public class Doacao
    {
        public Doacao(DoacaoDAO doacaoDAO)
        {
        }

        public Doacao(Ong distribuidora, List<Produto> produtos)
        {
            Distribuidora = distribuidora;
            Produtos = produtos;
        }

        public int Id { get; set; }
        public Ong? Distribuidora { get; set; }
        public List<Produto>? Produtos { get; set; }
    }
}
