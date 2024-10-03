using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.Reflection;
using System.Text.Json;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context, UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any(x => x.UserName == "admin@test.com"))
        {
            var user = new AppUser
            {
                UserName = "admin@test.com",
                Email = "admin@test.com",
            };

            await userManager.CreateAsync(user, "Password1#");
            await userManager.AddToRoleAsync(user, "Admin");
        }

        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        if (!context.Products.Any())
        {
            var productsData = await File.ReadAllTextAsync(path + @"/Data/SeedData/products.json");

            var products = JsonSerializer.Deserialize<List<Product>>(productsData);

            if (products == null) return;

            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }

        if (!context.DeliveryMethods.Any())
        {
            var DMData = await File.ReadAllTextAsync(path + @"/Data/SeedData/delivery.json");

            var Methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(DMData);

            if (Methods == null) return;

            context.DeliveryMethods.AddRange(Methods);

            await context.SaveChangesAsync();
        }
    }
}