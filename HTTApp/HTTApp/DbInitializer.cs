using HTTApp.Models;

namespace HTTApp;

public class DbInitializer
{
    /// <summary>
    /// Initial filling of the BD data.
    /// </summary>
    public void Initialize(HTTDbContext dbContext)
    {
        if (dbContext.Categories.Any()) return;

        // Add categories
        for (var i = 1; i < 4; i++)
        {
            var category = $"Category {i}";
            dbContext.Categories.Add(new Category { Name = category });
        }

        dbContext.SaveChanges();

        var categories = dbContext.Categories.ToList();
        var random = new Random();
        
        // Add products
        for (var i = 1; i <= 20; i++)
        {
            var productName = $"Product {i}";
            var category = categories[random.Next(1, 3)];
            dbContext.Products.Add(new Product { Name = productName, Price = random.Next(0, 1999), Category = category});
        }
        dbContext.SaveChanges();
    }
}