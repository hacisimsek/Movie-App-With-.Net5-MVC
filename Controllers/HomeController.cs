using System.Linq;
using dotnet.Data;
using dotnet.Models;
using Microsoft.AspNetCore.Mvc;


namespace dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            // ProductCategoryModel model = new ProductCategoryModel();
            // model.Categories = CategoryRepository.Categories;
            // model.Movies = MovieRepository.Movies;

            var movies = MovieRepository.Movies;

            if(id != null)
            {
                movies = movies.Where(i=>i.CategoryId == id).ToList();
            }


            return View(movies);
        }
        public IActionResult Details(int id)
        {
            // ProductCategoryModel model = new ProductCategoryModel();
            // model.Categories = CategoryRepository.Categories;
            // model.Movie= MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
