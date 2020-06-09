using Admin.Core.IRepository;
using Admin.Core.IServices;
using Admin.Core.Model.Models;
using Admin.Core.Services.BASE;

namespace Admin.Core.Services
{
    public partial class PasswordLibServices : BaseServices<PasswordLib>, IPasswordLibServices
    {
        IPasswordLibRepository _dal;
        public PasswordLibServices(IPasswordLibRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
