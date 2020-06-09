using Admin.Core.Repository.Base;
using Admin.Core.Model.Models;
using Admin.Core.IRepository;
using Admin.Core.IRepository.UnitOfWork;

namespace Admin.Core.Repository
{
    /// <summary>
    /// ModuleRepository
    /// </summary>	
    public class ModuleRepository : BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
