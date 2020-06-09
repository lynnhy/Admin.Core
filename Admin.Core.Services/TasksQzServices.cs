
using Admin.Core.IRepository;
using Admin.Core.IServices;
using Admin.Core.Model.Models;
using Admin.Core.Services.BASE;

namespace Admin.Core.Services
{
    public partial class TasksQzServices : BaseServices<TasksQz>, ITasksQzServices
    {
        ITasksQzRepository _dal;
        public TasksQzServices(ITasksQzRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
                    