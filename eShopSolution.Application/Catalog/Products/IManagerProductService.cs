using eShopSolution.Application.Catalog.DTO;
using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManagerProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

    }
}
