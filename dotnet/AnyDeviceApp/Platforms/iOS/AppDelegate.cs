// <copyright file="AppDelegate.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>

namespace Hello.Maui.AnyDeviceApp
{
    using Foundation;

    /// <summary>
    /// App's MauiUIApplicationDelegate.
    /// </summary>
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        /// <inheritdoc/>
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
