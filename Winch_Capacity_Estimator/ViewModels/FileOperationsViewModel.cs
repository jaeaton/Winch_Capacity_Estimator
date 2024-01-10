namespace ViewModels
{
    internal class FileOperationsViewModel
    {
        public static void SaveFile(string _sender)
        {
            string filename;
            List<string> _data = new();
            if (_sender == "winch")
            {
                _data = FormatWinchList();
                filename = "Winch_List.txt";
                WriteFiles(filename, _data);
            }
            if (_sender == "tensionMember")
            {
                _data = FormatTensionMemberList();
                filename = "Tension_Member_List.txt";
                WriteFiles(filename, _data);
            }
            //Write list to filename
        }

        public static void LoadFile(string _sender)
        {
            string filename;
            List<string> _data = new();
            if (_sender == "winch")
            {
                filename = "Winch_List.txt";
                ReadFiles(filename, _sender);
            }
            if (_sender == "tensionMember")
            {
                filename = "Tension_Member_List.txt";
                ReadFiles(filename,_sender);
            }
        }

        public static void ReadFiles(string filename, string sender)
        {
            List<string> lines = new();
            string destPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            //On start up read files
            //Read Winch list and add data to a winchModel then add model to Data store
            try
            {
                using (StreamReader stream = new StreamReader(destPath))
                {
                    string text;
                    while ((text = stream.ReadLine()) != null)
                    {
                        lines.Add(text);
                    }
                }
            }
            catch (Exception ex) { }
            //Read TM list and add data to a TensionMemberModel then add model to Data store
            if (sender == "winch")
            {
                ParseWinchList(lines);
            }
            if (sender == "tensionMember")
            {
                ParseTensionMemberList(lines);
            }
                    
                    

        }
        public static void WriteFiles(string filename, List<string> list)
        {
            string destPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            if (File.Exists(destPath))
            {
                File.Delete(destPath);
            }
            //Write files to disk
            //Open file
            //write stream to file
            //Write each line of array using stream writer
            using (StreamWriter stream = new StreamWriter(destPath, true))
            {
                
                foreach (string line in list)
                    stream.WriteLine(line);
            }
        }

        public static List<string> FormatWinchList()
        {
            List<string> _winchList = new();
            foreach (WinchModel winch in MainViewModel.Data.Winches)
            {
                _winchList.Add($"{winch.WinchName},{winch.WinchManufacturer},{winch.WinchModelNumber},{winch.DrumDiameter},{winch.DrumDiameterUnit},{winch.FlangeHeight},{winch.FlangeHeightUnit},{winch.DrumWidth},{winch.DrumWidthUnit},{winch.LevelWindDiameter},{winch.LevelWindDiameterUnit},{winch.LinePull},{winch.LinePullUnit},{winch.DesignLineTension},{winch.DesignLineTensionUnit},{winch.UsesRollers.ToString()},{winch.TensionMonitoring.ToString()}");

            }
            return _winchList;
        }

        public static List<string> FormatTensionMemberList()
        {
            List<string> _tensionMemberList = new();
            foreach (TensionMemberModel tensionMember in MainViewModel.Data.TensionMembers)
            {
                _tensionMemberList.Add($"{tensionMember.CableName},{tensionMember.CableManufacturer},{tensionMember.CablePartNumber},{tensionMember.Diameter},{tensionMember.DiameterUnit},{tensionMember.AssignedBreakingLoad},{tensionMember.AssignedBreakingLoadUnit},{tensionMember.WeightInWater},{tensionMember.WeightInWaterForceUnit},{tensionMember.WeightInWaterLengthUnit},{tensionMember.WeightInAir},{tensionMember.WeightInAirForceUnit},{tensionMember.WeightInAirLengthUnit},{tensionMember.LargestStrandDiameter},{tensionMember.LargestStrandDiameterUnit},{tensionMember.CableMaterial},{tensionMember.BendDiameter},{tensionMember.BendDiameterUnit}");
            }
            return _tensionMemberList;
        }

        public static void ParseWinchList(List<string> _data)
        {
            
            foreach (string line in _data) 
            {
                WinchModel? winch = MainViewModel.Data.CurrentWinch;
                var data = line.Split(',');
                winch.WinchName = data[0];
                winch.WinchManufacturer = data[1];
                winch.WinchModelNumber = data[2];
                winch.DrumDiameter = data[3];
                winch.DrumDiameterUnit = data[4];
                winch.FlangeHeight = data[5];
                winch.FlangeHeightUnit = data[6];
                winch.DrumWidth = data[7];
                winch.DrumWidthUnit = data[8];
                winch.LevelWindDiameter = data[9];
                winch.LevelWindDiameterUnit = data[10];
                winch.LinePull = data[11];
                winch.LinePullUnit = data[12];
                winch.DesignLineTension = data[13];
                winch.DesignLineTensionUnit = data[14];
                winch.UsesRollers = Convert.ToBoolean(data[15]);
                winch.TensionMonitoring = Convert.ToBoolean(data[16]);

                MainViewModel.Data.WinchAdd();
            }
            
        }

        public static void ParseTensionMemberList(List<string> _data)
        {
            
            foreach (string line in _data)
            {
                TensionMemberModel? tensionMember = MainViewModel.Data.CurrentTensionMember;
                var data = line.Split(',');
                tensionMember.CableName = data[0];
                tensionMember.CableManufacturer = data[1];
                tensionMember.CablePartNumber = data[2];
                tensionMember.Diameter = data[3];
                tensionMember.DiameterUnit = data[4];
                tensionMember.AssignedBreakingLoad = data[5];
                tensionMember.AssignedBreakingLoadUnit = data[6];
                tensionMember.WeightInWater = data[7];
                tensionMember.WeightInWaterForceUnit = data[8];
                tensionMember.WeightInWaterLengthUnit = data[9];
                tensionMember.WeightInAir = data[10];
                tensionMember.WeightInAirForceUnit = data[11];
                tensionMember.WeightInAirLengthUnit = data[12];
                tensionMember.LargestStrandDiameter = data[13];
                tensionMember.LargestStrandDiameterUnit = data[14];
                tensionMember.CableMaterial = data[15];
                tensionMember.BendDiameter = data[16];
                tensionMember.BendDiameterUnit = data[17];

                MainViewModel.Data.TensionMemberAdd();
            }
           
        }
    }
}
