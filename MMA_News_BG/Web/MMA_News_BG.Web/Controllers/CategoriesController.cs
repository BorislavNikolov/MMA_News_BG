namespace MMA_News_BG.Web.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using MMA_News_BG.Services.Data;

    public class CategoriesController
    {
        private const int ItemsPerPage = 5;

        private readonly ICategoriesService categoriesService;
        private readonly IArticlesService articlesService;
        private readonly IHttpContextAccessor http;

        public CategoriesController(
            ICategoriesService categoriesService,
            IArticlesService articlesService,
            IHttpContextAccessor http)
        {
            this.categoriesService = categoriesService;
            this.articlesService = articlesService;
            this.http = http;
        }

        //public IActionResult ByName(string name, int page = 1)
        //{
        //    var viewModel =
        //        this.categoriesService.GetByName<CategoryViewModel>(name);
        //    if (viewModel == null)
        //    {
        //        return this.NotFound();
        //    }

        //    viewModel.ForumPosts = this.articlesService.GetByCategoryId<PostInCategoryViewModel>(viewModel.Id, ItemsPerPage, (page - 1) * ItemsPerPage);

        //    var count = this.articlesService.GetCountByCategoryId(viewModel.Id);
        //    viewModel.PagesCount = (int)Math.Ceiling((double)count / ItemsPerPage);
        //    if (viewModel.PagesCount == 0)
        //    {
        //        viewModel.PagesCount = 1;
        //    }

        //    viewModel.CurrentPage = page;

        //    return this.View(viewModel);
        //}
    }
}
