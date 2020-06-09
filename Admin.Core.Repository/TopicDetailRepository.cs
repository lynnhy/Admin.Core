using Admin.Core.IRepository;
using Admin.Core.IRepository.UnitOfWork;
using Admin.Core.Model.Models;
using Admin.Core.Repository.Base;

namespace Admin.Core.Repository
{
    public class TopicDetailRepository : BaseRepository<TopicDetail>, ITopicDetailRepository
    {
        public TopicDetailRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
