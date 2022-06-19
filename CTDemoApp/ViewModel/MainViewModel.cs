using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CTDemoApp.ViewModel
{
    // ViewModel classes using the MVVM Toolkit need to be declared as partial due to the MVVM toolkit generating partial code for the class.
    public partial class MainViewModel : ObservableObject
    {
        // The ObservableProperty attribute generates getters and setters based on instance variable names.
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string _firstName = "";

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        string _lastName = "";

        public string FullName => $"{FirstName} {LastName}";

        [ICommand]
        void Submit()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}
