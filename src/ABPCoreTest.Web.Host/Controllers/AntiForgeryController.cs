using Microsoft.AspNetCore.Antiforgery;
using ABPCoreTest.Controllers;

namespace ABPCoreTest.Web.Host.Controllers
{
    public class AntiForgeryController : ABPCoreTestControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
