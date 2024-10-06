namespace OngApi.Entities
{
    public class Ong
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public TipoOng Tipo { get; set; }
        public List<Produto>? Estoque { get; set; }
    }

    public enum TipoOng
    {
        Distribuidora = 1, 
        Receptora = 2
    }
}
