namespace MMA_News_BG.Web.ViewModels.Categories
{
    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class CategoryDropDownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
