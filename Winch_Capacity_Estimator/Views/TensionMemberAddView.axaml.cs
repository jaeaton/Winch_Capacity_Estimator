namespace Views
{
    public partial class TensionMemberAddView : UserControl
    {
        public TensionMemberAddView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Data;
        }
    }
}
