using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.UI;
using Microsoft.AspNet.Identity;
using PaulMiami.AspNetCore.Mvc.Recaptcha;

namespace MyCompanyName.AbpZeroTemplate.Web.Controllers
{
    public abstract class AbpZeroTemplateControllerBase: AbpController
    {
        private const string RecaptchaResponseKey = "g-recaptcha-response";

        protected AbpZeroTemplateControllerBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        protected async Task CheckCaptchaResponseAsync(IRecaptchaValidationService recaptchaValidationService)
        {
            string response = Request.Form[RecaptchaResponseKey];
            var remoteIp = HttpContext.Connection?.RemoteIpAddress?.ToString();

            if (response.IsNullOrEmpty())
            {
                throw new UserFriendlyException(L("CaptchaCanNotBeEmpty"));
            }

            try
            {
                await recaptchaValidationService.ValidateResponseAsync(response, remoteIp);
            }
            catch (RecaptchaValidationException)
            {
                throw new UserFriendlyException(L("IncorrectCaptchaAnswer"));
            }
        }
    }
}