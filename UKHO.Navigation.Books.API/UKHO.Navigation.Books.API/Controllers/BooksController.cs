using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using UKHO.Navigation.Books.API.Models;
using UKHO.Navigation.Books.API.Services;

namespace UKHO.Navigation.Books.API.Controllers;
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly IValidator<Book> _validator;

    private const string CreationErrorMessage = "A book with his ID already exists";

    public BooksController(IBookService bookService, IValidator<Book> validator)
    {
        _bookService = bookService;
        _validator = validator;
    }

    [HttpGet]
    [Route("/books/get-all")]
    public async Task<IActionResult> GetBooksAsync()
    {
        var books = await _bookService.GetAllAsync();
        
        return Ok(books);
    }

    [HttpGet]
    [Route("/books/{id}")]
    public async Task<IActionResult> GetBookAsync(string id)
    {
        var book = await _bookService.GetByIdAsync(id);
        
        return book is not null ? Ok(book) : NotFound();
    }

    [HttpPost]
    [Route("/books")]
    public async Task<IActionResult> CreateBookAsync(Book book)
    {
        var validationResult = await _validator.ValidateAsync(book);

        if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

        var created = await _bookService.CreateAsync(book);

        if (!created)
            return BadRequest(new List<ValidationFailure>
            {
                new(nameof(book.Id), CreationErrorMessage)
            });
        
        return Created(nameof(GetBookAsync), book);
    }

    [HttpDelete]
    [Route("/books/{id}")]
    public async Task<IActionResult> DeleteBookAsync(string id)
    {
        var deleted = await _bookService.DeleteAsync(id);
        
        return deleted ? NoContent() : NotFound();
    }
}
