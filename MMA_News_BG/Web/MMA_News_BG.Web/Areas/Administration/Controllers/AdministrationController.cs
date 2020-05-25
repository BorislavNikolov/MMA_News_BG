namespace MMA_News_BG.Web.Areas.Administration.Controllers
{
    using MMA_News_BG.Common;
    using MMA_News_BG.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
