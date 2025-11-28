using ECommerce.Domain.Contracts.Seed;
using ECommerce.Domain.Models.Order;
using ECommerce.Domain.Models.Product;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Seed  
{
    public class DataSeeding : IDataSeeding
    {
        private readonly StoreDBContext _context;
        public DataSeeding(StoreDBContext context)
        {
            _context = context;
        }
        public async Task DataSeedAsync()
        {
            var PendingMigrations = await _context.Database.GetPendingMigrationsAsync();
            if (PendingMigrations.Any())
            {
                _context.Database.Migrate();
            }

            // ----------------------
            // 1. Seed Brands
            // ----------------------
            if (!_context.Brands.Any())
            {
                var brandData = await File.ReadAllTextAsync(@"..\Infrastructure\ECommerce.Persistence\Data\brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

                if (brands is not null && brands.Any())
                    _context.Brands.AddRange(brands);
            }

            // ----------------------
            // 2. Seed Types
            // ----------------------
            if (!_context.Types.Any())
            {
                var typesData = await File.ReadAllTextAsync(@"..\Infrastructure\ECommerce.Persistence\Data\types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                if (types is not null && types.Any())
                    _context.Types.AddRange(types);
            }

            await _context.SaveChangesAsync();


            // ----------------------
            // 3. Seed Products (depends on types + brands)
            // ----------------------
            if (!_context.Products.Any())
            {
                var productsData = await File.ReadAllTextAsync(@"..\Infrastructure\ECommerce.Persistence\Data\products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                if (products is not null && products.Any())
                    _context.Products.AddRange(products);
            }

            await _context.SaveChangesAsync();

            // ----------------------
            // 4. Seed Delivery Methods
            // ----------------------
            if (!await _context.DeliveryMethods.AnyAsync())
            {
                var dmData = await File.ReadAllTextAsync(
                    @"..\Infrastructure\ECommerce.Persistence\Data\delivery.json"
                );

                var methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(dmData);

                if (methods is not null && methods.Any())
                    await _context.DeliveryMethods.AddRangeAsync(methods);
            }

            await _context.SaveChangesAsync();


        }
    }
}
