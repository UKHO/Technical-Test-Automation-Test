using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public interface IFleetValidator
{
    public Task<bool> ValidateAsync(Fleet? fleet);
}
