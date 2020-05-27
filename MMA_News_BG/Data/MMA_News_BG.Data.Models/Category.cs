namespace MMA_News_BG.Data.Models
{
    using System.Collections.Generic;

    using MMA_News_BG.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
        }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
