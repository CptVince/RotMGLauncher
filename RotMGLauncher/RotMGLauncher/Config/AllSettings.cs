using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using RotMGLauncher.Interfaces;
using System.Collections.Generic;

namespace RotMGLauncher.Config
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

            //actualSettings.GeneralS.GetFromXML();
            //actualSettings.HotkeyS = Hotkey.GetFromXML();
            //actualSettings.MacroS = Macro.GetFromXML();
            //actualSettings.LocationS = Location.GetFromXML();

            if (File.Exists(@"config.xml"))
            {
                using (FileStream fs = new FileStream(@"config.xml", FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        string[] settingNames = { "G:CustomCursor", "G:ClientTitle", "G:KongregateLogin", "G:AdditionalProgram",
                                                    "G:EnableMacros", "G:PlayOnTesting", "G:EnableHotkeys", "G:ScreenshotOnPrintKey", "G:IncludeCursorOnScreenshot",
                                                    "L:FlashProjectorFile", "L:CustomCursor", "L:AdditionalProgram", "L:HotkeysLocation", "L:MacrosLocation", "L:KongregateParameter",
                                                    "H:ReziseWindowToDefault", "H:LaunchMediaPlayer", "H:PlayPause", "H:SwitchNextSong", "H:SwitchPrevSong", "H:StopMusic",
                                                    "M:Macro1Text", "M:Macro2Text", "M:Macro3Text", "M:Macro4Text", "M:Macro1Key", "M:Macro2Key", "M:Macro3Key", "M:Macro4Key"};
                        string previous = string.Empty, xml = "";
                        Dictionary<string, string> settingsDictionary = new Dictionary<string, string>();

                        using (StreamReader reader = new StreamReader(fs))
                        {
                            xml = reader.ReadToEnd();
                        }

                        //Console.WriteLine(xml);
                        
                        foreach (string setting in settingNames)
                        {
                            settingsDictionary.Add(setting, Regex.Match(xml, "<" + Regex.Match(setting, "[A-Z]:(\\w*)").Groups[1].Value + ">([\\?\\=\\&\\;\\w\\s]*)").Groups[1].Value);
                            //Console.WriteLine(settingsDictionary[setting]);
                            //Console.WriteLine(typeof(General).GetType().GetProperties());
                            switch (Regex.Match(setting,"([A-Z]):\\w*").Groups[1].Value)
                            {
                                case "G":
                                    foreach (var prop in this.GeneralS.GetType().GetProperties())
                                    {
                                        //Console.WriteLine("{0}\t{1}", Regex.Match(setting, "[A-Z]:(\\w*)").Groups[1].Value, prop.Name);
                                        if (Regex.Match(setting, "[A-Z]:(\\w*)").Groups[1].Value == prop.Name)
                                            Console.WriteLine("{0}", prop.Name);
                                        /*
                                         * 
                                         * Failed to set properties stuck here at the moment
                                         * 
                                         * 
                                         */
                                        //else
                                        //    Console.WriteLine("Fail at {0}: {1}", prop.Name, Regex.Match(setting, "[A-Z]:(\\w*)").Groups[1].Value);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                    return actualSettings;
                }
            }

            return actualSettings;
        }

        public bool WriteSettings()
        {
            if (this == null)
            {
                return false;
            }


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(@"config.xml", settings))
            {
                try
                {
                    writer.WriteStartDocument();
                        writer.WriteStartElement("Settings");

                            writer.WriteStartElement("General");
                                writer.WriteElementString("CustomCursor", this.GeneralS.CustomCursor.ToString());
                                writer.WriteElementString("ClientTitle", this.GeneralS.ClientTitle.ToString());
                                writer.WriteElementString("KongregateLogin", this.GeneralS.KongregateLogin.ToString());
                                writer.WriteElementString("AdditionalProgram", this.GeneralS.AdditionalProgram.ToString());
                                writer.WriteElementString("EnableMacros", this.GeneralS.EnableMacros.ToString());
                                writer.WriteElementString("PlayOnTesting", this.GeneralS.PlayOnTesting.ToString());
                                writer.WriteElementString("EnableHotkeys", this.GeneralS.EnableHotkeys.ToString());
                                writer.WriteElementString("ScreenshotOnPrintKey", this.GeneralS.ScreenshotOnPrintKey.ToString());
                                writer.WriteElementString("IncludeCursorOnScreenshot", this.GeneralS.IncludeCursorOnScreenshot.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Location");
                                writer.WriteElementString("FlashProjectorFile", this.LocationS.FlashProjectorFile.ToString());
                                writer.WriteElementString("CustomCursor", this.LocationS.CustomCursor.ToString());
                                writer.WriteElementString("AdditionalProgram", this.LocationS.AdditionalProgram.ToString());
                                writer.WriteElementString("HotkeysLocation", this.LocationS.HotkeysLocation.ToString());
                                writer.WriteElementString("MacrosLocation", this.LocationS.MacrosLocation.ToString());
                                writer.WriteElementString("KongregateParameter", this.LocationS.KongregateParameter.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Hotkeys");
                                writer.WriteElementString("ReziseWindowToDefault", this.HotkeyS.HotkeyKey[0].ToString());
                                writer.WriteElementString("LaunchMediaPlayer", this.HotkeyS.HotkeyKey[1].ToString());
                                writer.WriteElementString("PlayPause", this.HotkeyS.HotkeyKey[2].ToString());
                                writer.WriteElementString("SwitchNextSong", this.HotkeyS.HotkeyKey[3].ToString());
                                writer.WriteElementString("SwitchPrevSong", this.HotkeyS.HotkeyKey[4].ToString());
                                writer.WriteElementString("StopMusic", this.HotkeyS.HotkeyKey[5].ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("Macros");
                                writer.WriteElementString("Macro1Text", this.MacroS.MacroText[0].ToString());
                                writer.WriteElementString("Macro2Text", this.MacroS.MacroText[1].ToString());
                                writer.WriteElementString("Macro3Text", this.MacroS.MacroText[2].ToString());
                                writer.WriteElementString("Macro4Text", this.MacroS.MacroText[3].ToString());
                                writer.WriteElementString("Macro1Key", this.MacroS.MacroKey[0].ToString());
                                writer.WriteElementString("Macro2Key", this.MacroS.MacroKey[1].ToString());
                                writer.WriteElementString("Macro3Key", this.MacroS.MacroKey[2].ToString());
                                writer.WriteElementString("Macro4Key", this.MacroS.MacroKey[3].ToString());
                            writer.WriteEndElement();
                    
                        writer.WriteEndElement();
                    writer.WriteEndDocument();

                    writer.Close();

                    Console.WriteLine("Config file successfully created.");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return false;
                }
            }

            return true;
        }
    }
}