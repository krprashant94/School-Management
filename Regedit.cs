using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    class Regedit
    {
        private RegistryKey key;
        private string regVal;
        public Regedit()
        {
        }
        public void add(String name, String value, String path)
        {
            try
            {
                key = Registry.CurrentUser.CreateSubKey("School\\"+path);
                key.SetValue(name, value);
                key.Close();
            }
            catch (Exception)
            {
            }
        }
        public String get(String name, String path)
        {
            try
            {
                key = Registry.CurrentUser.OpenSubKey(@"School\\" + path);
                regVal = key.GetValue(name).ToString();
                key.Close();
                return regVal;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
