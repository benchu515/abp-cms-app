using Abp.Authorization;
using CMS_Assignment.Authorization.Roles;
using CMS_Assignment.Authorization.Users;

namespace CMS_Assignment.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
