using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Exceptions;
using ECommerce.Domain.Models.Order;
using ECommerce.Domain.Models.Product;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Persistence.UOW;
using ECommerce.Shared.DTOS.IdentityDtos;
using ECommerce.Shared.DTOS.OrderDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Service.Specifications;

namespace ECommerce.Service.Services
{
    public class OrderService(IMapper mapper,IBasketRepo basketRepo, IUOW unitOfWork) : IOrderService
    {
        public async Task<OrderToReturnDto> CreateOrderAsync(OrderDto orderDto, string Email)
        {
            var OrderAddress = mapper.Map<AddressDto, OrderAddress>(orderDto.Address);

            var Basket = await basketRepo.GetBasketAsync(orderDto.BasketId) ?? throw new BasketNotFoundException(orderDto.BasketId);

            var OrderRepo = unitOfWork.getRepo<Order, Guid>();

            List<OrderItem> orderItems = [];

            var productRepo = unitOfWork.getRepo<Product, int>();

            foreach (var item in Basket.Items)
            {
                var Product = await productRepo.GetByIdAsync(item.Id) ?? throw new ProductNotFound(item.Id);
                var orderItem = new OrderItem()
                {
                    Product = new ProductItemOrderd()
                    {
                        ProductId = item.Id,
                        PictureUrl = Product.PictureUrl,
                        ProductName = item.Name,
                    },
                    Quantity = item.Quantity,
                    Price = Product.Price, 
                };
                orderItems.Add(orderItem);
            }
            var DeliveryMethod = await unitOfWork.getRepo<DeliveryMethod, int>().GetByIdAsync(orderDto.DeliveryMethodId) ?? throw new DeliveryMethodNotFound(orderDto.DeliveryMethodId);
            var SubTotal = orderItems.Sum(p => p.Price * p.Quantity);
            var order = new Order(Email, OrderAddress, DeliveryMethod, orderItems, SubTotal);
            unitOfWork.getRepo<Order, Guid>().Add(order);
            await unitOfWork.SaveChangesAsync();
            return mapper.Map<Order, OrderToReturnDto>(order);
        }

        public async Task<IEnumerable<DeliveryMethodDto>> GetDeliveryMethodsAsync()
        {
            var DeliveryMethods = await unitOfWork.getRepo<DeliveryMethod, int>().GetAllAsync();
            return mapper.Map<IEnumerable<DeliveryMethod>, IEnumerable<DeliveryMethodDto>>(DeliveryMethods);
        }

        public async Task<IEnumerable<OrderToReturnDto>> GetAllOrdersAsync(string Email)
        {
            var Spec = new OrderSpecifications(Email);
            var orders = await unitOfWork.getRepo<Order, Guid>().GetAllWithSpecificatoinsAsync(Spec);
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderToReturnDto>>(orders);
        }

        public async Task<OrderToReturnDto> GetOrderById(Guid OrderId)
        {
            var Spec = new OrderSpecifications(OrderId);
            var order = await unitOfWork.getRepo<Order, Guid>().GetByIdSpecificatoinsAsync(Spec);
            return mapper.Map<Order, OrderToReturnDto>(order);
        }
    }
}
