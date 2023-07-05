// <copyright file="App.xaml.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>

namespace Hello.Maui.AnyDeviceApp
{
    /// <summary>
    /// Partial class for Application.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.MainPage = new AppShell();
        }
    }
}
