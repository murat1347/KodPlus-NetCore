using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodplus.Dataaccess.Entities;
using Kodplus.Dataaccess.Interfaces;

namespace Kodplus.Dataaccess.Repositories
{
    public class DpArticleRepository: DpGenericRepository<Article>,IArticleRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpArticleRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

    }
}
