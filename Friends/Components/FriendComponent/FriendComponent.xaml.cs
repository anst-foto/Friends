using System.Windows.Controls;
using Friends.BL.Models;
using Friends.Windows.FriendWindow;

namespace Friends.Components.FriendComponent;

public partial class FriendComponent : UserControl
{
    public FriendComponent(Friend friend)
    {
        InitializeComponent();
        DataContext = this;

        LinkUserName.Click += (sender, args) =>
        {
            new FriendWindow().Show();
        }; 
        UserName.Text = friend.Username;

        var nameInputComponent = new InputComponent.InputComponent(
            labelName: "Name",
            inputText: friend.Name,
            isEnabled: false)
        {
            Width = 300
        };
        var companyInputComponent = new InputComponent.InputComponent(
            labelName: "Company",
            inputText: friend.Company.Name,
            isEnabled: false)
        {
            Width = 300
        };

        Panel.Children.Add(nameInputComponent);
        Panel.Children.Add(companyInputComponent);
    }
}