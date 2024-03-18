using System.Text.Json;
using FluentAssertions;
using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Tests.IntegrationTests;

public class BookGetApiTests
{
    private readonly HttpClient _client;

    public BookGetApiTests()
    {
        var factory = new ApiWebApplicationFactory();
        _client = factory.CreateClient();
    }
    
    // Instructions:
    // 1. Add a test framework of your choice.
    // 2. Add an additional test to verify that the below book exists using the books/{id} or books/get-all endpoint.
 
    // var expectedBook = new Book
    // {
    //     Id = "d0bf11de-b97b-4fcb-b84d-e0ff18119e08",
    //     Title = "Los Angeles and Long Beach Harbors",
    //     Author = "US Navy",
    //     ShortDescription = "Advice for safe docking in the Los Angeles harbours",
    //     PageCount = 500,
    //     ReleaseDate = new DateTime(2019, 04, 13),
    // };

}