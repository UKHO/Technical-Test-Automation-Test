using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace UKHO.Navigation.Books.API.Models;

public class Fleet
{
    [JsonProperty("battleships")]
    [JsonPropertyName("id")]
    public BattleShip[] Battleships { get; set; } = null!;
    public CruiseShip[] CruiseShips { get; set; } = null!;
}
