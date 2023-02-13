using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public class FleetValidator : IFleetValidator
{
    public bool Validate(Fleet? fleet)
    {
        if(fleet == null)
            return false;

        return fleet.Battleships.Any() && fleet.CruiseShips.Any();
    }
}
