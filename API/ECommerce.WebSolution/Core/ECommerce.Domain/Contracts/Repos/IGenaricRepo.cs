using ECommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Specifications;

namespace ECommerce.Domain.Contracts.Repos
{
    public interface IGenaricRepo<TEntity , TKey> where TEntity : BaseEntity<TKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> GetAllWithSpecificatoinsAsync( ISpecifications<TEntity , TKey> specifications);
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> GetByIdSpecificatoinsAsync(ISpecifications<TEntity, TKey> specifications);

        Task<int> GetCOuntSpecificatoinsAsync(ISpecifications<TEntity, TKey> specifications);
        void Add (TEntity entity);
        void Update (TEntity entity);
        void Delete (TEntity entity);
    }
}
