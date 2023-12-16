using Friends.DAL;
using Friends.DAL.Models;

namespace DAL.Test;

public class WebServiceContextTest
{
    [Fact]
    public async Task LoadAsyncTest()
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

        var service = new WebServiceContext();
        await service.LoadAsync();
        
        Assert.NotNull(service.Friends);
        Assert.NotEmpty(service.Friends);
        
        var actual = service.Friends?.FirstOrDefault(f => f.Id == 1);
        Assert.NotNull(actual);
        
        Assert.Equal(expected, actual);
    }
}