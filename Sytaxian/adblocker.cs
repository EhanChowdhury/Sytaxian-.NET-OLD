using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sytaxian
{
    public partial class adblocker : UserControl
    {
        NetworkManagement networkManagement = new NetworkManagement();
        
        public adblocker()
        {
            InitializeComponent();
        }


        private void adblockswitch_CheckedChanged(object sender, EventArgs e)
        {
            if (adblockswitch.Checked == false)
            {
                networkManagement.UnsetDNS();
                Properties.Settings.Default.Adblock = 0;
                Properties.Settings.Default.Save();
            }
            if (adblockswitch.Checked == true)
            {
                Properties.Settings.Default.Adblock = 1;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.Adblock == 0)
                {
                    networkManagement.SetDNS("94.140.14.14");
                } 
            }
        }

        private void adblocker_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Adblock == 1)
            {
                adblockswitch.Checked = true;
            }
            if (Properties.Settings.Default.Adblock == 0)
            {
                adblockswitch.Checked = false;
            }
        }
    }
}
