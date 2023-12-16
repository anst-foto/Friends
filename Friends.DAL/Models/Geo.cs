using System.Text.Json.Serialization;

namespace Friends.DAL.Models;

public class Geo
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    [JsonPropertyName("lng")]
    public string Lng { get; set; }
}