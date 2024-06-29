using System.Windows;

namespace TrailerDesktop;

public partial class MainWindow
{
    public MainWindow(MainWindowViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}
