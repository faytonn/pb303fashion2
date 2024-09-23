using Microsoft.AspNetCore.Mvc;

namespace PB303Fashion.Areas.AdminPanel.Controllers
{
    public class DashboardController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
