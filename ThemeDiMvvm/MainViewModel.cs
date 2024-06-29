using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ThemedDiMvvm;

public partial class MainViewModel : ObservableObject
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
