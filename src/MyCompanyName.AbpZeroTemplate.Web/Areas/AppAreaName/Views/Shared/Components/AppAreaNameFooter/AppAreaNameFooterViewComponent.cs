using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Sessions;
using MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : ViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public AppAreaNameFooterViewComponent(
            ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionAppService.GetCurrentLoginInformations()
            };

            return View(footerModel);
        }
    }
}
