using Core.Entities;

namespace Core.Specification
{
    public class ProductWithTypesAndBrandsSpecification : BaseSpcification<Product>
    {
        public ProductWithTypesAndBrandsSpecification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }

         public ProductWithTypesAndBrandsSpecification(int id):base(x=>x.Id==id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}