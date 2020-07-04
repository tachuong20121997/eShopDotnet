using eShopSolution.Application.Catalog.Product.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog
{
    public interface IPublicProductService
    {
        int Create(ProductCreateRequest request);

        int Update(ProductEditRequest request);

        int Delete(int productId);

    }
}
