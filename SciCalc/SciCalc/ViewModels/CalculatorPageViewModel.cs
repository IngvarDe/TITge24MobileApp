using CommunityToolkit.Mvvm.ComponentModel;


namespace SciCalc.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class CalculatorPageViewModel //: ObservableObject
    {
        [ObservableProperty]
        private string inputText = string.Empty;

        [ObservableProperty]
        private string calculatedResult = "0";

        private bool isSciOpWaiting = false;

    }
}
