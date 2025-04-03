using Microsoft.AspNetCore.Mvc;

namespace ProjectMVCProjectMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
