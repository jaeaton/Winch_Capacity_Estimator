namespace Models
{
    public partial class DrumTableModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LayerModel> drumTable = new();

        [ObservableProperty]
        private string? winchName;

        [ObservableProperty]
        private string? tMUsed;

        [ObservableProperty]
        private string? tMCapacity;

        [ObservableProperty]
        private string? layerQuantity;

        [ObservableProperty]
        private string? tMUnit;

        [ObservableProperty]
        private string? layerTurnQuantity;

        [ObservableProperty]
        private string? freeFlange;

        [ObservableProperty]
        private string? actualFreeFlange;

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
