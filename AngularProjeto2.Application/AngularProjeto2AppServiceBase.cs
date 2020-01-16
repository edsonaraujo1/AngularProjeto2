using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using AngularProjeto2.Authorization.Users;
using AngularProjeto2.MultiTenancy;
using AngularProjeto2.Users;
using Microsoft.AspNet.Identity;

namespace AngularProjeto2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AngularProjeto2AppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected AngularProjeto2AppServiceBase()
        {
            LocalizationSourceName = AngularProjeto2Consts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}