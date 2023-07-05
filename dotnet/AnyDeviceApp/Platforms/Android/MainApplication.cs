// <copyright file="MainApplication.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>

namespace Hello.Maui.AnyDeviceApp
{
    using Android.App;
    using Android.Runtime;

    /// <summary>
    /// Main MauiApplication.
    /// </summary>
    [Application]
    public class MainApplication : MauiApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainApplication"/> class.
        /// </summary>
        /// <param name="handle">Ptr{Int} handler.</param>
        /// <param name="ownership">JNI handler's ownership.</param>
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        /// <inheritdoc/>
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
