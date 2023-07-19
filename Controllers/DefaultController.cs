using BookShelf.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Books>()
            
            {
                new Books(){Id=1,Title="Satranç" ,Author="Zweig"},
                new Books(){Id=2,Title="Dr Ox'un Deneyi" , Author="Jules Verne"},
                new Books(){Id=3,Title ="DeliFişek" ,Author="Vasconceulos" },
                new Books(){Id=4,Title="Kırmızı Bisiklet" , Author="Muzaffer İzgü"},
                new Books(){Id=5,Title = "Toros Canavarı",Author="Aziz Nesin"}
            };
            return View(books);
        }
    }
}
