namespace MMA_News_BG.Web.ViewModels.Articles
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;
    using MMA_News_BG.Web.ViewModels.Categories;

    public class ArticleCreateInputModel : IMapTo<Article>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
