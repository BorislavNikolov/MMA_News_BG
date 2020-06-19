namespace MMA_News_BG.Web.ViewModels.Categories
{
    using System;
    using System.Net;
    using System.Text.RegularExpressions;

    public class ArticlesInCategoryViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ShortContent
        {
            get
            {
                var content = WebUtility.HtmlDecode(Regex.Replace(this.Content, @"<[^>]+>", string.Empty));
                return content.Length > 300
                        ? content.Substring(0, 300) + "..."
                        : content;
            }
        }

        public string UserUserName { get; set; }
    }
}
