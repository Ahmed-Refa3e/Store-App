using Core.Entities;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class ProductSpecification : BaseSpecification<Product>
    {
        public ProductSpecification(string? brand,string? type,string? sort) : base(x =>
            (string.IsNullOrEmpty(brand) || x.Brand == brand) &&
            (string.IsNullOrEmpty(type) || x.Type == type)
        )
        {
            switch(sort)
            {
                case "priceAsc":
                    AddOrderBy(p => p.Price);
                    break;
                case "priceDesc":
                    AddOrderByDescending(p => p.Price);
                    break;
                default:
                    AddOrderBy(p => p.Name);
                    break;
            }
        }
    }
}
