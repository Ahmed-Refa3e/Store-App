using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Services
{
    public class CartService : ICartService
    {
        public Task<bool> DeleteCartAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart?> GetCartAsync(string key)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart?> SetCartAsync(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }
    }
}
