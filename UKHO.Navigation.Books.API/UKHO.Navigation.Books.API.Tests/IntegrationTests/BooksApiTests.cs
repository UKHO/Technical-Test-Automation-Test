using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using NUnit.Framework;
using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Tests.IntegrationTests;

internal class BooksApiTests
{
    private readonly HttpClient _client;

    public BooksApiTests()
    {
        var factory = new APIWebApplicationFactory();
        _client = factory.CreateClient();
    }

    public async Task CreateBook_WhenRequestIsValid_ReturnsHttpStatusCreated()
    {
        var book = new Book
        {
            Id = "eec7c4e8-eb2f-43f4-8b83-2729f27eccf1",
            Title = "Test Book Title",
            Author = "Test Author",
            ShortDescription = "This is a short test description",
            PageCount = 419,
            ReleaseDate = DateTime.Now,
        };

        var json = JsonSerializer.Serialize(book);

        var response = await _client.PostAsync("/Books", 
            new StringContent(json, Encoding.UTF8, "application/json"));

        response.StatusCode.Should().Be(HttpStatusCode.Created);
    }
}