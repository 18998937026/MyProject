using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCoreTest.Controllers;

namespace ABPCoreTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPCoreTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
