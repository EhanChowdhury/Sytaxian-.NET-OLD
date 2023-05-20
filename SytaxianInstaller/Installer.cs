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
using SytaxianInstaller.Properties;

namespace SytaxianInstaller
{
    public partial class Installer : Form
    {
        public Installer()
        {
            InitializeComponent();
        }

        private void Installer_Load(object sender, EventArgs e)
        {
            //AddDirectory(@"C:\\Program Files", "Sytaxian");
            File.Copy(@"C:\\Program Files (x86)", "just-color-picker-2.0.zip");
        }
        private DirectoryInfo AddDirectory(string targetFolder, string dirName)
        {
            // screen for null
            if (String.IsNullOrEmpty(targetFolder) || String.IsNullOrEmpty(dirName))
            {
                throw new ArgumentException(string.Format("targetFolder {0}  and/or dirName {1} is empty)", targetFolder, dirName));
            }
            string folderPath = Path.Combine(targetFolder, dirName);
            if (folderPath.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                throw new InvalidDataException(String.Format("folderPath: {0} is invalid", folderPath));
            }

            if (Directory.Exists(folderPath))
            {
                return new DirectoryInfo(folderPath);
            }
            else
            {
                return Directory.CreateDirectory(folderPath);
            }
        }
    }
}
