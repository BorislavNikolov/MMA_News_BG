namespace MMA_News_BG.Web.ViewModels.Categories
{
    using System;
    using System.Net;
    using System.Text.RegularExpressions;

    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class ArticlesInCategoryViewModel : IMapFrom<Article>
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
