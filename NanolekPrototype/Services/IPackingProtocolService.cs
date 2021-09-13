using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Services
{
    public interface IPackingProtocolService
    {
       Task GenerateNewProtocol();
       Task CheckProtocolStatus(int packagingProtocolId);
       JsonResult AjaxResponse(PackagingProtocolForm form);
    }
}