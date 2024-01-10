namespace Models
{
    public partial class LayerModel : ObservableObject
    {
        [ObservableProperty]
        private string? layerNumber;

        [ObservableProperty] 
        private string layerLength;

        [ObservableProperty]
        private string? tMOnDrum;

        [ObservableProperty]
        private string? tMOffDrum;

        [ObservableProperty]
        private string? layerLinePull;

        [ObservableProperty]
        private string? liveLoad;

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
