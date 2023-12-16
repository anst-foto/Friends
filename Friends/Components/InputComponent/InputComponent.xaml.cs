using System.Windows.Controls;

namespace Friends.Components.InputComponent;

public partial class InputComponent : UserControl
{
    public InputComponent(string labelName, string inputText, bool isEnabled)
    {
        InitializeComponent();

        DataContext = this;

        Label.Content = labelName;

        Input.Text = inputText;
        Input.IsEnabled = isEnabled;
    }
}