﻿using System.Text.Json;
using Friends.DAL.Models;

namespace Friends.DAL;

public class WebServiceContext : IContext<Friend>
{
    private const string URL = "https://jsonplaceholder.typicode.com/users";
    public IEnumerable<Friend>? Friends { get; set; }

    public async Task LoadAsync()
    {
        using var http = new HttpClient();
        await using var response = await http.GetStreamAsync(URL);
        Friends = await JsonSerializer.DeserializeAsync<IEnumerable<Friend>>(response);
    }
}