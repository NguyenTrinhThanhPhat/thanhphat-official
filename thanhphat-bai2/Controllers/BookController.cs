using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using thanhphat_bai2.Models;

namespace thanhphat_bai2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTMLS & CSS3 The complete Manual - Author Name Book 1");
            books.Add("HTMLS & CSS3 Responsive web Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC5 - Author Name Book 2");
            ViewBag.Books = books;
            return View(books);
        }
        public IActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "author01", "HTMLS & CSS3 The complete Manual - Author Name Book 1", "/images/image01.jpg"));
            books.Add(new Book(2, "author02", "HTMLS & CSS3 Responsive web Design cookbook - Author Name Book 2", "/images/image02.jpg"));
            books.Add(new Book(3, "author03", "Professional ASP.NET MVC5 - Author Name Book 2", "/images/image03.jpg"));
            ViewBag.Books = books;
            return View(books);
        }
    }
}
