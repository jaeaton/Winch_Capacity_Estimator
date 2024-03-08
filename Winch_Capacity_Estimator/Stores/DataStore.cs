namespace Stores
{
    public partial class DataStore : ObservableObject
    {
        [ObservableProperty]
        private object selectedTensionMember = new();
        partial void OnSelectedTensionMemberChanged(object value)
        {
            TabItemModel item = value as TabItemModel;
            LoadTensionMember(item.Header);
        }

        [ObservableProperty]
        private object selectedWinch = new();
        partial void OnSelectedWinchChanged(object value)
        {
            TabItemModel item = value as TabItemModel;
            LoadWinch(item.Header);
        }

        [ObservableProperty]
        private TensionMemberModel currentTensionMember = new();

        [ObservableProperty]
        private WinchModel currentWinch = new();

        [ObservableProperty]
        private ObservableCollection<WinchModel> winches = new();
        
        [ObservableProperty]
        private ObservableCollection<TensionMemberModel> tensionMembers = new();

        [ObservableProperty]
        private DrumTableModel drumTable = new();

        [ObservableProperty]
        private int selectedIndex = 0;
        partial void OnSelectedIndexChanged(int value)
        {
            if ( value >= 0)
            {
                value = value + 1;
                DrumCapacity(value);
            }
            
        }

        [ObservableProperty]
        private ObservableCollection<TabItemModel> winchList = new() 
        {
            new TabItemModel("Add New", "Add New")
        };
       
       [ObservableProperty]
        private ObservableCollection<TabItemModel> tensionMemberList = new()
        {
            new TabItemModel("Add New", "Add New")
        };

        [ObservableProperty]
        private List<string> spoolingFactorList = new()
        {
            "100",
            "99",
            "98",
            "97",
            "96",
            "95"
        };

        [ObservableProperty]
        private List<string> forceUnitList = new()
        {
            "lbf",
            "kg",
            "ton",
            "kn"
        };

        [ObservableProperty]
        private List<string> lengthUnitList = new List<string>()
        {
            "in",
            "ft",
            "kft",
            "mm",
            "m",
            "km"
        };

        [ObservableProperty]
        private List<string> freeFlangeList = new List<string>()
        {
            "2*TM Diameter",
            "2 in",
            "1/2 in",
            "None"

        };

        public void LoadTensionMember(string value)
        {

            string tensionMember = value;
            TensionMemberModel TensionMemberSelected = new();
            int index = -1;
            for (int i = 0; i < TensionMembers.Count; i++)
            {
                TensionMemberModel item = TensionMembers[i];
                if (item.CableName == tensionMember)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                //Not in list
            }
            if (index != -1)
            {
                TensionMemberSelected = TensionMembers[index].ShallowCopy();
            }
            else
            {
                //Something went wrong
            }
            CurrentTensionMember = TensionMemberSelected;
        }
        public void LoadWinch(string value)
        {
            string winch = value;
            WinchModel WinchSelected = new();
            int index = -1;
            for (int i = 0; i < Winches.Count; i++)
            {
                WinchModel item = Winches[i];
                if (item.WinchName == winch)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                //Not in list
            }
            if (index != -1)
            {
                WinchSelected = Winches[index].ShallowCopy();
            }
            else
            {
                //Something went wrong
            }
            CurrentWinch = WinchSelected;
        }

        [RelayCommand]
        private void AddWinch()
        {
            WinchAdd();
        }

        public void WinchAdd()
        {

        
            //Check to see if winch name is already used
            int index = -1;
            for (int i = 0; i < MainViewModel.Data.Winches.Count; i++)
            {
                WinchModel item = MainViewModel.Data.Winches[i];
                if (item.WinchName == MainViewModel.Data.CurrentWinch.WinchName)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                TabItemModel _item = new(MainViewModel.Data.CurrentWinch.WinchName, MainViewModel.Data.CurrentWinch.WinchName);
                MainViewModel.Data.Winches.Add(MainViewModel.Data.CurrentWinch.ShallowCopy());
                MainViewModel.Data.WinchList.Add(_item);
            }
            if (index != -1)
            {
                MainViewModel.Data.Winches[index] = MainViewModel.Data.CurrentWinch.ShallowCopy();
            }
            else
            {
                //Something went wrong
            }
            FileOperationsViewModel.SaveFile("winch");
        }

        [RelayCommand]
        private void RemoveWinch()
        {
            //Check to see if winch name is already used
            int index = -1;
            int index2 = -1;
            for (int i = 0; i < MainViewModel.Data.Winches.Count; i++)
            {
                WinchModel item = MainViewModel.Data.Winches[i];
                if (item.WinchName == MainViewModel.Data.CurrentWinch.WinchName)
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < MainViewModel.Data.WinchList.Count; i++)
            {
                TabItemModel item = MainViewModel.Data.WinchList[i];
                if (item.Header == MainViewModel.Data.CurrentWinch.WinchName)
                {
                    index2 = i;
                    break;
                }
            }
            if (index == -1)
            {
                MainViewModel.Data.CurrentWinch = new();
            }
            if (index != -1)
            {
                MainViewModel.Data.Winches.RemoveAt(index);

            }
            if (index2 != -1)
            {
                MainViewModel.Data.WinchList.RemoveAt(index2);
            }
            else
            {
                //Something went wrong
            }
            FileOperationsViewModel.SaveFile("winch");
        }
        [RelayCommand]
        private void AddTensionMember()
        {
            TensionMemberAdd();
        }
        
        public void TensionMemberAdd()
        { 
            //Check to see if wire name is already used
            int index = -1;
            for (int i = 0; i < TensionMembers.Count; i++)
            {
                TensionMemberModel item = TensionMembers[i];
                if (item.CableName == CurrentTensionMember.CableName)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                TabItemModel _item = new(CurrentTensionMember.CableName, CurrentTensionMember.CableName);
                TensionMembers.Add(CurrentTensionMember.ShallowCopy());
                TensionMemberList.Add(_item);
            }
            if (index != -1)
            {
                TensionMembers[index] = CurrentTensionMember.ShallowCopy();
            }
            else
            {
                //Something went wrong
            }
            FileOperationsViewModel.SaveFile("tensionMember");
        }

        [RelayCommand]
        private void RemoveTensionMember()
        {
            //Check to see if wire name is already used
            int index = -1;
            int index2 = -1;
            for (int i = 0; i < TensionMembers.Count; i++)
            {
                TensionMemberModel item = TensionMembers[i];
                if (item.CableName == CurrentTensionMember.CableName)
                {
                    index = i;
                    break;
                }
            }
            for (int i = 0; i < TensionMemberList.Count; i++)
            {
                TabItemModel item = TensionMemberList[i];
                if (item.Header == CurrentTensionMember.CableName)
                {
                    index2 = i;
                    break;
                }
            }
            if (index == -1)
            {
                CurrentTensionMember = new();
            }
            if (index != -1)
            {
                TensionMembers.RemoveAt(index);
                TensionMemberList.RemoveAt(index2);
            }
            else
            {
                //Something went wrong
            }
            FileOperationsViewModel.SaveFile("tensionMember");
        }

        [RelayCommand]
        public void DrumCapacity(object desiredLayers)
        {
            int layers = int.Parse(desiredLayers.ToString());
            WinchModel winch = CurrentWinch;
            TensionMemberModel tm = CurrentTensionMember;
            DrumTableModel dt = DrumTable;
            dt.DrumTable.Clear();
            string OutUnit = dt.TMUnit;
            double ff;
            double sf;
            string ffUnit;
                
            //Check and conver Spooling Factor (sf)
            bool bsf = double.TryParse(dt.SpoolingFactor, out sf);
            if (bsf)
            {
                sf = sf/100;
            }
            //Check and convert Flange Height (fh)
            bool bfh = double.TryParse(winch.FlangeHeight, out double fh);
            //Check and convert to consistent units (meters)
            if (bfh)
            {
                fh = UnitConversionToMeters(winch.FlangeHeightUnit, fh);
            }
            //Check and convert Drum Diameter (dd)
            bool bdd = double.TryParse(winch.DrumDiameter, out double dd);
            //Check and convert to consistent units (meters)
            if (bdd)
            {
                dd = UnitConversionToMeters(winch.DrumDiameterUnit, dd);
            }
            //Check and convert Drum Width (dw)
            bool bdw = double.TryParse(winch.DrumWidth, out double dw);
            //Check and convert to consistent units (meters)
            if (bdw)
            {
                dw = UnitConversionToMeters(winch.DrumWidthUnit, dw);
            }
            //Check and convert Line Pull (lp);
            bool blp = double.TryParse(winch.LinePull, out double lp);
            //Check and convert to consistant Units
            if (blp)
            {
                lp = UnitConversionToPounds(winch.LinePullUnit, lp);
            }
            //Check and convert Tension Member Diameter (tmd)
            bool btmd = double.TryParse(tm.Diameter, out double tmd);

            //Check and convert free flange
            switch (dt.FreeFlange)
            {
                case "2 in":
                    ff = UnitConversionToMeters("in", 2);
                    ffUnit = "in";
                    break;
                case "1/2 in":
                    ff = UnitConversionToMeters("in", 0.5);
                    ffUnit = "in";
                    break;
                case "None":
                    ff = 0;
                    ffUnit = tm.DiameterUnit;
                    break;
                default:
                    ff = UnitConversionToMeters(tm.DiameterUnit, 2 * tmd);
                    ffUnit = tm.DiameterUnit;
                    break;
            }

            if (layers > 1)
            {
                ff = fh - UnitConversionToMeters(tm.DiameterUnit ,(layers+.1) * tmd);
            }

            //Check and convert to consistent units (meters)
            if (btmd)
            {
                tmd = UnitConversionToMeters(tm.DiameterUnit, tmd);
            }
            bool btmw = double.TryParse(tm.WeightInWater, out double tmw);
            if (btmw)
            {
                tmw = UnitConversionToPounds(tm.WeightInWaterForceUnit, tmw) / (UnitConversionToMeters(tm.WeightInWaterLengthUnit, 1.0));
            }
            double tmLength;
            const double pi = 3.14159;

            //Check to see if calculations can be performed
            if (bfh != false && bdd != false && bdw != false && blp != false && btmd != false && btmw != false)
            {
                //Adjust flange height to usable flange
                double ufh = fh - ff;
                //Calculate number of Layers
                double layerCount;
                double aff;
                if (ufh % tmd != 0)
                {
                    layerCount = Math.Truncate(ufh / tmd);
                    ufh = layerCount * tmd;
                    aff = fh - ufh;

                    //dt.ActualFreeFlange = aff.ToString("#.#");
                }
                else
                {
                    layerCount = ufh / tmd;
                    aff = fh - ufh;
                    //dt.ActualFreeFlange = aff.ToString("#.#");
                }
                dt.ActualFreeFlange = UnitConversionFromMeters(ffUnit, aff).ToString("#.###");
                //Calculate Capacity
                //length = (Flange Height + Drum Diameter) * Flange Height * Drum Length * pi/(wire diameter^2)
                //Length = (Flange Diameter^2-Drum Diameter^2) * Drum Length * pi/(Wire Diameter^2)
                tmLength = sf * ((ufh + dd) * ufh * dw * pi / (tmd * tmd));
                tmLength = UnitConversionFromMeters(OutUnit, tmLength);
                dt.TMCapacity = tmLength.ToString("#.#");
                dt.LayerQuantity = layerCount.ToString("#.#");

                //Calculate Turns per Layer
                double turnCount = dw / tmd;
                dt.LayerTurnQuantity = turnCount.ToString("#.#");

                //Calculate Drum Table
                double lengthPerLayer;
                double lengthOffDrum;
                double lengthOnDrum = 0;
                double linePullOnLayer;
                double liveLoad;
                int i = 1;
                do
                {
                    lengthPerLayer = sf * ((tmd + (dd + (i - 1) * 2 * tmd)) * tmd * dw * pi / (tmd * tmd));
                    lengthPerLayer = UnitConversionFromMeters(OutUnit, lengthPerLayer);
                    lengthOnDrum += lengthPerLayer;
                    lengthOffDrum = tmLength - lengthOnDrum;
                    linePullOnLayer = lp * (dd / 2) / (dd / 2 + (i - 0.5) * tmd);
                    liveLoad = linePullOnLayer - tmw * lengthOffDrum;
                    linePullOnLayer = UnitConversionfromPounds(winch.LinePullUnit, linePullOnLayer);
                    liveLoad = UnitConversionfromPounds(winch.LinePullUnit, liveLoad);
                    LayerModel layer = new LayerModel(i.ToString("##"), lengthPerLayer.ToString("#.#"), lengthOnDrum.ToString("#.#"), lengthOffDrum.ToString("#.#"), linePullOnLayer.ToString("#.#"), liveLoad.ToString("#.#"));
                    dt.DrumTable.Add(layer);
                    i++;
                } while (i <= layerCount);
            }
        }
        //Converts values to meters
        public double UnitConversionToMeters(string unit, double value)
        {
            switch (unit)
            {
                case "mm":
                    value = value / 1000;
                    break;
                case "in":
                    value = value * 25.4 / 1000;
                    break;
                case "ft":
                    value = (value * 12 * 25.4) / 1000;
                    break;
                case "kft":
                    value = (value * 1000 * 12 * 25.4) / 1000;
                    break;
                case "km":
                    value = value * 1000;
                    break;
                default:
                    break;
            }
            return value;
        }
        //Converts values from meters
        public double UnitConversionFromMeters(string unit, double value)
        {
            switch (unit)
            {
                case "mm":
                    value = value * 1000;
                    break;
                case "in":
                    value = value * 1000 / 25.4;
                    break;
                case "ft":
                    value = (value * 1000) / (12 * 25.4);
                    break;
                case "kft":
                    value = (value * 1000) / (1000 * 12 * 25.4);
                    break;
                case "km":
                    value = value / 1000;
                    break;
                default:
                    break;
            }
            return value;
        }

        //Converts value to pounds
        public double UnitConversionToPounds(string unit, double value)
        {
            switch (unit)
            {
                case "kg":
                    value = value * 2.2;
                    break;
                case "kn":
                    value = (value / 9.81) * 2.2;
                    break;
                case "ton":
                    value = value * 2000;
                    break;
                default:
                    break;
            }
            return value;
        }
        //Converts value from pounds
        public double UnitConversionfromPounds(string unit, double value)
        {
            switch (unit)
            {
                case "kg":
                    value = value / 2.2;
                    break;
                case "kn":
                    value = (value * 9.81) / 2.2;
                    break;
                case "ton":
                    value = value / 2000;
                    break;
                default:
                    break;
            }
            return value;
        }
    }
}
