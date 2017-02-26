using System;
using Microsoft.Win32;

namespace CheckList
{
    class RegistryUtil
    {
        public static bool KeyExists(string path)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
                return key != null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static bool ValueExists(string path, string valueName)
        {
            if (!KeyExists(path))
            {
                return false;
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
                if (key.GetValue(valueName) != null)
                    return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static void DeleteKey(string path, string name)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.DeleteValue(name);
                key.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CreateKey(string path, string value, object valuedata)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.SetValue(value, valuedata);
                key.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
