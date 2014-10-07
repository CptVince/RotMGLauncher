using System;
using System.IO;
using System.Xml;
using RotMGLauncher.Config;
using RotMGLauncher.Interfaces;

namespace RotMGLauncher.Config
{
    /// <summary>
    /// A class for the settings in General GUI.
    /// </summary>
    internal class General : ISettings<General>
    {
        /// <summary>
        /// Enable the use of a custom cursor.
        /// </summary>
        public bool CustomCursor { get; set; }

        /// <summary>
        /// The wanted title of the Flash-Projector.
        /// </summary>
        public string ClientTitle { get; set; }

        /// <summary>
        /// Login as Kongregate or normal.
        /// </summary>
        public bool KongregateLogin { get; set; }

        /// <summary>
        /// Enable the start of an additional program to be launched with RotMG.
        /// </summary>
        public bool AdditionalProgram { get; set; }

        /// <summary>
        /// Enable or disable Macros.
        /// </summary>
        public bool EnableMacros { get; set; }

        /// <summary>
        /// Check to play on Testing.
        /// </summary>
        public bool PlayOnTesting { get; set; }

        /// <summary>
        /// Enable or disable Hotkeys.
        /// </summary>
        public bool EnableHotkeys { get; set; }

        /// <summary>
        /// Make a Screenshot when the print key is pressed.
        /// </summary>
        public bool ScreenshotOnPrintKey { get; set; }

        /// <summary>
        /// Check if the cursor shall be included in the screenshot.
        /// </summary>
        public bool IncludeCursorOnScreenshot { get; set; }

        /// <summary>
        /// Constructor to initialize the properties with their default value.
        /// </summary>
        public General()
        {
            // default values
            this.CustomCursor = true;
            this.ClientTitle = "Realm of the Mad God";
            this.KongregateLogin = false;
            this.AdditionalProgram = false;
            this.EnableMacros = true;
            this.PlayOnTesting = false;
            this.EnableHotkeys = true;
            this.ScreenshotOnPrintKey = true;
            this.IncludeCursorOnScreenshot = true;

        }
    }
}