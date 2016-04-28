﻿using System;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainMenu menu = new MainMenu();

            Application.Run(menu);

            //using (var game = new Game1())
            //    game.Run();
        }
    }
#endif
}