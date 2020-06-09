using Admin.Core.IRepository;
using Admin.Core.IRepository.UnitOfWork;
using Admin.Core.Model.Models;
using Admin.Core.Repository.Base;

namespace Admin.Core.Repository
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
