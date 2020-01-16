using System.Linq;
using AngularProjeto2.EntityFramework;
using AngularProjeto2.MultiTenancy;

namespace AngularProjeto2.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AngularProjeto2DbContext _context;

        public DefaultTenantCreator(AngularProjeto2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
