using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ECommerce.Domain.Contracts.Seed;
using ECommerce.Domain.Models.Product;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence.Seed
{
    public class DataSeeding : IDataSeeding
    {
        private readonly StoreDBContext _context;
        public DataSeeding(StoreDBContext context)
        {
            _context = context;
        }
        public void DataSeed()
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }

            if (_context.Brands.Any())
            {
                var BrandData = File.ReadAllText(@"..\Infrastructure\ECommerce.Persistence\Data\brands.json");
                var Brands  =JsonSerializer.Deserialize<List<ProductBrand>>(BrandData);

                if (Brands is not null && Brands.Any())
                {
                    _context.Brands.AddRange(Brands);
                }
            }

            if (_context.Types.Any())
            {
                var TypesData = File.ReadAllText(@"..\Infrastructure\ECommerce.Persistence\Data\types.json");
                var Types = JsonSerializer.Deserialize<List<ProductType>>(TypesData);

                if (Types is not null && Types.Any())
                {
                    _context.Types.AddRange(Types);
                }
            }


            if (_context.Products.Any())
            {
                var ProductsData = File.ReadAllText(@"..\Infrastructure\ECommerce.Persistence\Data\products.json");
                var Products = JsonSerializer.Deserialize<List<Product>>(ProductsData);

                if (Products is not null && Products.Any())
                {
                    _context.Products.AddRange(Products);
                }
            }

            _context.SaveChanges();
        }
    }
}
