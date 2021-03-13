
namespace Ui
{
    partial class MyCity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pollution = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tips = new System.Windows.Forms.Button();
            this.covid = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.userControl41 = new Ui.UserControl4();
            this.userControl31 = new Ui.UserControl3();
            this.userControl21 = new Ui.UserControl2();
            this.userControl11 = new Ui.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pollution);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tips);
            this.panel1.Controls.Add(this.covid);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 675);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.Location = new System.Drawing.Point(11, 658);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://youtu.be/dQw4w9WgXcQ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 124);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 163);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // pollution
            // 
            this.pollution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pollution.AutoSize = true;
            this.pollution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pollution.FlatAppearance.BorderSize = 0;
            this.pollution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pollution.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pollution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pollution.Image = ((System.Drawing.Image)(resources.GetObject("pollution.Image")));
            this.pollution.Location = new System.Drawing.Point(0, 144);
            this.pollution.Name = "pollution";
            this.pollution.Size = new System.Drawing.Size(217, 124);
            this.pollution.TabIndex = 2;
            this.pollution.Text = "Pollution";
            this.pollution.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pollution.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pollution.UseVisualStyleBackColor = true;
            this.pollution.Click += new System.EventHandler(this.Pollution_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(0, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 124);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // tips
            // 
            this.tips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tips.AutoSize = true;
            this.tips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tips.FlatAppearance.BorderSize = 0;
            this.tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tips.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.tips.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tips.Image = ((System.Drawing.Image)(resources.GetObject("tips.Image")));
            this.tips.Location = new System.Drawing.Point(0, 431);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(217, 124);
            this.tips.TabIndex = 2;
            this.tips.Text = "Tips";
            this.tips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tips.UseVisualStyleBackColor = true;
            this.tips.Click += new System.EventHandler(this.Tips_Click);
            // 
            // covid
            // 
            this.covid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.covid.AutoSize = true;
            this.covid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.covid.FlatAppearance.BorderSize = 0;
            this.covid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.covid.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.covid.Image = ((System.Drawing.Image)(resources.GetObject("covid.Image")));
            this.covid.Location = new System.Drawing.Point(0, 267);
            this.covid.Name = "covid";
            this.covid.Size = new System.Drawing.Size(217, 165);
            this.covid.TabIndex = 2;
            this.covid.Text = "Covid-19";
            this.covid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.covid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.covid.UseVisualStyleBackColor = true;
            this.covid.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel5;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
            this.panel5.Controls.Add(this.min);
            this.panel5.Controls.Add(this.X);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1184, 53);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.AutoSize = true;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.min.Location = new System.Drawing.Point(1084, 12);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(38, 38);
            this.min.TabIndex = 1;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // X
            // 
            this.X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X.AutoSize = true;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.X.Location = new System.Drawing.Point(1128, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(38, 38);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
            this.userControl41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControl41.Location = new System.Drawing.Point(222, 51);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(962, 635);
            this.userControl41.TabIndex = 5;
            // 
            // userControl31
            // 
            this.userControl31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl31.AutoSize = true;
            this.userControl31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
            this.userControl31.Location = new System.Drawing.Point(222, 38);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(962, 644);
            this.userControl31.TabIndex = 3;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load_1);
            // 
            // userControl21
            // 
            this.userControl21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl21.AutoSize = true;
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
            this.userControl21.Location = new System.Drawing.Point(222, 38);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(962, 644);
            this.userControl21.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
            this.userControl11.ForeColor = System.Drawing.Color.Coral;
            this.userControl11.Location = new System.Drawing.Point(222, 38);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(962, 644);
            this.userControl11.TabIndex = 1;
            // 
            // MyCity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyCity";
            this.Text = "My City";
            this.Load += new System.EventHandler(this.UI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pollution;
        private System.Windows.Forms.Button tips;
        private System.Windows.Forms.Button covid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl4 userControl41;
    }
}

