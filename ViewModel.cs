using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUI_tests
{
    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        bool _isTrue;

        public ViewModel()
        {
            IsTrue = false;
        }
    }
}
