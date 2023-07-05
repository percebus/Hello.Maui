// <copyright file="App.xaml.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>
namespace Hello.Maui.AnyDeviceApp.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    /// <remarks>More about our project templates, see: http://aka.ms/winui-project-info.</remarks>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
#pragma warning disable CS1061 // "App does not contain a definition for InitializeComponent"
        public App() => this.InitializeComponent();
#pragma warning restore CS1061

        /// <inheritdoc/>
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
