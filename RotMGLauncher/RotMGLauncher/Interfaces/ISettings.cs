namespace RotMGLauncher.Interfaces
{
    internal interface ISettings<T>
    {
        /// <summary>
        /// All setting classes must implement a method to get the setting from the XML.
        /// </summary>
        /// <returns>Returns T which is the type of the setting.</returns>
        //static T GetFromXML();
    }
}