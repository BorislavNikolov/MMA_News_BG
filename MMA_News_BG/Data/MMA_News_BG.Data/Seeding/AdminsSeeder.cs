namespace MMA_News_BG.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Configuration;

    using MMA_News_BG.Data.Models;

    public class AdminsSeeder
    {
        private readonly IConfiguration configuration;

        public AdminsSeeder(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            var admin = new ApplicationUser
            {
                UserName = this.configuration["Admin Info:Username"],
                PasswordHash = this.configuration["Admin Info:Password"],
            };

            await dbContext.Users.AddAsync(admin);
        }
    }
}
