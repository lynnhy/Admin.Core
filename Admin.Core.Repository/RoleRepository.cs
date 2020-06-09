using Admin.Core.IRepository;
using Admin.Core.Repository.Base;
using Admin.Core.Model.Models;
using Admin.Core.IRepository.UnitOfWork;

namespace Admin.Core.Repository
{
    /// <summary>
    /// RoleRepository
    /// </summary>	
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
