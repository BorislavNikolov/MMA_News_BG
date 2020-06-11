namespace MMA_News_BG.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MMA_News_BG.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category
                {
                    Name = "Любопитно",
                },
                new Category
                {
                    Name = "UFC",
                },
                new Category
                {
                    Name = "Bellator",
                },
                new Category
                {
                    Name = "Прогнози",
                },
            };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(category);
            }
        }
    }
}
