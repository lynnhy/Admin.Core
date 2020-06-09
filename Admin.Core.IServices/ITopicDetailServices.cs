using Admin.Core.IServices.BASE;
using Admin.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{
    public interface ITopicDetailServices : IBaseServices<TopicDetail>
    {
        Task<List<TopicDetail>> GetTopicDetails();
    }
}
