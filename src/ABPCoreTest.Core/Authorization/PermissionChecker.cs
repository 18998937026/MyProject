using Abp.Authorization;
using ABPCoreTest.Authorization.Roles;
using ABPCoreTest.Authorization.Users;

namespace ABPCoreTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
