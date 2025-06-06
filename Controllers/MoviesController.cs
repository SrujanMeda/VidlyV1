using System.Web.Mvc;
using VidlyV1.Models;

namespace VidlyV1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

    }
}