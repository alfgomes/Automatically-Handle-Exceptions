using System.Collections.Generic;
using System.Linq;
using ActionFilters.Application.Exceptions;
using ActionFilters.Domain.Entities;

namespace ActionFilters.Application.Features
{
    public interface IBookService
    {
        Book GetById(int id);
        IList<Book> List();
    }

    public class BookService : IBookService
    {
        private IEnumerable<Book> _books = new List<Book>
        {
            new Book()
            {
                Id = 1,
                EAN = 7894455142565,
                Name = "Pai Rico e Pai Pobre",
                CostPrice = 9.99M,
                RetailPrice = 19.99M
            },
            new Book()
            {
                Id = 2,
                EAN = 78944598753461,
                Name = "O Senhor dos Anéis",
                CostPrice = 15.99M,
                RetailPrice = 29.99M
            },
        };

        public IList<Book> List()
        {
            return _books.ToList();
        }

        public Book GetById(int id)
        {
            var book = _books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                throw new EntityNotFoundException(nameof(Book), id);

            return book;
        }
    }
}