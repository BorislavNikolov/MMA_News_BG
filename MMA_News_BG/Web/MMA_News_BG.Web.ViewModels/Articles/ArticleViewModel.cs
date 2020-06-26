namespace MMA_News_BG.Web.ViewModels.Articles
{
    using System;

    using Ganss.XSS;

    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class ArticleViewModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }
    }
}
