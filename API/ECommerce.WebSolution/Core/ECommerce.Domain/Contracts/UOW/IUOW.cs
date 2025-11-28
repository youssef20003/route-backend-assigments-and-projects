using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Models;

namespace ECommerce.Domain.Contracts.UOW
{
    public interface IUOW
    {
        IGenaricRepo<TEntity, TKey> getRepo<TEntity, TKey>()
            where TEntity:BaseEntity<TKey>;
        Task<int> SaveChangesAsync();
    }
}
