using System.Threading.Tasks;

namespace NanolekPrototype.Services
{
    public interface IPackingProtocolService
    {
       Task GenerateNewProtocol();
       Task CheckProtocolStatus(int packagingProtocolId);
    }
}