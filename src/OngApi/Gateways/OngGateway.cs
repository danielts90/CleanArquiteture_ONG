using OngApi.Entities;
using OngApi.Interfaces.Gateways;
using OngApi.Repositories;

namespace OngApi.Gateways
{
    public class OngGateway : IOngGateway
    {
        private readonly OngRepository _ongRepository;

        public OngGateway(OngRepository ongRepository)
        {
            _ongRepository = ongRepository;
        }

        public Ong ObterPorId(int id)
        {
            var dao = _ongRepository.GetById(id);
            var ong = new Ong(dao);

            return ong;
        }
    }
}
