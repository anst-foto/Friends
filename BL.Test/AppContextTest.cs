using Friends.BL.Models;
using AppContext = Friends.BL.AppContext;

namespace BL.Test;

public class AppContextTest
{
    [Fact]
    public async Task GetFriendsAsyncTest()
    {
        var expected = new Friend()
        {
            Id = 1,
            Name = "Leanne Graham",
            Username = "Bret",
            Email = "Sincere@april.biz",
            Address = new Address()
            {
                Street = "Kulas Light",
                Suite = "Apt. 556",
                City = "Gwenborough",
                Zipcode = "92998-3874",
                Geo = new Geo()
                {
                    Lat = "-37.3159",
                    Lng = "81.1496"
                }
            },
            Phone = "1-770-736-8031 x56442",
            Website = "hildegard.org",
            Company = new Company()
            {
                Name = "Romaguera-Crona",
                CatchPhrase = "Multi-layered client-server neural-net",
                Bs = "harness real-time e-markets"
            }
        };

        var context = new AppContext();
        var friends = await context.GetFriendsAsync();
        Assert.NotNull(friends);
        var collection = friends.ToList();
        Assert.NotEmpty(collection);

        var actual = collection.FirstOrDefault(f => f.Id == 1);
        Assert.NotNull(actual);
        
        Assert.Equal(expected, actual);
    }
}