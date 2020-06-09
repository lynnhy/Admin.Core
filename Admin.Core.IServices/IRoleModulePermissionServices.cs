using Admin.Core.IServices.BASE;
using Admin.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{
    /// <summary>
    /// RoleModulePermissionServices
    /// </summary>	
    public interface IRoleModulePermissionServices :IBaseServices<RoleModulePermission>
	{

        Task<List<RoleModulePermission>> GetRoleModule();
        Task<List<RoleModulePermission>> TestModelWithChildren();
        Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
        Task<List<RoleModulePermission>> GetRMPMaps();
    }
}
