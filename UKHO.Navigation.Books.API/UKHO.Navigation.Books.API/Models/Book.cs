using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace UKHO.Navigation.Books.API.Models;

public class Book : IBook
{
    [JsonProperty("isbn")]
    [JsonPropertyName("isbn")]
    public string Isbn { get; set; } = default!;

    [JsonProperty("title")]
    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;

    [JsonProperty("author")]
    [JsonPropertyName("author")]
    public string Author { get; set; } = default!;

    [JsonProperty("shortDescription")]
    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = default!;

    [JsonProperty("pageCount")]
    [JsonPropertyName("pageCount")]
    public int PageCount { get; set; }

    [JsonProperty("releaseDate")]
    [JsonPropertyName("releaseDate")]
    public DateTime ReleaseDate { get; set; }
}