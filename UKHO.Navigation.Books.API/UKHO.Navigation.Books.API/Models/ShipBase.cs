namespace UKHO.Navigation.Books.API.Models;

public abstract class ShipBase
{
    public virtual string Name { get; set; } = string.Empty;

    public virtual int LengthInMeters { get; set; }
}
