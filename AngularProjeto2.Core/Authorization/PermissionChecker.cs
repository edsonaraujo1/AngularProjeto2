using Abp.Authorization;
using AngularProjeto2.Authorization.Roles;
using AngularProjeto2.Authorization.Users;

namespace AngularProjeto2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
