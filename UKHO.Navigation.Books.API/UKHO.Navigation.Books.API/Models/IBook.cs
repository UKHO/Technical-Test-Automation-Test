namespace UKHO.Navigation.Books.API.Models;

public interface IBook
{
    string Isbn { get; set; }

    string Title { get; set; }

    string Author { get; set; }

    string ShortDescription { get; set; }

    int PageCount { get; set; }

    DateTime ReleaseDate { get; set; }
}