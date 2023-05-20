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
    
    public partial class Settings : Form
    {
        int formloaded = 1;
        public Settings()
        {
            InitializeComponent();
        }
        public void loadControl(Control control)
        {
            if (mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls.Clear();
            }
            Control f = control;
            this.mainpanel.Controls.Add(f);
        }


        private void aboutbtn_Click(object sender, EventArgs e)
        {   if (formloaded != 5)
            {
                loadControl(new about());
                formloaded = 5;
            }
        }

        private void adbk_Click(object sender, EventArgs e)
        {
            if (formloaded != 3)
            {
                loadControl(new adblocker());
                formloaded = 3;
            }
               
        }

        private void generalbtn_Click(object sender, EventArgs e)
        {
            if (formloaded != 1)
            {
                loadControl(new General());
                formloaded = 1;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadControl(new General());
        }
    }
}
