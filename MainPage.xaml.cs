using MAUI_tests.Helpers;
using Sentry;

namespace MAUI_tests;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        var vm = ServiceHelper.GetService<ViewModel>();
        SentrySdk.CaptureMessage("Counter clicked");
    }
}

