using System.Windows;
using Friends.Components.FriendComponent;
using AppContext = Friends.BL.AppContext;

namespace Friends.Windows.MainWindow;

public partial class MainWindow : Window
{
    private readonly AppContext _context;
    
    public MainWindow()
    {
        _context = new AppContext();
        
        InitializeComponent();
        
        Loaded += OnLoaded;
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        var friends = await _context.GetFriendsAsync();

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