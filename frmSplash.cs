using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer1.Start();
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 2;
            if (panel2.Left > 500)
            {
                panel2.Left = -80;
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
