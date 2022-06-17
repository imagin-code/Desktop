﻿using Imagin.Core.Config;
using System;

namespace Imagin.Apps.Desktop
{
    public partial class App : SingleApplication
    {
        public override ApplicationProperties Properties => new ApplicationProperties<MainWindow, MainViewModel, Options>();

        [STAThread]
        public static void Main(params string[] Arguments)
        {
            if (SingleInstance<App>.InitializeAsFirstInstance(nameof(Desktop)))
            {
                var App = new App();
                App.InitializeComponent();
                App.Run();

                SingleInstance<App>.Cleanup();
            }
        }
    }
}