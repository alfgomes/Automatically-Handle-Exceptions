using ActionFilters.Application.Features;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _books;

        public BooksController(IBookService books)
        {
            _books = books;
        }

        [HttpGet()]
        public IActionResult List()
        {
            var books = _books.List();

            return Ok(books);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _books.GetById(id);

            if (book == null) return NotFound();
            
            return Ok(book);
        }
    }
}