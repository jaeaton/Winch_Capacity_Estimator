namespace ECWP_Drum_Estimator.ViewModels
{
    public partial class WinchViewModel : ObservableObject
    {
        //[ObservableProperty]
        //private WinchModel? currentWinch = new WinchModel();

        //[RelayCommand]
        //private void AddWinch() 
        //{
        //    //Check to see if winch name is already used
        //    int index = -1;
        //    for (int i = 0; i < MainViewModel.Data.Winches.Count; i++)
        //    {
        //        WinchModel item = MainViewModel.Data.Winches[i];
        //        if (item.WinchName == MainViewModel.Data.CurrentWinch.WinchName)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    if (index == -1)
        //    {
        //        TabItemModel _item = new(MainViewModel.Data.CurrentWinch.WinchName, MainViewModel.Data.CurrentWinch.WinchName);
        //        MainViewModel.Data.Winches.Add(MainViewModel.Data.CurrentWinch.ShallowCopy());
        //        MainViewModel.Data.WinchList.Add(_item);
        //    }
        //    if (index != -1)
        //    {
        //        MainViewModel.Data.Winches[index] = MainViewModel.Data.CurrentWinch.ShallowCopy();
        //    }
        //    else
        //    {
        //        //Something went wrong
        //    }
        //    FileOperationsViewModel.SaveFile("winch");
        //}

        //[RelayCommand]
        //private void RemoveWinch() 
        //{
        //    //Check to see if winch name is already used
        //    int index = -1;
        //    int index2 = -1;
        //    for (int i = 0; i < MainViewModel.Data.Winches.Count; i++)
        //    {
        //        WinchModel item = MainViewModel.Data.Winches[i];
        //        if (item.WinchName == MainViewModel.Data.CurrentWinch.WinchName)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    for (int i = 0; i < MainViewModel.Data.WinchList.Count; i++)
        //    {
        //        TabItemModel item = MainViewModel.Data.WinchList[i];
        //        if (item.Header == MainViewModel.Data.CurrentWinch.WinchName)
        //        {
        //            index2 = i;
        //            break;
        //        }
        //    }
        //    if (index == -1)
        //    {
        //        MainViewModel.Data.CurrentWinch = new();
        //    }
        //    if (index != -1)
        //    {
        //        MainViewModel.Data.Winches.RemoveAt(index);
                
        //    }
        //    if (index2 != -1)
        //    {
        //        MainViewModel.Data.WinchList.RemoveAt(index2);
        //    }
        //    else
        //    {
        //        //Something went wrong
        //    }
        //    FileOperationsViewModel.SaveFile("winch");
        //}

        //public void LoadWinch(string? value)
        //{
        //    string winch = value;
        //    WinchModel WinchSelected = new();
        //    int index = -1;
        //    for (int i = 0; i < MainViewModel.Data.Winches.Count; i++)
        //    {
        //        WinchModel item = MainViewModel.Data.Winches[i];
        //        if (item.WinchName == winch)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    if (index == -1)
        //    {
        //        //Not in list
        //    }
        //    if (index != -1)
        //    {
        //        WinchSelected = MainViewModel.Data.Winches[index].ShallowCopy();
        //    }
        //    else
        //    {
        //        //Something went wrong
        //    }
        //    CurrentWinch = WinchSelected;
        //}
    }
}
