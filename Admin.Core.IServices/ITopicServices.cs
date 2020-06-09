using Admin.Core.IServices.BASE;
using Admin.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{
    public interface ITopicServices : IBaseServices<Topic>
    {
        Task<List<Topic>> GetTopics();
    }
}
