namespace Models
{
    public partial class WinchModel : ObservableObject
    {
        [ObservableProperty]
        private string winchName = string.Empty;

        [ObservableProperty]
        private string winchManufacturer = string.Empty;

        [ObservableProperty]
        private string winchModelNumber = string.Empty;

        [ObservableProperty]
        private string drumDiameter = string.Empty;
        partial void OnDrumDiameterChanged(string value)
        {
            DrumDiameter = value.Replace(",","");
        }

        [ObservableProperty]
        private string drumDiameterUnit = string.Empty;

        [ObservableProperty]
        private string flangeHeight = string.Empty;
        partial void OnFlangeHeightChanged(string value)
        {
            FlangeHeight = value.Replace(",", "");
        }

        [ObservableProperty]
        private string flangeHeightUnit = string.Empty;

        [ObservableProperty]
        private string drumWidth = string.Empty;
        partial void OnDrumWidthChanged(string value)
        {
            DrumWidth = value.Replace(",", "");
        }

        [ObservableProperty]
        private string drumWidthUnit = string.Empty;

        [ObservableProperty]
        private string levelWindDiameter = string.Empty;
        partial void OnLevelWindDiameterChanged(string value)
        {
            LevelWindDiameter = value.Replace(",", "");
        }

        [ObservableProperty]
        private string levelWindDiameterUnit = string.Empty;

        [ObservableProperty]
        private string linePull = string.Empty;
        partial void OnLinePullChanged(string value)
        {
            LinePull = value.Replace(",", "");
        }

        [ObservableProperty]
        private string linePullUnit = string.Empty;

        [ObservableProperty]
        private string designLineTension = string.Empty;
        partial void OnDesignLineTensionChanged(string value)
        {
            DesignLineTension = value.Replace(",", "");
        }

        [ObservableProperty]
        private string designLineTensionUnit = string.Empty;

        [ObservableProperty]
        private bool usesRollers;

        [ObservableProperty]
        private bool tensionMonitoring;
               
        public WinchModel()
        {

        }

        public WinchModel(string _winchName, string _winchManufacturer, string _winchModelNumber, string _drumDiameter,string _drumDiameterUnit, string _flangeHeight, string _flangeHeightUnit,string _drumWidth, string _drumWidthUnit, string _levelWindDiameter, string _levelWindDiameterUnit, string _linePull, string _linePullUnit, string _designLineTension, string _designLineTensionUnit, string _usesRollers, string _tensionMonitoring)
        {
            WinchName = _winchName;
            WinchManufacturer = _winchManufacturer;
            WinchModelNumber = _winchModelNumber;
            DrumDiameter = _drumDiameter;
            DrumDiameterUnit = _drumDiameterUnit;
            FlangeHeight = _flangeHeight;
            FlangeHeightUnit = _flangeHeightUnit;
            DrumWidth = _drumWidth;
            DrumWidthUnit = _drumWidthUnit;
            LevelWindDiameter = _levelWindDiameter;
            LevelWindDiameterUnit = _levelWindDiameterUnit;
            LinePull = _linePull;
            LinePullUnit = _linePullUnit;
            DesignLineTension = _designLineTension;
            DesignLineTensionUnit = _designLineTensionUnit;
            UsesRollers = Convert.ToBoolean(_usesRollers);
            TensionMonitoring = Convert.ToBoolean(_tensionMonitoring);
        }
public WinchModel ShallowCopy()
{
    return (WinchModel) this.MemberwiseClone();
}
public WinchModel DeepCopy()
{
    WinchModel copy = (WinchModel)this.MemberwiseClone();
    return copy;
        }
    }
}
