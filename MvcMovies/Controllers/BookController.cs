using Microsoft.AspNetCore.Mvc;
using MvcMovies.Models;
using MvcMovies.Repositories;

namespace MvcMovies.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository;
        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            List<BookModel> booksdata = _bookrepository.GetAllBooks();
            return View(booksdata);
        }
        public ViewResult GetBookById(int id)
        {
            BookModel bookdata = _bookrepository.GetBookById(id);
            return View(bookdata);
        }
        public ViewResult SearchBook(string title, string authorname)
        {
            List<BookModel> booksdata = _bookrepository.SearchBook(title, authorname);
            return View(booksdata);
                
        }
    }
}
