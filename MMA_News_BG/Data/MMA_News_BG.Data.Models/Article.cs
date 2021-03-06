﻿namespace MMA_News_BG.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MMA_News_BG.Data.Common.Models;

    public class Article : BaseDeletableModel<int>
    {
        public Article()
        {
            this.Comments = new HashSet<Comment>();
            this.Votes = new HashSet<Vote>();
        }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
