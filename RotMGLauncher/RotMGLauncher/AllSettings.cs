namespace RotMGLauncher
{
    /// <summary>
    /// The reference to store all settings.
    /// </summary>
    internal class AllSettings : ISettings<AllSettings>
    {
        /// <summary>
        /// Stores all General settings.
        /// </summary>
        public General GeneralS { get; set; }

        /// <summary>
        /// Stores all Hotkeys.
        /// </summary>
        public Hotkey HotkeyS { get; set; }

        /// <summary>
        /// Stores all Macros.
        /// </summary>
        public Macro MacroS { get; set; }

        /// <summary>
        /// Stores the locations.
        /// </summary>
        public Location LocationS { get; set; }

        /// <summary>
        /// Constructor to initializse the properties.
        /// </summary>
        public AllSettings()
        {
            this.GeneralS = new General();
            this.HotkeyS = new Hotkey();
            this.MacroS = new Macro();
            this.LocationS = new Location();
        }

        /// <summary>
        /// From Inteface ISettings to get all settings bundled.
        /// GetFromXML of the other settings are NotImplementedException.
        /// </summary>
        /// <returns>The actualSettings set in the XML file.</returns>
        public AllSettings GetFromXML()
        {
            AllSettings actualSettings = new AllSettings();

            actualSettings.GeneralS = General.GetFromXML();
            actualSettings.HotkeyS = Hotkey.GetFromXML();
            actualSettings.MacroS = Macro.GetFromXML();
            actualSettings.LocationS = Location.GetFromXML();

            return actualSettings;
        }
    }
}