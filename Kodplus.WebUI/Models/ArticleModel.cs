using System.Collections;

namespace Kodplus.WebUI.Models
{
    public class ArticleModel : IEnumerable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
