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
            this.txtRARFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnRAR = new System.Windows.Forms.Button();
            this.txtRARName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRAR = new System.Windows.Forms.Button();
            this.btnUnRARAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRARFolder
            // 
            this.txtRARFolder.Location = new System.Drawing.Point(147, 79);
            this.txtRARFolder.Name = "txtRARFolder";
            this.txtRARFolder.Size = new System.Drawing.Size(369, 21);
            this.txtRARFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "压缩包文件夹路径";
            // 
            // txtFileFolder
            // 
            this.txtFileFolder.Location = new System.Drawing.Point(147, 108);
            this.txtFileFolder.Name = "txtFileFolder";
            this.txtFileFolder.Size = new System.Drawing.Size(369, 21);
            this.txtFileFolder.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "压缩文件夹路径";
            // 
            // btnUnRAR
            // 
            this.btnUnRAR.Location = new System.Drawing.Point(73, 177);
            this.btnUnRAR.Name = "btnUnRAR";
            this.btnUnRAR.Size = new System.Drawing.Size(75, 23);
            this.btnUnRAR.TabIndex = 2;
            this.btnUnRAR.Text = "解压缩";
            this.btnUnRAR.UseVisualStyleBackColor = true;
            this.btnUnRAR.Click += new System.EventHandler(this.btnUnRAR_Click);
            // 
            // txtRARName
            // 
            this.txtRARName.Location = new System.Drawing.Point(147, 135);
            this.txtRARName.Name = "txtRARName";
            this.txtRARName.Size = new System.Drawing.Size(369, 21);
            this.txtRARName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "解压包名";
            // 
            // btnRAR
            // 
            this.btnRAR.Location = new System.Drawing.Point(177, 177);
            this.btnRAR.Name = "btnRAR";
            this.btnRAR.Size = new System.Drawing.Size(75, 23);
            this.btnRAR.TabIndex = 4;
            this.btnRAR.Text = "压缩";
            this.btnRAR.UseVisualStyleBackColor = true;
            this.btnRAR.Click += new System.EventHandler(this.btnRAR_Click);
            // 
            // btnUnRARAsync
            // 
            this.btnUnRARAsync.Location = new System.Drawing.Point(285, 177);
            this.btnUnRARAsync.Name = "btnUnRARAsync";
            this.btnUnRARAsync.Size = new System.Drawing.Size(75, 23);
            this.btnUnRARAsync.TabIndex = 4;
            this.btnUnRARAsync.Text = "异步压缩";
            this.btnUnRARAsync.UseVisualStyleBackColor = true;
            this.btnUnRARAsync.Click += new System.EventHandler(this.btnUnRARAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnRARAsync);
            this.Controls.Add(this.btnRAR);
            this.Controls.Add(this.txtRARName);
            this.Controls.Add(this.btnUnRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRARFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRARFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnRAR;
        private System.Windows.Forms.TextBox txtRARName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRAR;
        private System.Windows.Forms.Button btnUnRARAsync;
    }
}

