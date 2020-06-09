using Admin.Core.IServices.BASE;
using Admin.Core.Model.Models;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{	
	/// <summary>
	/// RoleServices
	/// </summary>	
    public interface IRoleServices :IBaseServices<Role>
	{
        Task<Role> SaveRole(string roleName);
        Task<string> GetRoleNameByRid(int rid);

    }
}
