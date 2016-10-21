using Abp.Configuration;
using Abp.Domain.Uow;
using Abp.Zero.AspNetCore;
using Microsoft.AspNetCore.Http;
using MyCompanyName.AbpZeroTemplate.Authorization.Roles;
using MyCompanyName.AbpZeroTemplate.Authorization.Users;
using MyCompanyName.AbpZeroTemplate.MultiTenancy;

namespace MyCompanyName.AbpZeroTemplate.Web.Identity
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager,
            IHttpContextAccessor contextAccessor, 
            ISettingManager settingManager, 
            IUnitOfWorkManager unitOfWorkManager,
            IAbpZeroAspNetCoreConfiguration configuration) 
            : base(
                  userManager,
                  contextAccessor, 
                  settingManager, 
                  unitOfWorkManager,
                  configuration)
        {
        }
    }
}
