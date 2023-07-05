// <copyright file="MauiProgram.cs" company="JCystems">
// Copyright (c) JCystems. All rights reserved.
// </copyright>
namespace Hello.Maui.AnyDeviceApp
{
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Maui Program static class.
    /// </summary>
    public static class MauiProgram
    {
        /// <summary>
        /// Creates a Maui App via a MauiApp builder.
        /// </summary>
        /// <returns>MauiApp.</returns>
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
