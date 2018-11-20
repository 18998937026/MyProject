using System.Collections.Generic;
using ABPCoreTest.Roles.Dto;
using ABPCoreTest.Users.Dto;

namespace ABPCoreTest.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
