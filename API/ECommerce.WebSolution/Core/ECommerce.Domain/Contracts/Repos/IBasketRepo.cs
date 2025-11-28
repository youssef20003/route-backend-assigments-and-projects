using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Models.Baskets;

namespace ECommerce.Domain.Contracts.Repos
{
    public interface IBasketRepo
    {
        Task<CustomerBasket?> GetBasketAsync(string Key);

        Task<CustomerBasket?> CreateUpdateBasketAsync(CustomerBasket basket , TimeSpan? TimeToLive = null);

        Task<bool> DeleteBasketAsync(string Key);

    }
}
