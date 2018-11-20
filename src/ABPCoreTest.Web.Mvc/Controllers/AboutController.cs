using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCoreTest.Controllers;

namespace ABPCoreTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ABPCoreTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
