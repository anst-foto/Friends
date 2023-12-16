using System.Net.Http.Json;
using Friends.DAL.Models;

namespace Friends.DAL;

public class WebServiceContext
{
    private const string URL = "https://jsonplaceholder.typicode.com/users";
    public IEnumerable<Friend>? Friends { get; private set; }

    public async Task LoadAsync()
    {
        using var http = new HttpClient();
        var data = await http.GetFromJsonAsync(URL, Friends.GetType());
        Friends = data as IEnumerable<Friend>;
    }
}