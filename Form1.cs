using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Ui
{
    public partial class MyCity : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public void HidePanels()
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }
        public void UserControlHide()
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }
        public MyCity()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
            HidePanels();
            
            panel2.Visible = false;
            player.SoundLocation = "proval.wav";
            //player.Play();
        }
        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
        private void UI_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            UserControlHide();
            userControl41.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            HidePanels();
            UserControlHide();
            userControl21.Show();
            panel3.Visible = true;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Pollution_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            HidePanels();
            UserControlHide();
            userControl11.Show();
            panel2.Visible = true;
        }

        private void Tips_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            HidePanels();
            UserControlHide();
            userControl31.Show();
            panel4.Visible = true;
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtu.be/dQw4w9WgXcQ");
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserControl31_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
                Refresh();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                Refresh();
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Refresh();
            }
        }

        private void userControl31_Load_1(object sender, EventArgs e)
        {

        }
    }
}
