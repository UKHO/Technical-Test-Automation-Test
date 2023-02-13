using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public class FleetValidator : IFleetValidator
{
    public Task<bool> ValidateAsync(Fleet? fleet)
    {
        if (fleet == null) return Task.FromResult(false);

        if (!fleet.Ships.Any()) return Task.FromResult(false);

        if(fleet.Ships.Any(x => string.IsNullOrWhiteSpace(x.Name))) return Task.FromResult(false);

        if (fleet.Ships.Any(x => x.LengthInMeters < 10)) return Task.FromResult(false);

        return Task.FromResult(true);

    }
}
