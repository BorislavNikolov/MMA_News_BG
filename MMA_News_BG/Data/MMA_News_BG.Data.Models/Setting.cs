namespace MMA_News_BG.Data.Models
{
    using MMA_News_BG.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
