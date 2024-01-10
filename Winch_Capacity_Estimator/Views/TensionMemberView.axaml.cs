namespace Views
{
    public partial class TensionMemberView : UserControl
    {
        public TensionMemberView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Data;
           
        }
    }
}
