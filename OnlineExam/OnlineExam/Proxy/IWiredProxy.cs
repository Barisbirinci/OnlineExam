using OnlineExam.Models.Table;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExam.Proxy
{
    public interface IWiredProxy
    {
        Task<ICollection<ArticleTable>> GetLastFiveArticlesAsync();
    }
}
