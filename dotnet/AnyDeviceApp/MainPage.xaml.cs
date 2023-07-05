// <copyright file="MainPage.xaml.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>
namespace Hello.Maui.AnyDeviceApp
{
    /// <summary>
    /// Partial class for Main ContentPage.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage() => this.InitializeComponent();

        /// <summary>
        /// Gets count of clicks.
        /// </summary>
        protected int Count { get; private set; } = 0;

        private void OnCounterClicked(object sender, EventArgs e)
        {
            this.Count++;
            if (this.Count == 1)
            {
                this.CounterBtn.Text = $"Clicked {this.Count} time";
            }
            else
            {
                this.CounterBtn.Text = $"Clicked {this.Count} times";
            }

            SemanticScreenReader.Announce(this.CounterBtn.Text);
        }
    }
}
