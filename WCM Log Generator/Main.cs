using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCM_Log_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectSourceDirectory_Click(object sender, EventArgs e)
        {
            string ret = Util.ChooseDirectory();

            if (ret == null)
            {
                MessageBox.Show("Please select a valid Directory!");
            } else
            {
                txtSourceDirectory.Text = ret;
            }
        }

        private void btnSelectDestDirectory_Click(object sender, EventArgs e)
        {
            string ret = Util.ChooseDirectory();

            if (ret == null)
            {
                MessageBox.Show("Please select a valid Directory!");
            }
            else
            {
                txtSourceDirectory.Text = ret;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string extensions = txtFileExtensions.Text;
            string[] filter = null;

            if (string.IsNullOrWhiteSpace(txtSourceDirectory.Text) || string.IsNullOrWhiteSpace(txtOutputDirectory.Text))
            {
                MessageBox.Show("Please select a source and destination Directory First!");
                return;
            }

            // Split extensions on ',' and ' ' to allow multiple extensions
            if (!string.IsNullOrWhiteSpace(extensions))
                filter = extensions.Split(new char[] { ',', ' ' });

            List<string> files = Util.GetFiles(txtSourceDirectory.Text, filter);

            var str = "Files: ";

            foreach (var f in files)
            {
                str += "\n" + f.ToString();
            }

            //MessageBox.Show(str);
            Util.GenerateLog(files, txtOutputDirectory.Text, "out");
        }
    }
}
