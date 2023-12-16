using System.Text.Json.Serialization;

namespace Friends.DAL.Models;

public record Address
{
    [JsonPropertyName("street")]
    public string Street { get; set; }

    [JsonPropertyName("suite")]
    public string Suite { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("zipcode")]
    public string Zipcode { get; set; }

    [JsonPropertyName("geo")]
    public Geo Geo { get; set; }
}