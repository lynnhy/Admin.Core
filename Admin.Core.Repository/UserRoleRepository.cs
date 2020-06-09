using Admin.Core.FrameWork.IRepository;
using Admin.Core.Repository.Base;
using Admin.Core.Model.Models;
using Admin.Core.IRepository.UnitOfWork;

namespace Admin.Core.Repository
{
    /// <summary>
    /// UserRoleRepository
    /// </summary>	
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
