using Foundation;
using GameKit;
using Google.MobileAds;
using UIKit;

namespace RockBandNameMauiApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            MobileAds.SharedInstance.Start(CompletionHandler);
            //var viewController = new UIViewController();
            //var completionHandler = new Google.MobileAds.AdInspectorCompletionHandler(adInspectorCompletionHandler);
            //MobileAds.SharedInstance.PresentAdInspectorFromViewController(viewController, completionHandler);
            return base.FinishedLaunching(application, launchOptions);
        }

        private void CompletionHandler(InitializationStatus status) { }
        //private void adInspectorCompletionHandler(Foundation.NSError error) { }
}
