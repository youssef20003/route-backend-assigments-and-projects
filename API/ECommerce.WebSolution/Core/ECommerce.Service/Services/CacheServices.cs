using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Repos;

namespace ECommerce.Service.Services
{
    public class CacheServices (ICacheRepo cacheRepo):ICacheService

    {
        public async Task<string?> GetAsync(string CacheKey)
        {
            return await cacheRepo.GetAsync(CacheKey);
        }

        public async Task SetAsync(string CacheKey, object CascheValue, TimeSpan TimeToLive)
        {
            var value = JsonSerializer.Serialize(CascheValue);
            await cacheRepo.SetAsync(CacheKey, value, TimeToLive);

        }
    }
}
