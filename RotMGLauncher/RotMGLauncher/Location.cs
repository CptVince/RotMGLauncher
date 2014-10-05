using System;

namespace RotMGLauncher
{
    /// <summary>
    /// A class for the settings in Path and Location of files.
    /// </summary>
    internal class Location : ISettings<Location>
    {
        /// <summary>
        /// The path to the flash projector/the flash player
        /// </summary>
        public string FlashProjectorFile { get; set; }

        /// <summary>
        /// Path to the custom cursor file.
        /// This must only be set when in use.
        /// </summary>
        public string CustomCursor { get; set; }

        /// <summary>
        /// The path to the additional program.
        /// This must only be set when in use.
        /// </summary>
        public string AdditionalProgram { get; set; }

        /// <summary>
        /// Path to the hotkeys.xml.
        /// This must only be set when in use.
        /// </summary>
        public string HotkeysLocation { get; set; }

        /// <summary>
        /// Path to the macros.xml.
        /// This must only be set when in use.
        /// </summary>
        public string MacrosLocation { get; set; }

        /// <summary>
        /// This are the parameters for the Kongregate login
        /// This must only be set when in use.
        /// </summary>
        public string KongregateParameter { get; set; }

        /// <summary>
        /// The constructor initializes the properties to their default values.
        /// </summary>
        public Location()
        {
            this.FlashProjectorFile = @"data\flashplayer_14_sa.exe";
            this.CustomCursor = @"data\Cursors\rotmg.cur";
            this.AdditionalProgram = @"C:\Your\Program.exe";
            this.HotkeysLocation = @"data\hotkeys.xml";
            this.MacrosLocation = @"data\macros.xml";
            this.KongregateParameter = @"?kongregate_username=USERNAME&kongregate_user_id=USERID&kongregate_game_auth_token=TOKEN&kongregate_api_path=PATH";
        }

        /// <summary>
        /// Reads the current set config for Location from the XML file.
        /// NotImplementedException
        /// </summary>
        /// <returns>
        /// The current config of Location.
        /// </returns>
        internal static Location GetFromXML()
        {
            throw new NotImplementedException();
        }
    }
}