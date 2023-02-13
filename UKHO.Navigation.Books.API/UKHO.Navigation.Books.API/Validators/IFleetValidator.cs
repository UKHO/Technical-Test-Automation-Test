using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public interface IFleetValidator
{
    public bool Validate(Fleet? fleet);
}
