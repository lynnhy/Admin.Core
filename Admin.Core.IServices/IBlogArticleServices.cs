using Admin.Core.IServices.BASE;
using Admin.Core.Model.Models;
using Admin.Core.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Admin.Core.IServices
{
    public interface IBlogArticleServices :IBaseServices<BlogArticle>
    {
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> GetBlogDetails(int id);

    }

}
