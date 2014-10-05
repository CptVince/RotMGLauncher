namespace RotMGLauncher
{
    internal class Config
    {
        /// <summary>
        /// Here are all settings saved.
        /// </summary>
        public AllSettings AllSetting { get; set; }

        /// <summary>
        /// Constructor to init all settings and get the actual settings from the XML file.
        /// </summary>
        public Config()
        {
            AllSetting = new AllSettings();
            AllSetting = AllSetting.GetFromXML();
        }
    }
}