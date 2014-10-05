using System;

namespace RotMGLauncher
{
    internal class Macro : ISettings<Macro>
    {
        /// <summary>
        /// Array which holds the Text of the Macro.
        /// This must only be set when in use.
        /// </summary>
        public string[] MacroText { get; set; }

        /// <summary>
        /// Array which saves the hotkey for the Macro.
        /// This must only be set when in use.
        /// </summary>
        public string[] MacroKey { get; set; }

        /// <summary>
        /// Not Implemented yet.
        /// This is set when Macros are activated.
        /// </summary>
        public bool MacrosActivated { get; set; }

        /// <summary>
        /// Constructor initializes the properties with its default values.
        /// </summary>
        public Macro()
        {
            this.MacroText = new string[4];
            this.MacroText[0] = "He lives and reigns and conquers the world.";
            this.MacroText[1] = "Teleport here{!}";
            this.MacroText[2] = "/pause";
            this.MacroText[3] = "All move in{!}";

            this.MacroKey = new string[4];
            this.MacroKey[0] = "70"; // F1
            this.MacroKey[1] = "71"; // F2
            this.MacroKey[2] = "72"; // F3
            this.MacroKey[3] = "73"; // F4
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
        /// Reads the current set config for Macro from the XML file.
        /// NotImplementedException
        /// </summary>
        /// <returns>
        /// The current config of Macro.
        /// </returns>
        internal static Macro GetFromXML()
        {
            throw new NotImplementedException();
        }
    }
}