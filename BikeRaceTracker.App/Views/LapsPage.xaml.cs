using BikeRaceTracker.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace BikeRaceTracker.App.Views;

public sealed partial class LapsPage : Page
{
    public LapsViewModel ViewModel
    {
        get;
    }

    public LapsPage()
    {
        ViewModel = App.GetService<LapsViewModel>();
        InitializeComponent();
    }
}
