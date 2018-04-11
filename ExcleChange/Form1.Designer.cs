namespace ExcleChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.butChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardInSite = new System.Windows.Forms.TextBox();
            this.butChangeInSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "现卡号：";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(142, 56);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(139, 21);
            this.txtOld.TabIndex = 2;
            this.txtOld.Enter += new System.EventHandler(this.txtOld_Enter);
            // 
            // txtNew
            // 
            this.txtNew.Enabled = false;
            this.txtNew.Location = new System.Drawing.Point(142, 127);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(139, 21);
            this.txtNew.TabIndex = 3;
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(47, 261);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(94, 23);
            this.butChange.TabIndex = 4;
            this.butChange.Text = "卡号转换";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "现场卡号：";
            // 
            // txtCardInSite
            // 
            this.txtCardInSite.Location = new System.Drawing.Point(142, 196);
            this.txtCardInSite.Name = "txtCardInSite";
            this.txtCardInSite.Size = new System.Drawing.Size(139, 21);
            this.txtCardInSite.TabIndex = 6;
            this.txtCardInSite.Enter += new System.EventHandler(this.txtCardInSite_Enter);
            // 
            // butChangeInSite
            // 
            this.butChangeInSite.Location = new System.Drawing.Point(190, 261);
            this.butChangeInSite.Name = "butChangeInSite";
            this.butChangeInSite.Size = new System.Drawing.Size(91, 23);
            this.butChangeInSite.TabIndex = 7;
            this.butChangeInSite.Text = "现场卡号转换";
            this.butChangeInSite.UseVisualStyleBackColor = true;
            this.butChangeInSite.Click += new System.EventHandler(this.butChangeInSite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.butChangeInSite);
            this.Controls.Add(this.txtCardInSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "数据转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardInSite;
        private System.Windows.Forms.Button butChangeInSite;
    }
}

