using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Models;
using ECommerce.Persistence.Contexts;
using ECommerce.Persistence.Repos;

namespace ECommerce.Persistence.UOW
{
    public class UnitOfWork: IUOW
    {
        private readonly StoreDBContext _context;
        public UnitOfWork( StoreDBContext context)
        {
            _context = context;
        }

        private readonly Dictionary<string, object> _repos = [];
        public IGenaricRepo<TEntity, TKey> getRepo<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
            var TypeName = typeof(TEntity).Name;
            if (_repos.ContainsKey(TypeName))
            {
                return (IGenaricRepo<TEntity , TKey>)  _repos[TypeName];
            }
            else
            {
                var Repo = new GenaricRepo<TEntity, TKey>(_context);

                _repos.Add(TypeName , Repo);
                return Repo;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
