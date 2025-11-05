using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Models.Product
{
    public class Product:BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PictureUrl { get; set; } = null!;
        public Decimal  Price { get; set; } 
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public ProductBrand Brand { get; set; }
        public ProductType Type { get; set; }
    }
}
