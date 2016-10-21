using Microsoft.AspNetCore.Mvc;

namespace MyCompanyName.AbpZeroTemplate.Web.Controllers
{
    public class AboutController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}