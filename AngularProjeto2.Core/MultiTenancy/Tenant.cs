using Abp.MultiTenancy;
using AngularProjeto2.Authorization.Users;

namespace AngularProjeto2.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}