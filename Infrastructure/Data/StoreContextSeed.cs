using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.DeliveryMethod.Any())
        {
            var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");

            var products = JsonSerializer.Deserialize<List<Product>>(productsData);

            if (products == null) return;

            context.DeliveryMethod.AddRange(products);

            await context.SaveChangesAsync();
        }

        if (!context.DeliveryMethods.Any())
        {
            var DMData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/delivery.json");

            var Methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(DMData);

            if (Methods == null) return;

            context.DeliveryMethods.AddRange(Methods);

            await context.SaveChangesAsync();
        }
    }
}