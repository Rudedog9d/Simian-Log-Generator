using System;
using System.IO;
using System.Windows.Forms;

namespace WCM_Log_Generator
{
    class Util
    {
        static public void validateDirectory(string path, Array extensionFilter = null)
        {
            if(! Directory.Exists(path))
            {
                MessageBox.Show("Directory not found: '" + path + "'");
            } else
            {
                MessageBox.Show("Valid Directory: '" + path + "'");

            }
        }
    }
}
