using System.Collections.Generic;
using System.Threading.Tasks;
using Admin.Core.Common;
using Admin.Core.IRepository;
using Admin.Core.IServices;
using Admin.Core.Model.Models;
using Admin.Core.Services.BASE;

namespace Admin.Core.Services
{
    public class TopicServices: BaseServices<Topic>, ITopicServices
    {

        ITopicRepository _dal;
        public TopicServices(ITopicRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 获取开Bug专题分类（缓存）
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 60)]
        public async Task<List<Topic>> GetTopics()
        {
            return await base.Query(a => !a.tIsDelete && a.tSectendDetail == "tbug");
        }

    }
}
