namespace Models
{
    public partial class TensionMemberModel : ObservableObject
    {
        [ObservableProperty]
        private string? cableName;

        [ObservableProperty]
        private string? cableManufacturer;

        [ObservableProperty]
        private string? cablePartNumber;

        [ObservableProperty]
        private string? diameter;
        partial void OnDiameterChanged(string? value)
        {
            Diameter = value.Replace(",", "");
        }

        [ObservableProperty]
        private string? diameterUnit;

        [ObservableProperty]
        private string? assignedBreakingLoad;
        partial void OnAssignedBreakingLoadChanged(string? value)
        {
            AssignedBreakingLoad = value.Replace(",", "");
        }

        [ObservableProperty]
        private string? assignedBreakingLoadUnit;

        [ObservableProperty]
        private string? weightInWater;
        partial void OnWeightInWaterChanged(string? value)
        {
            WeightInWater = value.Replace(",", "");
        }

        [ObservableProperty]
        private string? weightInWaterForceUnit;

        [ObservableProperty]
        private string? weightInWaterLengthUnit;

        [ObservableProperty]
        private string? weightInAir;
        partial void OnWeightInAirChanged(string? value)
        {
            WeightInAir = value.Replace(",", "");
        }

        [ObservableProperty]
        private string? weightInAirForceUnit;

        [ObservableProperty]
        private string? weightInAirLengthUnit;

        [ObservableProperty]
        private string? largestStrandDiameter;
        partial void OnLargestStrandDiameterChanged(string? value)
        {
            LargestStrandDiameter = value.Replace(",", "");
        }

        [ObservableProperty]
        private string? largestStrandDiameterUnit;

        [ObservableProperty]
        private string? cableMaterial;

        [ObservableProperty]
        private string? bendDiameter;

        [ObservableProperty]
        private string? bendDiameterUnit;

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
