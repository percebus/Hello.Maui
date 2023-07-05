// <copyright file="MainActivity.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>

namespace Hello.Maui.AnyDeviceApp
{
    using Android.App;
    using Android.Content.PM;

    /// <summary>
    /// Main MauiAppCompatActivity.
    /// </summary>
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
