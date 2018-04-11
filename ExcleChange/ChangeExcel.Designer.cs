namespace ExcleChange
{
    partial class ChangeExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.butFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReturnPath = new System.Windows.Forms.TextBox();
            this.butReturnPath = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径：";
            // 
            // butFile
            // 
            this.butFile.Location = new System.Drawing.Point(359, 70);
            this.butFile.Name = "butFile";
            this.butFile.Size = new System.Drawing.Size(75, 23);
            this.butFile.TabIndex = 1;
            this.butFile.Text = "选择文件";
            this.butFile.UseVisualStyleBackColor = true;
            this.butFile.Click += new System.EventHandler(this.butFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(125, 72);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(228, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "导出路径：";
            // 
            // txtReturnPath
            // 
            this.txtReturnPath.Location = new System.Drawing.Point(125, 166);
            this.txtReturnPath.Name = "txtReturnPath";
            this.txtReturnPath.Size = new System.Drawing.Size(228, 21);
            this.txtReturnPath.TabIndex = 4;
            // 
            // butReturnPath
            // 
            this.butReturnPath.Location = new System.Drawing.Point(359, 164);
            this.butReturnPath.Name = "butReturnPath";
            this.butReturnPath.Size = new System.Drawing.Size(75, 23);
            this.butReturnPath.TabIndex = 5;
            this.butReturnPath.Text = "选择文件夹";
            this.butReturnPath.UseVisualStyleBackColor = true;
            this.butReturnPath.Click += new System.EventHandler(this.butReturnPath_Click);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(125, 257);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(228, 23);
            this.butChange.TabIndex = 6;
            this.butChange.Text = "转换";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // ChangeExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 319);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butReturnPath);
            this.Controls.Add(this.txtReturnPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.butFile);
            this.Controls.Add(this.label1);
            this.Name = "ChangeExcel";
            this.Text = "Excel内容格式转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturnPath;
        private System.Windows.Forms.Button butReturnPath;
        private System.Windows.Forms.Button butChange;
    }
}