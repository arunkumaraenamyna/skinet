using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductsRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>>  GetProductsAsync();

         Task<IReadOnlyList<ProductType>>  GetProductTypesAsync();

          Task<IReadOnlyList<ProductBrand>>  GetProductBrandsAsync();
    }
}