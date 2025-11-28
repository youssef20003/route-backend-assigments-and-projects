using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Exceptions;
using ECommerce.Domain.Models.Baskets;
using ECommerce.Shared.DTOS.BasketDtos;

namespace ECommerce.Service.Services
{
    public class BasketServices(IBasketRepo repo , IMapper mapper) : IBasketService
    {
        private readonly IBasketRepo _repo = repo;
        private readonly IMapper _mapper = mapper;

        public async Task<BasketDto> GetBasketAsync(string Key)
        {
            var basket = await _repo.GetBasketAsync(Key);
            if(basket is not null)
            {
                return _mapper.Map<CustomerBasket, BasketDto>(basket);
            }
            else
            {
                throw new BasketNotFoundException(Key);
            }
        }

        public async Task<BasketDto> CreateOrUpdateBasketAsync(BasketDto basket)
        {
            var CustomerBasket = _mapper.Map<BasketDto, CustomerBasket>(basket);

            var Savedbasket = await _repo.CreateUpdateBasketAsync(CustomerBasket);

            if (Savedbasket is not null)
            {
                return await GetBasketAsync(basket.Id);
            }
            else
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> DeleteBasketAsync(string Key)
        {
            return await _repo.DeleteBasketAsync(Key);
        }
    }
}
