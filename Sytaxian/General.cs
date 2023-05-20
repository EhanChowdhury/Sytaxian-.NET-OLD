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
    public partial class General : UserControl
    {
        public General()
        {
            InitializeComponent();
        }

        private void searchenginebtn_Click(object sender, EventArgs e)
        {
            Form se = new SE();
            se.ShowDialog();
        }
    }
}
