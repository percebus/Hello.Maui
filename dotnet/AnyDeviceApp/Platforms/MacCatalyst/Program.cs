// <copyright file="Program.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>

namespace Hello.Maui.AnyDeviceApp
{
    using UIKit;

    /// <summary>
    /// Main UIApplication Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main UIApplication entry point.
        /// </summary>
        /// <param name="args">UIApplication's arguments.</param>
        protected static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}
