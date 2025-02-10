using System.Net;
using System.Text.Json;
using FluentAssertions;
using RestSharp;
using System.Net.Http.Json;
using UKHO.Navigation.Books.API.Models;
using Newtonsoft.Json;
using NUnit.Framework;


namespace UKHO.Navigation.Books.API.Tests.IntegrationTests.Senior;

public class BookGetApiTestsReview
{
    private readonly HttpClient _httpClient;

    public BookGetApiTestsReview()
    {
        var factory = new ApiWebApplicationFactory();
        _httpClient = factory.CreateClient();
    }

    [Test]
    public async Task AddBook()
    {
        Book book = new Book()
        {
            Author = "Auto test",
            Title = "Auto test title",
            Id = "e898702e-7789-498c-a409-23e32c1379c2",
            PageCount = 100,
            ReleaseDate = new DateTime(2021, 10, 10),
            ShortDescription = "Auto test short description"
        };
        var response = await _httpClient.PostAsJsonAsync<Book>("books", book);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }

    [Test]
    public async Task AddAnotherBook()
    {
        Book book = new Book()
        {
            Author = "Auto test 2",
            Title = "Auto test title 2",
            Id = "32fcf065-aa7d-4080-af4e-7b156cc8c509",
            PageCount = 100,
            ReleaseDate = new DateTime(2021, 10, 10),
            ShortDescription = "Auto test short description"
        };
        var response = await _httpClient.PostAsJsonAsync<Book>("books", book);
        Assert.That(response.StatusCode, Is.LessThan(299));
    }

    [Test]
    public async Task BookContainsCorrectName()
    {
        var response = await _httpClient.GetAsync("books/e898702e-7789-498c-a409-23e32c1379c2");
        var jsonString = await response.Content.ReadAsStringAsync();
        jsonString.Contains("Auto test");
     }
    
    [Test]
    public async Task CheckRetrievingAllBooksWorks()
    {
        var response = await _httpClient.GetAsync("books/get-all");
        var jsonString = await response.Content.ReadAsStringAsync();
        Assert.That(jsonString.Contains("Auto test"));
        Assert.That(jsonString.Contains("Auto test 2"));
    } 


  
}