using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.UI;

namespace ShoesStoreManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mainform mainform = new Mainform();
            Login login = new Login(mainform);
            Application.Run(login);            
        }
        public static void CreateShortcut(string saveDir)
        {
            //string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
           // string fileName = saveDir + "\\" + Product + ".lnk";
           // IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(fileName);

            //shortcut.Description = "";
            //shortcut.Hotkey = "Ctrl+M";
            //shortcut.IconLocation = Application.StartupPath + @"\icon.ico";
            //shortcut.TargetPath = Application.ExecutablePath ;
            //shortcut.Save();
        }
    }
}
