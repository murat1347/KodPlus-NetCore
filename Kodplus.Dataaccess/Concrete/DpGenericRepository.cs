using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using Kodplus.Dataaccess.Entities;
using Kodplus.Dataaccess.Interfaces;

namespace Kodplus.Dataaccess.Repositories
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly IDbConnection _dbConnection;
        
        public DpGenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<TEntity> GetAll()
        {
            //return _dbConnection.GetAll<TEntity>().ToList();
            return (_dbConnection.Query<TEntity>("SELECT * FROM dbo.Articles").ToList());
        }

        public TEntity GetById(int id)
        {
           
           /* return _dbConnection.Get<TEntity>(id)*/;
           return (_dbConnection.QueryFirst<TEntity>($"SELECT * FROM dbo.Articles WHERE Id= '{id}' "));
        }

        public void Insert(TEntity entity)
        {
            //    _dbConnection.Insert(entity);
          
            _dbConnection.Query<Article>("sp_InsertVal", entity,commandType:CommandType.StoredProcedure);
        }

        public void Update(TEntity entity)
        {
            //_dbConnection.Update(entity);

            _dbConnection.Query("sp_UpdateVal", entity, commandType: CommandType.StoredProcedure);
        }

        public void Delete(TEntity entity)
        {
            //_dbConnection.Delete(entity);
            _dbConnection.Query("sp_DeleteVal",entity,commandType:CommandType.StoredProcedure);
        }
    }
}
