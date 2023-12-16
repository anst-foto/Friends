using System.Windows;
using Friends.BL.Models;
using Friends.Components.InputComponent;

namespace Friends.Windows.FriendWindow;

public partial class FriendWindow : Window
{
    private readonly Friend _friend;
    public FriendWindow(Friend friend)
    {
        _friend = friend;
        
        InitializeComponent();
        
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        var nameInputComponent = new InputComponent(
            labelName: "Name",
            inputText: _friend.Name,
            isEnabled: false)
        {
            Width = 300
        };
        var phoneInputComponent = new InputComponent(
            labelName: "Phone",
            inputText: _friend.Phone,
            isEnabled: false)
        {
            Width = 300
        };

        Panel.Children.Add(nameInputComponent);
        Panel.Children.Add(phoneInputComponent);
    }
}