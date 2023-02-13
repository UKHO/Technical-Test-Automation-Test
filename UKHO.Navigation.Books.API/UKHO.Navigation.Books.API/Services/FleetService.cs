using Newtonsoft.Json;
using UKHO.Navigation.Books.API.Models;
using UKHO.Navigation.Books.API.Validators;

namespace UKHO.Navigation.Books.API.Services;

public class FleetService
{
    private readonly IFleetValidator _validator;
    private const string BaseUrl = "https://lemon-pond-0c20b7303.1.azurestaticapps.net/";
    private const string ShipsEndPoint = "ships.json";

    public FleetService(IFleetValidator validator)
    {
        _validator = validator;
    }

    public async Task<Fleet> GetFleet()
    {
        using var client = new HttpClient();

        client.BaseAddress = new Uri(BaseUrl);

        var response = await client.GetAsync(ShipsEndPoint);

        var json = await response.Content.ReadAsStringAsync();

        var jsonResult = JsonConvert.DeserializeObject<Fleet>(json);

        var validationResult = _validator.Validate(jsonResult);

        if (!validationResult)
        {
            throw new InvalidOperationException("Fleet is not valid");
        }

        return jsonResult!;
    }
}
