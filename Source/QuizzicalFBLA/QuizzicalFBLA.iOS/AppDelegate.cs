﻿using System;
using System.Collections.Generic;
using System.Linq;
using Auth0.OidcClient;
using CarouselView.FormsPlugin.iOS;
using Foundation;
using InstabugLib;
using LabelHtml.Forms.Plugin.iOS;
using Lottie.Forms.iOS.Renderers;
using UIKit;

namespace QuizzicalFBLA.iOS
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
            HtmlLabelRenderer.Initialize();

            global::Xamarin.Forms.Forms.Init();
            AnimationViewRenderer.Init();
            CarouselViewRenderer.Init();
            LoadApplication(new App());

            Instabug.StartWithToken("6c4ce2b08ac3afa29539f59017d374a9", IBGInvocationEvent.Shake);

            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            ActivityMediator.Instance.Send(url.AbsoluteString);

            return true;
        }
    }
}
