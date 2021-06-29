using OnlineExam.Models.Table;

using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace OnlineExam.Proxy
{
    public class WiredProxy : IWiredProxy
    {
        public async Task<ICollection<ArticleTable>> GetLastFiveArticlesAsync()
        {
            string url = "https://www.wired.com/feed/rss";

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            List<ArticleTable> articleList = new List<ArticleTable>();

            var fiveFeed = feed.Items.Take(10);

            foreach (SyndicationItem item in fiveFeed)
            {
                var articletable = new ArticleTable();

                articletable.ArticleId = item.Id;
                articletable.Title = item.Title.Text;
                articletable.Description = item.Summary.Text;

                articleList.Add(articletable);
            }

            return await Task.FromResult(articleList);
        }
    }
}
