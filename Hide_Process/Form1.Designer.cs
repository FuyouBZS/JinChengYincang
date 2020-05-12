namespace Hide_Process
{
    partial class Form1
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

        #region Windows Form 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.processListView = new System.Windows.Forms.ListView();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(3, 4);
            this.processListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(422, 416);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(431, 4);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(121, 206);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "隐藏";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(431, 214);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 206);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "显示";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 426);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.processListView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
    }
}

