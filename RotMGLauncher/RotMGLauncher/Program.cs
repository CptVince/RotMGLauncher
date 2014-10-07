using System;
using System.Xml;
using RotMGLauncher.Config;

namespace RotMGLauncher
{
    internal class Program
    {
        /// <summary>
        /// This is just the function to test everything later it will be compiled to a dll.
        /// </summary>
        /// <param name="args">
        /// Parameter from the programstart.
        /// </param>
        private static void Main(string[] args)
        {
            AllSettings setting = new AllSettings();
            //setting.WriteSettings();
            // Write default settings to the xml

            setting.GetFromXML();

            Console.ReadLine();
        }
    }
}