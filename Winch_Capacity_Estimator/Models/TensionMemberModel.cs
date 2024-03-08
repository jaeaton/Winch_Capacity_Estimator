namespace Models
{
    public partial class TensionMemberModel : ObservableObject
    {
        [ObservableProperty]
        private string cableName = string.Empty;

        [ObservableProperty]
        private string cableManufacturer = string.Empty;

        [ObservableProperty]
        private string cablePartNumber = string.Empty;

        [ObservableProperty]
        private string diameter = string.Empty;
        partial void OnDiameterChanged(string value)
        {
            Diameter = value.Replace(",", "");
        }

        [ObservableProperty]
        private string diameterUnit = string.Empty;

        [ObservableProperty]
        private string assignedBreakingLoad = string.Empty;
        partial void OnAssignedBreakingLoadChanged(string value)
        {
            AssignedBreakingLoad = value.Replace(",", "");
        }

        [ObservableProperty]
        private string assignedBreakingLoadUnit = string.Empty;

        [ObservableProperty]
        private string weightInWater = string.Empty;
        partial void OnWeightInWaterChanged(string value)
        {
            WeightInWater = value.Replace(",", "");
        }

        [ObservableProperty]
        private string weightInWaterForceUnit = string.Empty;

        [ObservableProperty]
        private string weightInWaterLengthUnit = string.Empty;

        [ObservableProperty]
        private string weightInAir = string.Empty;
        partial void OnWeightInAirChanged(string value)
        {
            WeightInAir = value.Replace(",", "");
        }

        [ObservableProperty]
        private string weightInAirForceUnit = string.Empty;

        [ObservableProperty]
        private string weightInAirLengthUnit = string.Empty;

        [ObservableProperty]
        private string largestStrandDiameter = string.Empty;
        partial void OnLargestStrandDiameterChanged(string value)
        {
            LargestStrandDiameter = value.Replace(",", "");
        }

        [ObservableProperty]
        private string largestStrandDiameterUnit = string.Empty;

        [ObservableProperty]
        private string cableMaterial = string.Empty;

        [ObservableProperty]
        private string bendDiameter = string.Empty;

        [ObservableProperty]
        private string bendDiameterUnit = string.Empty;

        public TensionMemberModel()
        {
            
        }

        public TensionMemberModel ShallowCopy()
        {
            return (TensionMemberModel) this.MemberwiseClone();
        }

        public TensionMemberModel DeepCopy()
        {
            TensionMemberModel copy = (TensionMemberModel)this.MemberwiseClone();
            return copy;
        }
    }
}
