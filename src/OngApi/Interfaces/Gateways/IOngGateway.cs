using OngApi.Entities;

namespace OngApi.Interfaces.Gateways
{
    public interface IOngGateway
    {
        Ong ObterPorId(int id);
    }
}
