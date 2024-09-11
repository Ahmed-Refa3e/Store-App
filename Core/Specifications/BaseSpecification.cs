using Core.Interfaces;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T>(Expression<Func<T, bool>> criteria) : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria => criteria;
    }
}
