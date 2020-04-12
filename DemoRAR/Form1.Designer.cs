namespace DemoRAR
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRARFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnRARFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnRAR = new System.Windows.Forms.Button();
            this.txtRARFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRARFilePath
            // 
            this.txtRARFilePath.Location = new System.Drawing.Point(294, 158);
            this.txtRARFilePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRARFilePath.Name = "txtRARFilePath";
            this.txtRARFilePath.Size = new System.Drawing.Size(734, 35);
            this.txtRARFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "压缩包路径";
            // 
            // txtUnRARFolder
            // 
            this.txtUnRARFolder.Location = new System.Drawing.Point(294, 216);
            this.txtUnRARFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUnRARFolder.Name = "txtUnRARFolder";
            this.txtUnRARFolder.Size = new System.Drawing.Size(734, 35);
            this.txtUnRARFolder.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "解压缩文件夹路径";
            // 
            // btnUnRAR
            // 
            this.btnUnRAR.Location = new System.Drawing.Point(146, 354);
            this.btnUnRAR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUnRAR.Name = "btnUnRAR";
            this.btnUnRAR.Size = new System.Drawing.Size(150, 46);
            this.btnUnRAR.TabIndex = 2;
            this.btnUnRAR.Text = "解压缩";
            this.btnUnRAR.UseVisualStyleBackColor = true;
            this.btnUnRAR.Click += new System.EventHandler(this.btnUnRAR_Click);
            // 
            // txtRARFileName
            // 
            this.txtRARFileName.Location = new System.Drawing.Point(294, 270);
            this.txtRARFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRARFileName.Name = "txtRARFileName";
            this.txtRARFileName.Size = new System.Drawing.Size(734, 35);
            this.txtRARFileName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "解压包名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.txtRARFileName);
            this.Controls.Add(this.btnUnRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnRARFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRARFilePath);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRARFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnRARFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnRAR;
        private System.Windows.Forms.TextBox txtRARFileName;
        private System.Windows.Forms.Label label3;
    }
}

