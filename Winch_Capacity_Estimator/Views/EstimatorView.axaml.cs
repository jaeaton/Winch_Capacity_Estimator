namespace Views
{
    public partial class EstimatorView : UserControl
    {
        public EstimatorView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Data;
        }
    }
}
