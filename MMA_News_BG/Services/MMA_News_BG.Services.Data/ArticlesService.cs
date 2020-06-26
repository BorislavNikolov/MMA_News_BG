namespace MMA_News_BG.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MMA_News_BG.Data.Common.Repositories;
    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class ArticlesService : IArticlesService
    {
        private readonly IDeletableEntityRepository<Article> articlesRepository;

        public ArticlesService(IDeletableEntityRepository<Article> articlesRepository)
        {
            this.articlesRepository = articlesRepository;
        }

        public async Task<int> CreateAsync(string title, string content, int categoryId, string userId)
        {
            var article = new Article
            {
                CategoryId = categoryId,
                Content = content,
                Title = title,
                UserId = userId,
                ImageUrl = "test image url",
            };

            await this.articlesRepository.AddAsync(article);
            await this.articlesRepository.SaveChangesAsync();
            return article.Id;
        }

        public IEnumerable<T> GetByCategoryId<T>(int categoryId, int? take = null, int skip = 0)
        {
            var query = this.articlesRepository.All()
                .OrderByDescending(x => x.CreatedOn)
                .Where(x => x.CategoryId == categoryId).Skip(skip);

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetById<T>(int id)
        {
            var post = this.articlesRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return post;
        }

        public int GetCountByCategoryId(int categoryId)
        {
            return this.articlesRepository.All().Count(x => x.CategoryId == categoryId);
        }
    }
}
