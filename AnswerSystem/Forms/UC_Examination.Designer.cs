namespace AnswerSystem.Forms
{
    partial class UC_Examination
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
            this.components = new System.ComponentModel.Container();
            this.tmAutoSave = new System.Windows.Forms.Timer(this.components);
            this.myPanel2 = new AnswerSystem.Cons.MyPanel();
            this.myPanel4 = new AnswerSystem.Cons.MyPanel();
            this.txtAnswer = new AnswerSystem.Cons.MyRichTextBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.myPanel3 = new AnswerSystem.Cons.MyPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new AnswerSystem.Cons.MyPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new AnswerSystem.Cons.MyPictureBox();
            this.btnUpload = new AnswerSystem.Cons.MyPictureBox();
            this.btnPrev = new AnswerSystem.Cons.MyPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.myPanel1 = new AnswerSystem.Cons.MyPanel();
            this.plAnswer = new AnswerSystem.Cons.MyPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myPanel2.SuspendLayout();
            this.myPanel4.SuspendLayout();
            this.myPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).BeginInit();
            this.myPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmAutoSave
            // 
            this.tmAutoSave.Enabled = true;
            this.tmAutoSave.Interval = 10000;
            this.tmAutoSave.Tick += new System.EventHandler(this.tmAutoSave_Tick);
            // 
            // myPanel2
            // 
            this.myPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.myPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPanel2.Content = null;
            this.myPanel2.Controls.Add(this.myPanel4);
            this.myPanel2.Controls.Add(this.lblProblem);
            this.myPanel2.Controls.Add(this.myPanel3);
            this.myPanel2.Controls.Add(this.lblTitle);
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel2.Location = new System.Drawing.Point(227, 0);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(774, 674);
            this.myPanel2.TabIndex = 1;
            // 
            // myPanel4
            // 
            this.myPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.myPanel4.Content = null;
            this.myPanel4.Controls.Add(this.txtAnswer);
            this.myPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel4.Location = new System.Drawing.Point(0, 92);
            this.myPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel4.Name = "myPanel4";
            this.myPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.myPanel4.Size = new System.Drawing.Size(772, 530);
            this.myPanel4.TabIndex = 6;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswer.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(10, 10);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(752, 510);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.Text = "作答区";
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.lblProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProblem.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblProblem.Location = new System.Drawing.Point(0, 58);
            this.lblProblem.MaximumSize = new System.Drawing.Size(774, 0);
            this.lblProblem.MinimumSize = new System.Drawing.Size(774, 0);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblProblem.Size = new System.Drawing.Size(774, 34);
            this.lblProblem.TabIndex = 4;
            this.lblProblem.Text = "题目";
            // 
            // myPanel3
            // 
            this.myPanel3.Content = null;
            this.myPanel3.Controls.Add(this.tableLayoutPanel1);
            this.myPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myPanel3.Location = new System.Drawing.Point(0, 622);
            this.myPanel3.Name = "myPanel3";
            this.myPanel3.Size = new System.Drawing.Size(772, 50);
            this.myPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpload, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::AnswerSystem.Properties.Resources.Next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(673, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "*10s自动保存，Ctrl+S手动保存,PageUp上一题，PageDown下一题";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::AnswerSystem.Properties.Resources._return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Location = new System.Drawing.Point(389, 5);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 37);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackgroundImage = global::AnswerSystem.Properties.Resources.upload;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Location = new System.Drawing.Point(480, 5);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(85, 37);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.TabStop = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = global::AnswerSystem.Properties.Resources.Prev;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Location = new System.Drawing.Point(571, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(96, 37);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TabStop = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(772, 58);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "试题";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myPanel1
            // 
            this.myPanel1.AutoScroll = true;
            this.myPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPanel1.Content = null;
            this.myPanel1.Controls.Add(this.plAnswer);
            this.myPanel1.Controls.Add(this.label1);
            this.myPanel1.Controls.Add(this.label3);
            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(227, 674);
            this.myPanel1.TabIndex = 0;
            // 
            // plAnswer
            // 
            this.plAnswer.AutoScroll = true;
            this.plAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.plAnswer.Content = null;
            this.plAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAnswer.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.plAnswer.ForeColor = System.Drawing.Color.White;
            this.plAnswer.Location = new System.Drawing.Point(0, 57);
            this.plAnswer.Name = "plAnswer";
            this.plAnswer.Size = new System.Drawing.Size(225, 591);
            this.plAnswer.TabIndex = 2;
            this.plAnswer.Paint += new System.Windows.Forms.PaintEventHandler(this.plAnswer_Paint);
            this.plAnswer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plAnswer_MouseDown);
            this.plAnswer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plAnswer_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "全部题目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(154)))), ((int)(((byte)(207)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(0, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "*绿色为已完成题目、红色为当前题目";
            // 
            // UC_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.myPanel2);
            this.Controls.Add(this.myPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Examination";
            this.Size = new System.Drawing.Size(1001, 674);
            this.Resize += new System.EventHandler(this.UC_Examination_Resize);
            this.myPanel2.ResumeLayout(false);
            this.myPanel2.PerformLayout();
            this.myPanel4.ResumeLayout(false);
            this.myPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).EndInit();
            this.myPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Cons.MyPanel myPanel1;
        private Cons.MyPanel myPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Cons.MyPanel plAnswer;
        private Cons.MyPanel myPanel3;
        private System.Windows.Forms.Label lblProblem;
        private Cons.MyRichTextBox txtAnswer;
        private Cons.MyPanel myPanel4;
        private System.Windows.Forms.Label label3;
        private Cons.MyPictureBox btnNext;
        private Cons.MyPictureBox btnPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmAutoSave;
        private Cons.MyPictureBox btnReturn;
        private Cons.MyPictureBox btnUpload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
