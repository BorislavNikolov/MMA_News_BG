namespace MMA_News_BG.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using Ganss.XSS;

    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class ArticleViewModel : IMapFrom<Article>, IMapTo<Article>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }

        public int VotesCount { get; set; }

        public IEnumerable<ArticleCommentViewModel> Comments { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Article, ArticleViewModel>()
                .ForMember(x => x.VotesCount, options =>
                {
                    options.MapFrom(a => a.Votes.Sum(v => (int)v.Type));
                });
        }
    }
}
