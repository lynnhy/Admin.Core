using Admin.Core.IServices.BASE;
using Admin.Core.Model;
using Admin.Core.Model.Models;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<MessageModel<string>> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
