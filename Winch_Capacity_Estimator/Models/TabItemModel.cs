namespace Models
{
    public partial class TabItemModel : ObservableObject
    {
        [ObservableProperty]
        private string header = string.Empty;
        [ObservableProperty]
        private string content = string.Empty;

        public TabItemModel()
        {
            
        }
        public TabItemModel(string header, string content)
        {
            this.header = header;
            this.content = content;
        }

        public override string ToString()
        {
            return Header;
        }
    }
}
