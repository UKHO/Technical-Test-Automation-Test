using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using UKHO.Navigation.Books.API.Models;
using UKHO.Navigation.Books.API.Services;

namespace UKHO.Navigation.Books.API.Controllers;
[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly IValidator<Book> _validator;

    private const string CreationErrorMessage = "A book with his TraceId already exists";

    public BooksController(IBookService bookService, IValidator<Book> validator)
    {
        _bookService = bookService;
        _validator = validator;
    }

    [HttpGet(Name = "GetAll")]
    public async Task<IActionResult> GetBooksAsync()
    {
        //if (searchTerm is not null && !string.IsNullOrWhiteSpace(searchTerm))
        //{
        //    var matchedBooks = await bookService.SearchByTitleAsync(searchTerm);
        //    return Results.Ok(matchedBooks);
        //}

        var books = await _bookService.GetAllAsync();
        return Ok(books);
    }

    [HttpGet("{isbn}")]
    public async Task<IActionResult> GetBookAsync(string isbn)
    {
        var book = await _bookService.GetByTraceIdAsync(isbn);
        return book is not null ? Ok(book) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> CreateBookAsync(Book book)
    {
        var validationResult = await _validator.ValidateAsync(book);

        if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

        var created = await _bookService.CreateAsync(book);

        if (!created)
            return BadRequest(new List<ValidationFailure>
            {
                new(nameof(book.Isbn), CreationErrorMessage)
            });
        
        return Created(nameof(GetBookAsync), book);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteBookAsync(string traceId)
    {
        var deleted = await _bookService.DeleteAsync(traceId);
        return deleted ? NoContent() : NotFound();
    }
}
