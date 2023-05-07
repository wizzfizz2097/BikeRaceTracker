using System.Windows.Input;

using BikeRaceTracker.App.Contracts.Services;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Navigation;

namespace BikeRaceTracker.App.ViewModels;

public class ShellViewModel : ObservableRecipient
{
    private bool _isBackEnabled;

    public ICommand MenuFileExitCommand
    {
        get;
    }

    public ICommand MenuSettingsCommand
    {
        get;
    }

    public ICommand MenuViewsContentGridCommand
    {
        get;
    }

    public ICommand MenuViewsLapsCommand
    {
        get;
    }

    public ICommand MenuViewsTimeCommand
    {
        get;
    }

    public ICommand MenuViewsMainCommand
    {
        get;
    }

    public INavigationService NavigationService
    {
        get;
    }

    public bool IsBackEnabled
    {
        get => _isBackEnabled;
        set => SetProperty(ref _isBackEnabled, value);
    }

    public ShellViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;

        MenuFileExitCommand = new RelayCommand(OnMenuFileExit);
        MenuSettingsCommand = new RelayCommand(OnMenuSettings);
        MenuViewsContentGridCommand = new RelayCommand(OnMenuViewsContentGrid);
        MenuViewsLapsCommand = new RelayCommand(OnMenuViewsLaps);
        MenuViewsTimeCommand = new RelayCommand(OnMenuViewsTime);
        MenuViewsMainCommand = new RelayCommand(OnMenuViewsMain);
    }

    private void OnNavigated(object sender, NavigationEventArgs e) => IsBackEnabled = NavigationService.CanGoBack;

    private void OnMenuFileExit() => Application.Current.Exit();

    private void OnMenuSettings() => NavigationService.NavigateTo(typeof(SettingsViewModel).FullName!);

    private void OnMenuViewsContentGrid() => NavigationService.NavigateTo(typeof(ContentGridViewModel).FullName!);

    private void OnMenuViewsLaps() => NavigationService.NavigateTo(typeof(LapsViewModel).FullName!);

    private void OnMenuViewsTime() => NavigationService.NavigateTo(typeof(TimeViewModel).FullName!);

    private void OnMenuViewsMain() => NavigationService.NavigateTo(typeof(MainViewModel).FullName!);
}
