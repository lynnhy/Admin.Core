using Admin.Core.Services.BASE;
using Admin.Core.Model.Models;
using Admin.Core.IRepository;
using Admin.Core.IServices;

namespace Admin.Core.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {
	
        IModulePermissionRepository _dal;
        public ModulePermissionServices(IModulePermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
