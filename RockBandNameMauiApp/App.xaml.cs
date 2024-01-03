// using Microsoft.AppCenter;
// using Microsoft.AppCenter.Analytics;
// using Microsoft.AppCenter.Crashes;

namespace RockBandNameMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}
	// Can't install App Center nuget pkgs. Android error "Could not load source 'JNIEnv.cs': No source available." Seems to be a 
	// holdover from Xamarin.Forms https://learn.microsoft.com/en-us/answers/questions/669653/xamarin-forms-(android)-jnienv-cs-not-found
	// 20240103 - KLH
	// protected override void OnStart()
	// {
	// 	AppCenter.Start("ios=f8c274aa-9d37-4df4-b997-cbfa192d8e25;" +
    //               "uwp={Your UWP App secret here};" +
    //               "android=264b58a3-a9fb-4acc-8822-8a3383e88e74;" +
    //               "macos={Your macOS App secret here};",
    //               typeof(Analytics), typeof(Crashes));
	// }
}
