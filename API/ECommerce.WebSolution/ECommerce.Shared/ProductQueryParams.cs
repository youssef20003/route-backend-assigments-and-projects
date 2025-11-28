using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Shared.Enums;

namespace ECommerce.Shared
{
    public class ProductQueryParams
    {
        private const int DeafultSize = 5;
        private const int MaxSize = 10;
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public ProductSortingOptions? SortingOptions { get; set; }
        public string? SearchValue { get; set; }

        public int PageIndex { get; set; } = 1;

        private int pagesize = DeafultSize;

        public int PageSize
        {
            get => pagesize;
            set => pagesize = value > MaxSize ? MaxSize : value;
        }
    }
}
