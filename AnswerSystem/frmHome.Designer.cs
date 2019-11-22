namespace AnswerSystem
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tlpHomeBack = new System.Windows.Forms.TableLayoutPanel();
            this.plBottom = new AnswerSystem.Cons.MyPanel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pl_main_back = new AnswerSystem.Cons.MyPanel();
            this.plMain = new AnswerSystem.Cons.MyPanel();
            this.plTop = new AnswerSystem.Cons.MyPanel();
            this.myPanel4 = new AnswerSystem.Cons.MyPanel();
            this.myPanel3 = new AnswerSystem.Cons.MyPanel();
            this.myPanel1 = new AnswerSystem.Cons.MyPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myPictureBox3 = new AnswerSystem.Cons.MyPictureBox();
            this.pbExit = new AnswerSystem.Cons.MyPictureBox();
            this.tlpHomeBack.SuspendLayout();
            this.plBottom.SuspendLayout();
            this.pl_main_back.SuspendLayout();
            this.plTop.SuspendLayout();
            this.myPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHomeBack
            // 
            this.tlpHomeBack.ColumnCount = 1;
            this.tlpHomeBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHomeBack.Controls.Add(this.plBottom, 0, 1);
            this.tlpHomeBack.Controls.Add(this.plTop, 0, 0);
            this.tlpHomeBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHomeBack.Location = new System.Drawing.Point(0, 0);
            this.tlpHomeBack.Name = "tlpHomeBack";
            this.tlpHomeBack.RowCount = 3;
            this.tlpHomeBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpHomeBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpHomeBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHomeBack.Size = new System.Drawing.Size(1024, 768);
            this.tlpHomeBack.TabIndex = 0;
            // 
            // plBottom
            // 
            this.plBottom.BackgroundImage = global::AnswerSystem.Properties.Resources.main_bottom;
            this.plBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plBottom.Content = null;
            this.plBottom.Controls.Add(this.lblCopyright);
            this.plBottom.Controls.Add(this.pl_main_back);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBottom.ForeColor = System.Drawing.Color.White;
            this.plBottom.Location = new System.Drawing.Point(0, 60);
            this.plBottom.Margin = new System.Windows.Forms.Padding(0);
            this.plBottom.Name = "plBottom";
            this.tlpHomeBack.SetRowSpan(this.plBottom, 2);
            this.plBottom.Size = new System.Drawing.Size(1024, 708);
            this.plBottom.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyright.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(0, 670);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(1024, 38);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "©2019 常春藤软件有限公司";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_main_back
            // 
            this.pl_main_back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_main_back.BackColor = System.Drawing.Color.Transparent;
            this.pl_main_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_main_back.BackgroundImage")));
            this.pl_main_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_main_back.Content = null;
            this.pl_main_back.Controls.Add(this.plMain);
            this.pl_main_back.ForeColor = System.Drawing.Color.White;
            this.pl_main_back.Location = new System.Drawing.Point(19, 15);
            this.pl_main_back.Margin = new System.Windows.Forms.Padding(0);
            this.pl_main_back.Name = "pl_main_back";
            this.pl_main_back.Padding = new System.Windows.Forms.Padding(18, 39, 23, 18);
            this.pl_main_back.Size = new System.Drawing.Size(996, 655);
            this.pl_main_back.TabIndex = 1;
            // 
            // plMain
            // 
            this.plMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plMain.BackColor = System.Drawing.Color.Transparent;
            this.plMain.BackgroundImage = global::AnswerSystem.Properties.Resources.main_home_back2;
            this.plMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plMain.Content = null;
            this.plMain.ForeColor = System.Drawing.Color.White;
            this.plMain.Location = new System.Drawing.Point(18, 39);
            this.plMain.Margin = new System.Windows.Forms.Padding(0);
            this.plMain.Name = "plMain";
            this.plMain.Padding = new System.Windows.Forms.Padding(3);
            this.plMain.Size = new System.Drawing.Size(955, 598);
            this.plMain.TabIndex = 0;
            // 
            // plTop
            // 
            this.plTop.BackgroundImage = global::AnswerSystem.Properties.Resources.main_top_background;
            this.plTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plTop.Content = null;
            this.plTop.Controls.Add(this.myPanel4);
            this.plTop.Controls.Add(this.myPanel3);
            this.plTop.Controls.Add(this.myPanel1);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTop.ForeColor = System.Drawing.Color.White;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1024, 60);
            this.plTop.TabIndex = 1;
            // 
            // myPanel4
            // 
            this.myPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanel4.BackColor = System.Drawing.Color.Transparent;
            this.myPanel4.BackgroundImage = global::AnswerSystem.Properties.Resources.main_top_top;
            this.myPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.myPanel4.Content = null;
            this.myPanel4.ForeColor = System.Drawing.Color.White;
            this.myPanel4.Location = new System.Drawing.Point(302, 0);
            this.myPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel4.Name = "myPanel4";
            this.myPanel4.Size = new System.Drawing.Size(436, 17);
            this.myPanel4.TabIndex = 3;
            // 
            // myPanel3
            // 
            this.myPanel3.BackColor = System.Drawing.Color.Transparent;
            this.myPanel3.BackgroundImage = global::AnswerSystem.Properties.Resources.Title_nobackground;
            this.myPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPanel3.Content = null;
            this.myPanel3.ForeColor = System.Drawing.Color.White;
            this.myPanel3.Location = new System.Drawing.Point(33, 13);
            this.myPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel3.Name = "myPanel3";
            this.myPanel3.Size = new System.Drawing.Size(215, 34);
            this.myPanel3.TabIndex = 2;
            // 
            // myPanel1
            // 
            this.myPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanel1.BackColor = System.Drawing.Color.Transparent;
            this.myPanel1.BackgroundImage = global::AnswerSystem.Properties.Resources.main_top_right;
            this.myPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPanel1.Content = null;
            this.myPanel1.Controls.Add(this.tableLayoutPanel2);
            this.myPanel1.Controls.Add(this.pbExit);
            this.myPanel1.ForeColor = System.Drawing.Color.White;
            this.myPanel1.Location = new System.Drawing.Point(510, 19);
            this.myPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(514, 35);
            this.myPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.575963F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.42403F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 35);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblStudentName);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lblStudentID);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.myPictureBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 35);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(360, 5);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(52, 27);
            this.lblStudentName.TabIndex = 10;
            this.lblStudentName.Text = "小明";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(297, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "姓名:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(135, 5);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(156, 27);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "201910022018";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "学号:";
            // 
            // myPictureBox3
            // 
            this.myPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myPictureBox3.Image = global::AnswerSystem.Properties.Resources.little_man;
            this.myPictureBox3.Location = new System.Drawing.Point(44, 5);
            this.myPictureBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.myPictureBox3.Name = "myPictureBox3";
            this.myPictureBox3.Size = new System.Drawing.Size(22, 26);
            this.myPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPictureBox3.TabIndex = 7;
            this.myPictureBox3.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbExit.Image = global::AnswerSystem.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(444, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(70, 35);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tlpHomeBack);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "答题系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Shown += new System.EventHandler(this.frmHome_Shown);
            this.tlpHomeBack.ResumeLayout(false);
            this.plBottom.ResumeLayout(false);
            this.pl_main_back.ResumeLayout(false);
            this.plTop.ResumeLayout(false);
            this.myPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHomeBack;
        private Cons.MyPanel plBottom;
        private Cons.MyPanel plTop;
        private Cons.MyPanel myPanel1;
        private Cons.MyPanel pl_main_back;
        private Cons.MyPanel myPanel3;
        private Cons.MyPanel myPanel4;
        private System.Windows.Forms.Label lblCopyright;
        private Cons.MyPanel plMain;
        private Cons.MyPictureBox pbExit;
        private System.Windows.Forms.Label label1;
        private Cons.MyPictureBox myPictureBox3;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentName;
    }
}