using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T?> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsyncWithSpec(ISpecification<T> spec);
        Task<TResult?> GetEntityWithSpec<TResult>(ISpecification<T, TResult> spec);
        Task<IReadOnlyList<TResult>> ListAsyncWithSpec<TResult>(ISpecification<T, TResult> spec);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Exists(int id);
        Task<bool> SaveAllAsync();
    }
}
