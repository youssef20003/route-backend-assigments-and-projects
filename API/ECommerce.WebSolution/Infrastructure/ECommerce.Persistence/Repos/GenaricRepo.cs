using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Models;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Specifications;

namespace ECommerce.Persistence.Repos
{
    public class GenaricRepo<TEntity, TKey>(StoreDBContext _context) : IGenaricRepo<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _context.Set<TEntity>().ToListAsync();

        public async Task<IEnumerable<TEntity>> GetAllWithSpecificatoinsAsync(ISpecifications<TEntity, TKey> specifications)
        {
            var query = SpecificationEvaluator
                .CreateQuery(_context.Set<TEntity>(), specifications);

            return await query.ToListAsync();
        }


        public async Task<TEntity> GetByIdAsync(TKey id) => await _context.Set<TEntity>().FindAsync(id);

        public async Task<TEntity> GetByIdSpecificatoinsAsync(ISpecifications<TEntity, TKey> specifications)
        {
            return await SpecificationEvaluator
                .CreateQuery(_context.Set<TEntity>(), specifications).FirstOrDefaultAsync();

             
        }

        public async Task<int> GetCOuntSpecificatoinsAsync(ISpecifications<TEntity, TKey> specifications)
        {
            var Query = SpecificationEvaluator.CreateQuery(_context.Set<TEntity>(), specifications);
            return await Query.CountAsync();
        }


        public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);
       

        public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

        public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);


    }
}
