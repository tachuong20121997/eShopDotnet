using eShopSolution.Application.Catalog.DTO;
using eShopSolution.Application.Catalog.Product.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog
{
    public interface IManagerProductService
    {
        int Create(ProductCreateRequest request);

        int Update(ProductEditRequest request);

        int Delete(int productId);

        List<ProductViewModel> GetAll();  
        PageViewModel<ProductViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize);  

    }
}
