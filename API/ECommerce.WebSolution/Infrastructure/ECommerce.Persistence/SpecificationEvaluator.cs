using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Specifications;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence
{
    public static class SpecificationEvaluator
    {
        public static IQueryable<TEntity> CreateQuery<TEntity, TKey>(
            IQueryable<TEntity> baseQuery,
            ISpecifications<TEntity, TKey> specification)
            where TEntity : BaseEntity<TKey>
        {
            var Query = baseQuery;

            if (specification.Criteria is not null) 
            {

                Query = Query.Where(specification.Criteria);
            }

            if (specification.OrderBy is not null)
            {
                Query = Query.OrderBy(specification.OrderBy);
            }
            if (specification.OrderByDesc is not null)
            {
                Query = Query.OrderByDescending(specification.OrderByDesc);
            }

            if (specification.IsPaginated)
            {
                Query = Query.Skip(specification.Skip).Take(specification.Take);
            }

            if (specification.Includes is not null && specification.Includes.Any())
            {
                Query = specification.Includes.Aggregate(Query,
                    (CurrentQuey, Expression) => CurrentQuey.Include(Expression));
            }

            return Query;
        }
    }
}
