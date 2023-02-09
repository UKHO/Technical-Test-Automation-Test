using FluentValidation;
using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(book => book.Isbn)
            .Must(BeAGuid)
            .WithErrorCode("Isbn must be a guid");

        RuleFor(book => book.Title).NotEmpty();
        RuleFor(book => book.ShortDescription).NotEmpty();
        RuleFor(book => book.PageCount).GreaterThan(0);
        RuleFor(book => book.Author).NotEmpty();
    }

    private bool BeAGuid(string isbn)
    {
        return Guid.TryParse(isbn, out _);
    }
}