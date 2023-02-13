using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace UKHO.Navigation.Books.API.Models;

public class Fleet
{
    public IShip[] Ships { get; set; } = null!;
}
