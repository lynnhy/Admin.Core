using Admin.Core.IRepository;
using Admin.Core.IRepository.UnitOfWork;
using Admin.Core.Model.Models;
using Admin.Core.Repository.Base;

namespace Admin.Core.Repository
{
    public partial class PasswordLibRepository : BaseRepository<PasswordLib>, IPasswordLibRepository
    {
        public PasswordLibRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
