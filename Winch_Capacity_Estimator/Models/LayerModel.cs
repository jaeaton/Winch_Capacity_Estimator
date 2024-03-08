namespace Models
{
    public partial class LayerModel : ObservableObject
    {
        [ObservableProperty]
        private string layerNumber = string.Empty;

        [ObservableProperty] 
        private string layerLength = string.Empty;

        [ObservableProperty]
        private string tMOnDrum = string.Empty;

        [ObservableProperty]
        private string tMOffDrum = string.Empty;

        [ObservableProperty]
        private string layerLinePull = string.Empty;

        [ObservableProperty]
        private string liveLoad = string.Empty;

        public LayerModel()
        {

        }

        public LayerModel(string _layerNumber,string _layerLength,string _tMOnDrum, string _tMOffDrum, string _layerLinePull, string _liveLoad)
        {
            LayerNumber = _layerNumber;
            LayerLength = _layerLength;
            TMOnDrum = _tMOnDrum;
            TMOffDrum = _tMOffDrum; 
            layerLinePull = _layerLinePull;
            LiveLoad = _liveLoad;
        }
        public LayerModel ShallowCopy()
        {
            return (LayerModel)this.MemberwiseClone();
        }

        public LayerModel DeepCopy()
        {
            LayerModel copy = (LayerModel)this.MemberwiseClone();
            return copy;
        }
    }
 }
