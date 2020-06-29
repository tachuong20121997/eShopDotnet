using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities.Shop
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CategoryId { get; set; }

        public Caterogy Category { get; set; }
    }
}
