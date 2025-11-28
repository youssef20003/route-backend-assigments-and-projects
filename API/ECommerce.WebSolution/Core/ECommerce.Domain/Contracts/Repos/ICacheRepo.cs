using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Contracts.Repos
{
    public interface ICacheRepo
    {
        Task<string?> GetAsync(string CacheKey);

        Task SetAsync (string CacheKey, string CascheValue , TimeSpan TimeToLive);
    }
}
