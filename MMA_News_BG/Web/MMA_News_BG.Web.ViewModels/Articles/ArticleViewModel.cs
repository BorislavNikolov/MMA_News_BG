namespace MMA_News_BG.Web.ViewModels.Articles
{
    using System;

    using Ganss.XSS;

    public class ArticleViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }
    }
}
