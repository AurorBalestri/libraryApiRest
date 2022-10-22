using libraryApiRest.Models;
using libraryApiRest.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace libraryApiRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost()]
        public IActionResult CreateAnimal([FromBody] BookClientModel clientBook)
        {
            var bookToAdd = _bookService.Add(clientBook);
            return Created("", bookToAdd);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveBook(int id)
        {
            var bookToRemove = _bookService.Delete(id);
            if(bookToRemove == null)
            {
                return NoContent();
            } else
            {
                return Ok(bookToRemove);
            }
        }

        [HttpGet()]
        public IActionResult GetAllBooks()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }
    }
}
