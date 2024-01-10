namespace Views
{
    public partial class WinchAddView : UserControl
    {
        public WinchAddView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Data;

        }
    }
}
