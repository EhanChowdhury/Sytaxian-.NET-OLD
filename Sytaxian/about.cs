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
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();
        }

        private void chrome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cefsharp.github.io/");
        }
    }
}
