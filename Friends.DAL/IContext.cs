using Friends.DAL.Models;

namespace Friends.DAL;

public interface IContext<T> where T : Friend
{
    IEnumerable<T>? Friends { get; set; }
    Task LoadAsync();
}