using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodplus.Business.Interfaces;
using Kodplus.Dataaccess.Interfaces;

namespace Kodplus.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        private readonly IGenericRepository<TEntity> _genericService;
        

        public GenericManager(IGenericRepository<TEntity> genericService)
        {
            _genericService = genericService;
        }


        public List<TEntity> GetAll()
        {
            return _genericService.GetAll().ToList();
        }

        public TEntity GetById(int id)
        {
            return _genericService.GetById(id);
        }

        public void Insert(TEntity entity)
        {
            _genericService.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _genericService.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _genericService.Delete(entity);
        }
    }
}
