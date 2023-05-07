using BikeRaceTracker.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace BikeRaceTracker.App.Views;

public sealed partial class TimePage : Page
{
    public TimeViewModel ViewModel
    {
        get;
    }

    public TimePage()
    {
        ViewModel = App.GetService<TimeViewModel>();
        InitializeComponent();
    }
}
