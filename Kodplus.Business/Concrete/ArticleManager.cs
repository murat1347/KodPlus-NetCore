using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodplus.Business.Interfaces;
using Kodplus.Dataaccess.Entities;
using Kodplus.Dataaccess.Interfaces;

namespace Kodplus.Business.Concrete
{
    public class ArticleManager: GenericManager<Article> ,IArticleService
    {
        readonly IArticleRepository _repository;
        public ArticleManager(IGenericRepository<Article> genericService, IArticleRepository repository) : base(genericService)
        {
            _repository = repository;
        }
    }
}
