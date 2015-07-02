namespace zhaopianzhengli
{
    partial class zhaopianzhengli
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zhaopianzhengli));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_qian = new System.Windows.Forms.Button();
            this.txt_qian = new System.Windows.Forms.TextBox();
            this.txt_hou = new System.Windows.Forms.TextBox();
            this.btn_hou = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.fbd_qian = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_hou = new System.Windows.Forms.FolderBrowserDialog();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.btn_quxiao = new System.Windows.Forms.Button();
            this.lbl_log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择需要整理的文件夹:";
            // 
            // btn_qian
            // 
            this.btn_qian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_qian.Location = new System.Drawing.Point(434, 41);
            this.btn_qian.Name = "btn_qian";
            this.btn_qian.Size = new System.Drawing.Size(75, 23);
            this.btn_qian.TabIndex = 1;
            this.btn_qian.Text = "选择";
            this.btn_qian.UseVisualStyleBackColor = true;
            this.btn_qian.Click += new System.EventHandler(this.btn_qian_Click);
            // 
            // txt_qian
            // 
            this.txt_qian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qian.Location = new System.Drawing.Point(16, 43);
            this.txt_qian.Name = "txt_qian";
            this.txt_qian.ReadOnly = true;
            this.txt_qian.Size = new System.Drawing.Size(412, 21);
            this.txt_qian.TabIndex = 2;
            // 
            // txt_hou
            // 
            this.txt_hou.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hou.Location = new System.Drawing.Point(16, 86);
            this.txt_hou.Name = "txt_hou";
            this.txt_hou.ReadOnly = true;
            this.txt_hou.Size = new System.Drawing.Size(412, 21);
            this.txt_hou.TabIndex = 5;
            // 
            // btn_hou
            // 
            this.btn_hou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hou.Location = new System.Drawing.Point(434, 84);
            this.btn_hou.Name = "btn_hou";
            this.btn_hou.Size = new System.Drawing.Size(75, 23);
            this.btn_hou.TabIndex = 4;
            this.btn_hou.Text = "选择";
            this.btn_hou.UseVisualStyleBackColor = true;
            this.btn_hou.Click += new System.EventHandler(this.btn_hou_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择保存整理后照片的文件夹:";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(434, 129);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Location = new System.Drawing.Point(16, 190);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(493, 186);
            this.rtb.TabIndex = 7;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl.Location = new System.Drawing.Point(16, 175);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(493, 12);
            this.lbl.TabIndex = 8;
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // btn_quxiao
            // 
            this.btn_quxiao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quxiao.Enabled = false;
            this.btn_quxiao.Location = new System.Drawing.Point(353, 129);
            this.btn_quxiao.Name = "btn_quxiao";
            this.btn_quxiao.Size = new System.Drawing.Size(75, 23);
            this.btn_quxiao.TabIndex = 9;
            this.btn_quxiao.Text = "取消";
            this.btn_quxiao.UseVisualStyleBackColor = true;
            this.btn_quxiao.Click += new System.EventHandler(this.btn_quxiao_Click);
            // 
            // lbl_log
            // 
            this.lbl_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_log.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_log.Location = new System.Drawing.Point(16, 159);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(493, 12);
            this.lbl_log.TabIndex = 10;
            // 
            // zhaopianzhengli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 388);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.btn_quxiao);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_hou);
            this.Controls.Add(this.btn_hou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_qian);
            this.Controls.Add(this.btn_qian);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "zhaopianzhengli";
            this.Text = "照片整理";
            this.Load += new System.EventHandler(this.zhaopianzhengli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_qian;
        private System.Windows.Forms.TextBox txt_qian;
        private System.Windows.Forms.TextBox txt_hou;
        private System.Windows.Forms.Button btn_hou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.FolderBrowserDialog fbd_qian;
        private System.Windows.Forms.FolderBrowserDialog fbd_hou;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label lbl;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Button btn_quxiao;
        private System.Windows.Forms.Label lbl_log;
    }
}

