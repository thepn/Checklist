using System;
using System.IO;
using System.Net;

namespace CheckList
{
    class SettingsClass
    {
        // static instance of this class
        public static SettingsClass instance = new SettingsClass();

        public float bgR = 255;
        public float bgG = 0;
        public float bgB = 100;

        public float textR = 255;
        public float textG = 255;
        public float textB = 255;

        public bool alwaysOnTop = true;
        public bool draggable = false;
        public bool rightScreenSide = false;
        public bool autoStart = false;

        public int xpos;
        public int ypos;

        private SettingsClass()
        {
            VerifyInstallation();
            load();
        }

        //checks if the software is already installed; if not the program will download and install the .exe file from the website
        private void VerifyInstallation()
        {
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SebPas\Checklist\checklist.exe"))
            {
                WebClient webclient = new WebClient();
                webclient.DownloadFile("http://www.sebpas.de/checklist/checklist.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SebPas\Checklist\checklist.exe");
            }
        }

        // loads the color settings from file
        public void load()
        {
            bgR = Properties.Settings.Default.bgRed * 255 / 100;
            bgG = Properties.Settings.Default.bgGreen * 255 / 100;
            bgB = Properties.Settings.Default.bgBlue * 255 / 100;

            textR = Properties.Settings.Default.textRed * 255 / 100;
            textG = Properties.Settings.Default.textGreen * 255 / 100;
            textB = Properties.Settings.Default.textBlue * 255 / 100;

            alwaysOnTop = Properties.Settings.Default.alwaysOnTop;
            draggable = Properties.Settings.Default.draggable;
            rightScreenSide = Properties.Settings.Default.rightScreenSide;

            xpos = Properties.Settings.Default.xpos;
            ypos = Properties.Settings.Default.ypos;

            autoStart = RegistryUtil.ValueExists(@"Software\Microsoft\Windows\CurrentVersion\Run", "Checklist");
        }

        // saves the color settings to settings file
        public void save()
        {
            Properties.Settings.Default.bgRed = bgR / 255 * 100;
            Properties.Settings.Default.bgGreen = bgG / 255 * 100;
            Properties.Settings.Default.bgBlue = bgB / 255 * 100;

            Properties.Settings.Default.textRed = textR / 255 * 100;
            Properties.Settings.Default.textGreen = textG / 255 * 100;
            Properties.Settings.Default.textBlue = textB / 255 * 100;

            Properties.Settings.Default.alwaysOnTop = alwaysOnTop;
            Properties.Settings.Default.draggable = draggable;
            Properties.Settings.Default.rightScreenSide = rightScreenSide;
            Properties.Settings.Default.xpos = xpos;
            Properties.Settings.Default.ypos = ypos;

            if (autoStart)
            {
                if(!RegistryUtil.ValueExists(@"Software\Microsoft\Windows\CurrentVersion\Run", "Checklist"))
                {
                    RegistryUtil.CreateKey(@"Software\Microsoft\Windows\CurrentVersion\Run", "Checklist", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SebPas\Checklist\checklist.exe");
                }
            }else
            {
                if (RegistryUtil.ValueExists(@"Software\Microsoft\Windows\CurrentVersion\Run", "Checklist"))
                {
                    RegistryUtil.DeleteKey(@"Software\Microsoft\Windows\CurrentVersion\Run", "Checklist");
                }
            }

            Properties.Settings.Default.Save();
        }
    }
}
