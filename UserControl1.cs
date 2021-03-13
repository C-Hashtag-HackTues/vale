using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ui
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.AddXY(1, 5);
            this.chart1.Series[0].Points.AddXY(3, 4);
            this.chart1.Series[0].Points.AddXY(3, 5);
            this.chart1.Series[0].Points.AddXY(2, 1);
            this.chart1.Series[0].Points.AddXY(1, 1);
            this.chart1.Series[1].Points.AddXY(1, 3);
            this.chart1.Series[1].Points.AddXY(2, 4);
            this.chart1.Series[1].Points.AddXY(3, 2);
            this.chart1.Series[1].Points.AddXY(3, 1);
            this.chart1.Series[1].Points.AddXY(1, 1);
            chart1.Series[0]["PieLabelStyle"] = "Disabled";
            this.chart1.Show();
        }

        private void Polutionlabel_Click(object sender, EventArgs e)
        {

        }

        private void BunifuShapes1_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void Chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
