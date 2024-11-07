using RestSharp;

namespace UKHO.Navigation.Books.API.Tests.IntegrationTests.Junior;

public class BookGetApiTestsJunior
{
    private readonly HttpClient _httpClient;
    private readonly RestClient _restClient;

    public BookGetApiTestsJunior()
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
    // 2. Add a test to verify that the books/get-all endpoint returns a 200 OK response
    // Note: The above HttpClient and RestClient are configured with the api base address please use the client you are most conformable with. 
 }