using BikeRaceTracker.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace BikeRaceTracker.App.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
