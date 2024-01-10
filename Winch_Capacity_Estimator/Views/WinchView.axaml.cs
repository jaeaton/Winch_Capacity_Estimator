namespace Views
{
    public partial class WinchView : UserControl
    {
        public WinchView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Data;

        }
    }
}
