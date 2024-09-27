using Microsoft.AspNetCore.Mvc;
namespace FirstCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}