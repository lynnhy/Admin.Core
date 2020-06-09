using Admin.Core.IRepository;
using Admin.Core.IRepository.UnitOfWork;
using Admin.Core.Model.Models;
using Admin.Core.Repository.Base;

namespace Admin.Core.Repository
{
    /// <summary>
    /// sysUserInfoRepository
    /// </summary>	
    public class sysUserInfoRepository : BaseRepository<sysUserInfo>, IsysUserInfoRepository
    {
        public sysUserInfoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
