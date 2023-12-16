using System.Windows;
using Friends.Components.FriendComponent;
using AppContext = Friends.BL.AppContext;

namespace Friends.Windows.MainWindow;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        Loaded += OnLoaded;
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        var context = new AppContext();
        var friends = await context.GetFriendsAsync();

        if (friends is null)
        {
            MessageBox.Show(
                caption: Application.Current.Resources["AppName"]?.ToString(),
                messageBoxText: "Friends not found...",
                button: MessageBoxButton.OK,
                icon: MessageBoxImage.Error);
        }
        else
        {
            foreach (var friend in friends)
            {
                Panel.Children.Add(new FriendComponent(friend));
            }
        }
    }
}