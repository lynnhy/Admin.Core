using Admin.Core.Services.BASE;
using Admin.Core.Model.Models;
using Admin.Core.IRepository;
using Admin.Core.IServices;

namespace Admin.Core.Services
{	
	/// <summary>
	/// ModuleServices
	/// </summary>	
	public class ModuleServices : BaseServices<Module>, IModuleServices
    {
	
        IModuleRepository _dal;
        public ModuleServices(IModuleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
