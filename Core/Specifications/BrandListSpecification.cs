using Core.Entities;

namespace Core.Specifications
{
    public class BrandListSpecification : BaseSpecification<Product,string>
    {
        public BrandListSpecification()
        {
            AddSelect(p => p.Brand);
            ApplyDistinct();
        }
    }
}
