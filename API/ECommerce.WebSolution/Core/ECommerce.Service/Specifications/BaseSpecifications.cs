using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Specifications;
using ECommerce.Domain.Models;

namespace ECommerce.Service.Specifications
{
    public abstract class BaseSpecifications<TEntity, TKey> : ISpecifications<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {

        public BaseSpecifications(Expression<Func<TEntity, bool>> _Criteria)
        {
            Criteria= _Criteria;
        }

        public Expression<Func<TEntity, bool>> Criteria { get; private set; }
        public List<Expression<Func<TEntity, object>>> Includes { get; }= [];
        public Expression<Func<TEntity, object>> OrderBy { get; private set; } 
        public Expression<Func<TEntity, object>> OrderByDesc { get; private set; }


        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool IsPaginated { get; set; }

        public void ApplyPagination(int PagesIndex, int PageSize)
        {
            IsPaginated = true;
            Take = PageSize;
            Skip = (PagesIndex -1 ) * PageSize;
        }

        protected void AddOrderBy(Expression<Func<TEntity, object>>  _OrderBy)
        {
           OrderBy = _OrderBy;
        }
        protected void AddOrderByDesc(Expression<Func<TEntity, object>> _OrderByDesc)
        {
            OrderByDesc = _OrderByDesc;
        }


        protected void AddInclude(Expression<Func<TEntity, object>> includExpression)
        {
            Includes.Add(includExpression);
        }
    }
}
