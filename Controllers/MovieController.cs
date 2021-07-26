using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        
        public IActionResult Create(){
            return View();
        }
        public IActionResult Detail(){
            return View();
        }
        public IActionResult List(){
            return View();
        }

    }
}