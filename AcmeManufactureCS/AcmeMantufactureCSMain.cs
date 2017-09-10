using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcmeManufactureVB;

namespace AcmeManufactureCS
{
    public partial class AcmeMantufactureCSMain : Form
    {
        public AcmeMantufactureCSMain()
        {
            InitializeComponent();
        }

        private void openForm_Click(object sender, EventArgs e)
        {
            AcmeManufactureVBMain vbform = new AcmeManufactureVBMain();
            vbform.Show();
        }
    }
}
