using CalicotGaming.Web.Models;

public static class Helpers
{
    public static void SeedDbContext(CalicotGamingDbContext dbContext)
    {
        dbContext.Products.Add(new Product{ Id = 1, Name = "Xbox One S", Description = "a powerful, 4k gaming console from Microsoft", Price = 499.99m, PhotoUrl = "https://m.media-amazon.com/images/I/619Bmcg-EIL._AC_UF1000,1000_QL80_.jpg" });
        dbContext.Products.Add(new Product{ Id = 2, Name = "PlayStation 5", Description = "a powerful, 4k gaming console from Sony, Microsoft's rival in the gaming world", Price = 399.99m, PhotoUrl = "https://cdn.wccftech.com/wp-content/uploads/2022/11/playstation-5-ps5.jpg" });

        dbContext.SaveChanges();
    }
}