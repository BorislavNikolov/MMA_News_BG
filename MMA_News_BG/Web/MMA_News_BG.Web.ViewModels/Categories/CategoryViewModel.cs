namespace MMA_News_BG.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

        public IEnumerable<ArticlesInCategoryViewModel> ArticlePosts { get; set; }
    }
}
