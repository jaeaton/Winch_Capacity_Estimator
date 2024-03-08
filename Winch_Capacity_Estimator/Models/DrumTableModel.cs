namespace Models
{
    public partial class DrumTableModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LayerModel> drumTable = new();

        [ObservableProperty]
        private string winchName = string.Empty;

        [ObservableProperty]
        private string tMUsed = string.Empty;

        [ObservableProperty]
        private string tMCapacity = string.Empty;

        [ObservableProperty]
        private string layerQuantity = string.Empty;

        [ObservableProperty]
        private string tMUnit = string.Empty;

        [ObservableProperty]
        private string layerTurnQuantity = string.Empty;

        [ObservableProperty]
        private string freeFlange = string.Empty;

        [ObservableProperty]
        private string actualFreeFlange = string.Empty;

        [ObservableProperty]
        private string spoolingFactor = new string("96");

        public DrumTableModel()
        {
            
        }
        public DrumTableModel ShallowCopy()
        {
            return (DrumTableModel)this.MemberwiseClone();
        }

        public DrumTableModel DeepCopy()
        {
            DrumTableModel copy = (DrumTableModel)this.MemberwiseClone();
            return copy;
        }
        }
    }
