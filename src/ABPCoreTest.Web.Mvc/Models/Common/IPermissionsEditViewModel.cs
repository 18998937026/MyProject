using System.Collections.Generic;
using ABPCoreTest.Roles.Dto;

namespace ABPCoreTest.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}