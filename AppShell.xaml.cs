using MAUI_tests.Helpers;

namespace MAUI_tests;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);
        var vm = ServiceHelper.GetService<ViewModel>();
        BindingContext = vm;
    }
}
