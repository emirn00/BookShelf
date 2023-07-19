using BookShelf.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books>()
            {
                new Books() { Id = 6, Title = "Korku", Author = "Zweig", },
                new Books() { Id = 7, Title ="Anna Karanina" , Author="Tolstoy"}
            };

            return View(bookList);
        }
    }
}

