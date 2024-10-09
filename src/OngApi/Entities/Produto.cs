using OngApi.Daos;

namespace OngApi.Entities
{
    public class Produto
    {
        public Produto(List<EstoqueDAO> estoque)
        {
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
