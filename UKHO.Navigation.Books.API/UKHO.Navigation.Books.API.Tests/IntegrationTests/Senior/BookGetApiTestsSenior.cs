using System.Net;
using System.Text.Json;
using FluentAssertions;
using RestSharp;
using UKHO.Navigation.Books.API.Models;


namespace UKHO.Navigation.Books.API.Tests.IntegrationTests.Senior;

public class BookGetApiTestsSenior
{
    private readonly HttpClient _httpClient;
    private readonly RestClient _restClient;

    public BookGetApiTestsSenior()
    {
        var factory = new ApiWebApplicationFactory();
        
        _httpClient = factory.CreateClient();
        
        var options = new RestClientOptions(_httpClient.BaseAddress!)
        {
            ConfigureMessageHandler = _ => factory.Server.CreateHandler()
        };
        _restClient = new RestClient(options);
    }
    
    // Instructions:
    // 1. Add a test framework of your choice.
    // 2. Add a test to verify that the below book with id "d0bf11de-b97b-4fcb-b84d-e0ff18119e08" has the title "Los Angeles and Long Beach Harbors" using the books/{id} endpoint 
    // Note: The above HttpClient and RestClient are configured with the api base address, please use the client you are most conformable with. 
 
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