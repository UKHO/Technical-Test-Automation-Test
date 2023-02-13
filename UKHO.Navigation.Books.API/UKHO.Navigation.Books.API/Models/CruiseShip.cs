namespace UKHO.Navigation.Books.API.Models;

public class CruiseShip : ShipBase
{
    public int NumberOfEmergencyRIBs { get; set; }

    public string[] Features { get; set; }
}
