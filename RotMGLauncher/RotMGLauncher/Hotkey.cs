using System;

namespace RotMGLauncher
{
    internal class Hotkey : ISettings<Hotkey>
    {
        /// <summary>
        /// The Hotkeys to access the different functions and methods.
        /// This must only be set when in use.
        /// </summary>
        public string[] HotkeyKey { get; set; }

        /// <summary>
        /// Not Implemented yet.
        /// This is set when hotkeys are activated.
        /// </summary>
        public bool HotkeysActivated { get; set; }

        /// <summary>
        /// Constructor initializes the Hotkeys.
        /// </summary>
        public Hotkey()
        {
            this.HotkeyKey = new string[4];
            this.HotkeyKey[0] = "76"; // F7
            this.HotkeyKey[1] = "77"; // F8
            this.HotkeyKey[2] = "78"; // F9
            this.HotkeyKey[3] = "79"; // F10
            /*
             * 70 F1 key
             * 71 F2 key
             * 72 F3 key
             * 73 F4 key
             * 74 F5 key
             * 75 F6 key
             * 76 F7 key
             * 77 F8 key
             * 78 F9 key
             * 79 F10 key
             * 7A F11 key
             * 7B F12 key
             */
        }

        /// <summary>
        /// Reads the current set config for Hotkey from the XML file.
        /// NotImplementedException
        /// </summary>
        /// <returns>
        /// The current config of Hotkey.
        /// </returns>
        internal static Hotkey GetFromXML()
        {
            throw new NotImplementedException();
        }
    }
}