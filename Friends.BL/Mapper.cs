using Friends.BL.Models;

namespace Friends.BL;

public static class Mapper
{
    public static Friends.BL.Models.Friend MapFriendDalToFriendBl(Friends.DAL.Models.Friend friend)
    {
        return new Friends.BL.Models.Friend()
        {
            Id = friend.Id,
            Name = friend.Name,
            Username = friend.Username,
            Email = friend.Email,
            Address = new Address()
            {
                Street = friend.Address.Street,
                Suite = friend.Address.Suite,
                City = friend.Address.City,
                Zipcode = friend.Address.Zipcode,
                Geo = new Geo()
                {
                    Lat = friend.Address.Geo.Lat,
                    Lng = friend.Address.Geo.Lng
                }
            },
            Phone = friend.Phone,
            Website = friend.Website,
            Company = new Company()
            {
                Name = friend.Company.Name,
                CatchPhrase = friend.Company.CatchPhrase,
                Bs = friend.Company.Bs
            }
        };
    }
}