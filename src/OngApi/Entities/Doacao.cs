namespace OngApi.Entities
{
    public class Doacao
    {
        public int Id { get; set; }
        public Ong? Distribuidora { get; set; }
        public List<Produto>? Produtos { get; set; }
    }
}
