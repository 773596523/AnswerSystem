namespace AnswerSystem.Forms
{
    partial class UC_SelectSubject
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.plSubjectNet = new AnswerSystem.Cons.MyPanel();
            this.btnSubjectNet = new AnswerSystem.Cons.MyPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plSubjectJava = new AnswerSystem.Cons.MyPanel();
            this.btnSubjectJava = new AnswerSystem.Cons.MyPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.plSubjectNet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjectNet)).BeginInit();
            this.plSubjectJava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjectJava)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpMain.Controls.Add(this.plSubjectNet, 1, 1);
            this.tlpMain.Controls.Add(this.plSubjectJava, 3, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(953, 598);
            this.tlpMain.TabIndex = 0;
            // 
            // plSubjectNet
            // 
            this.plSubjectNet.BackgroundImage = global::AnswerSystem.Properties.Resources.Ribbon;
            this.plSubjectNet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plSubjectNet.Content = null;
            this.plSubjectNet.Controls.Add(this.btnSubjectNet);
            this.plSubjectNet.Controls.Add(this.label1);
            this.plSubjectNet.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.plSubjectNet.ForeColor = System.Drawing.Color.White;
            this.plSubjectNet.Location = new System.Drawing.Point(17, 145);
            this.plSubjectNet.Margin = new System.Windows.Forms.Padding(0);
            this.plSubjectNet.Name = "plSubjectNet";
            this.plSubjectNet.Size = new System.Drawing.Size(457, 308);
            this.plSubjectNet.TabIndex = 0;
            // 
            // btnSubjectNet
            // 
            this.btnSubjectNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectNet.Image = global::AnswerSystem.Properties.Resources.Get_It_Now_Button;
            this.btnSubjectNet.Location = new System.Drawing.Point(121, 208);
            this.btnSubjectNet.Name = "btnSubjectNet";
            this.btnSubjectNet.Size = new System.Drawing.Size(212, 56);
            this.btnSubjectNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubjectNet.TabIndex = 1;
            this.btnSubjectNet.TabStop = false;
            this.btnSubjectNet.Click += new System.EventHandler(this.btnSubjectNet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 50.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = ".Net试题";
            // 
            // plSubjectJava
            // 
            this.plSubjectJava.BackgroundImage = global::AnswerSystem.Properties.Resources.Ribbon;
            this.plSubjectJava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plSubjectJava.Content = null;
            this.plSubjectJava.Controls.Add(this.btnSubjectJava);
            this.plSubjectJava.Controls.Add(this.label2);
            this.plSubjectJava.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.plSubjectJava.ForeColor = System.Drawing.Color.White;
            this.plSubjectJava.Location = new System.Drawing.Point(477, 145);
            this.plSubjectJava.Margin = new System.Windows.Forms.Padding(0);
            this.plSubjectJava.Name = "plSubjectJava";
            this.plSubjectJava.Size = new System.Drawing.Size(457, 308);
            this.plSubjectJava.TabIndex = 1;
            // 
            // btnSubjectJava
            // 
            this.btnSubjectJava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectJava.Image = global::AnswerSystem.Properties.Resources.Get_It_Now_Button;
            this.btnSubjectJava.Location = new System.Drawing.Point(125, 208);
            this.btnSubjectJava.Name = "btnSubjectJava";
            this.btnSubjectJava.Size = new System.Drawing.Size(212, 56);
            this.btnSubjectJava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubjectJava.TabIndex = 2;
            this.btnSubjectJava.TabStop = false;
            this.btnSubjectJava.Click += new System.EventHandler(this.btnSubjectJava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 50.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Java试题";
            // 
            // UC_SelectSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.Name = "UC_SelectSubject";
            this.Size = new System.Drawing.Size(953, 598);
            this.tlpMain.ResumeLayout(false);
            this.plSubjectNet.ResumeLayout(false);
            this.plSubjectNet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjectNet)).EndInit();
            this.plSubjectJava.ResumeLayout(false);
            this.plSubjectJava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjectJava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Cons.MyPanel plSubjectNet;
        private Cons.MyPanel plSubjectJava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Cons.MyPictureBox btnSubjectNet;
        private Cons.MyPictureBox btnSubjectJava;
    }
}
