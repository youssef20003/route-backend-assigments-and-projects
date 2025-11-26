using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Reposatories.GenaricRepo
{
    public class GenaricRepo<TEntity> : IGenaricRepo<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDBContext _context;

        public GenaricRepo(ApplicationDBContext context)
        {
            this._context = context;
        }
        public IQueryable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _context.Set<TEntity>().Where(e => e.IsDeleted != true);
            }
            else
            {
                return _context.Set<TEntity>().AsNoTracking().Where(e => e.IsDeleted != true);
            }
        }

        public TEntity GetById(int id)
        {
            var type = _context.Set<TEntity>().Find(id);

            return type;
        }
        public void Add(TEntity Item)
        {
            _context.Set<TEntity>().Add(Item);
            
        }
        public void Update(TEntity Item)
        {
            _context.Set<TEntity>().Update(Item);
        
        }

        public void Delete(int id)
        {
            var item = _context.Set<TEntity>().Find(id);
            if (item == null)
                
            
            item.IsDeleted = true;
           
        }
       
    }
}
