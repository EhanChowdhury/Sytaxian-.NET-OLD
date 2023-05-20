using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sytaxian
{
    public partial class SE : Form
    {
        public SE()
        {
            InitializeComponent();
        }

        private void sve_Click(object sender, EventArgs e)
        {
            if (Urltb.Text.Contains("search?q="))
            {
                Properties.Settings.Default.SearchEngine = Urltb.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else if (!Urltb.Text.Contains("search?q="))
            {
                MessageBox.Show("Please Try Again With a URL Resembeling This 'https://Example.SearchWebsite/search?q='");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SearchEngine = "https://search.brave.com/search?q=";
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
