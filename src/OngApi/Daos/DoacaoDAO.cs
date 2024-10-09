using OngApi.Entities;

namespace OngApi.Daos
{
    public class DoacaoDAO
    {
        public DoacaoDAO(Doacao doacao)
        {
        }

        public int DoacaoId { get; set; }
        public int? OngId { get; set; }
        public DateTime? DataDoacao { get; set; }
    }
}
