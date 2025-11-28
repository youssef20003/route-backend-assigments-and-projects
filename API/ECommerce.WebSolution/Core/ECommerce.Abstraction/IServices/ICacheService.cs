using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface ICacheService
    {
        Task<string?> GetAsync(string CacheKey);

        Task SetAsync(string CacheKey , object CascheValue , TimeSpan TimeToLive);

    }
}
