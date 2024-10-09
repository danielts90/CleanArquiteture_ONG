namespace OngApi.Daos
{
    public class ProdutoDoacaoDAO
    {
        public int Id { get; set; }
        public int DoacaoId { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
    }
}
