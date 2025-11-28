using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Repos;
using StackExchange.Redis;

namespace ECommerce.Persistence.Repos
{
    public class CacheRepo(IConnectionMultiplexer connection) : ICacheRepo
    {
        private IDatabase _databas = connection.GetDatabase(); 
        public async Task<string?> GetAsync(string CacheKey)
        {
            var CacheValue = await _databas.StringGetAsync(CacheKey);
            return CacheValue.IsNullOrEmpty ? null: CacheValue.ToString();
        }

        public async Task SetAsync(string CacheKey, string CascheValue, TimeSpan TimeToLive)
        {
            await _databas.StringSetAsync(CacheKey, CascheValue, TimeToLive);
        }
    }
}
