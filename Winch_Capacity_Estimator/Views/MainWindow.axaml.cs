namespace Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        FileOperationsViewModel.LoadFile("winch");
        FileOperationsViewModel.LoadFile("tensionMember");
    }
}
