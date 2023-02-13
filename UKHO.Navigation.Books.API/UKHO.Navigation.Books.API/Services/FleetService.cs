using UKHO.Navigation.Books.API.Models;
using UKHO.Navigation.Books.API.Validators;

namespace UKHO.Navigation.Books.API.Services;

public class FleetService
{
    private readonly IFleetValidator _validator;

    public FleetService(IFleetValidator validator)
    {
        _validator = validator;
    }

    public async Task<Fleet> ValidateFleetAsync(IEnumerable<IShip> ships)
    {
        var fleet = new Fleet
        {
            Ships = ships.ToArray()
        };

        var validationResult = await _validator.ValidateAsync(fleet);

        if (!validationResult)
        {
            throw new InvalidOperationException("Fleet is not valid");
        }

        return fleet;
    }
}
