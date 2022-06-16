using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheCafeRio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        // GET: DashboardController
        public ActionResult Index()
        {
            return View();
        }
    }
}
