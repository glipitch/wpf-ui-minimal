using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TrailerDesktop;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string applicationTitle = "ThemedDiMvvm";

    [ObservableProperty]
    private int counter;

    [RelayCommand]
    private void OnCounterIncrement()
    {
        Counter++;
    }
}
