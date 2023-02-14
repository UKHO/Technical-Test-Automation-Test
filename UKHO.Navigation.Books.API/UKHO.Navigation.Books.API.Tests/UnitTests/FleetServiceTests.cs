using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Tests.UnitTests;

public class FleetServiceTests
{
    //Test ValidateFleet_WhenValidCollectionOfShips_ThenFleetIsNotNull


    private List<IShip> GetValidCollectionOfShips()
    {
        return new List<IShip>
        {
            new BattleShip
            {
                Name = "TestBattleShip",
                LengthInMeters = 100,
                NumberOfGuns = 30

            },
            new CruiseShip()
            {
                Name = "TestCruiseShip",
                LengthInMeters = 200,
            }
        };
    }
}
