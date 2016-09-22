using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foundation;
using HockeyApp;
using UIKit;

namespace LepidopteraNames.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //We MUST wrap our setup in this block to wire up
            // Mono's SIGSEGV and SIGBUS signals
            HockeyApp.Setup.EnableCustomCrashReporting(() =>
            {
                //Get the shared instance
                var manager = BITHockeyManager.SharedHockeyManager;

                //Configure it to use our APP_ID
                manager.Configure("dd6672b9bce146509dcfc5a1b8252d2a");

                //Start the manager
                manager.StartManager();
                manager.UpdateManager.CheckForUpdateOnLaunch = false;

                //Authenticate (there are other authentication options)
                manager.Authenticator.AuthenticateInstallation();

                //Rethrow any unhandled .NET exceptions as native iOS 
                // exceptions so the stack traces appear nicely in HockeyApp
                AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
                    Setup.ThrowExceptionAsNative(e.ExceptionObject);

                TaskScheduler.UnobservedTaskException += (sender, e) =>
                    Setup.ThrowExceptionAsNative(e.Exception);
            });

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
