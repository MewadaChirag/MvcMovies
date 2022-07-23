using MvcMovies.Models;
using System.Collections.Generic;

namespace MvcMovies.Repositories
{
    public class BookRepository
    {
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Chirag", Description="This book is all about MVC. It covers all concepts."},
                new BookModel(){Id=2, Title="WebAPI", Author="Nitish", Description="This book is all about WebAPI. It covers all concepts."},
                new BookModel(){Id=3, Title="Angular", Author="Priynka", Description="This book is all about Angular. It covers all concepts."},
                new BookModel(){Id=4, Title="CSS", Author="Nargis", Description="This book is all about CSS. It covers all concepts."}
            };
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().FindAll(x => x.Title.Contains(title) || x.Author.Contains(authorname));
        }
    }
}
