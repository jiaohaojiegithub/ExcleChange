namespace ExcleChange
{
    partial class ExcelForm
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
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.butChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCardNum = new System.Windows.Forms.ComboBox();
            this.butChengeExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtReturnPath = new System.Windows.Forms.TextBox();
            this.butFile = new System.Windows.Forms.Button();
            this.butReturnPath = new System.Windows.Forms.Button();
            this.butChangeTwo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.RowTemplate.Height = 23;
            this.dataGridViewReturn.Size = new System.Drawing.Size(766, 414);
            this.dataGridViewReturn.TabIndex = 0;
            this.dataGridViewReturn.Resize += new System.EventHandler(this.dataGridViewReturn_Resize);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(486, 177);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 1;
            this.butChange.Text = "加载";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择更改的卡号列：";
            // 
            // comboBoxCardNum
            // 
            this.comboBoxCardNum.FormattingEnabled = true;
            this.comboBoxCardNum.Location = new System.Drawing.Point(131, 179);
            this.comboBoxCardNum.Name = "comboBoxCardNum";
            this.comboBoxCardNum.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCardNum.TabIndex = 3;
            // 
            // butChengeExcel
            // 
            this.butChengeExcel.Location = new System.Drawing.Point(671, 35);
            this.butChengeExcel.Name = "butChengeExcel";
            this.butChengeExcel.Size = new System.Drawing.Size(75, 23);
            this.butChengeExcel.TabIndex = 4;
            this.butChengeExcel.Text = "转换";
            this.butChengeExcel.UseVisualStyleBackColor = true;
            this.butChengeExcel.Click += new System.EventHandler(this.butChengeExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "导出路径：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(131, 37);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(319, 21);
            this.txtFilePath.TabIndex = 7;
            // 
            // txtReturnPath
            // 
            this.txtReturnPath.Location = new System.Drawing.Point(131, 107);
            this.txtReturnPath.Name = "txtReturnPath";
            this.txtReturnPath.Size = new System.Drawing.Size(319, 21);
            this.txtReturnPath.TabIndex = 8;
            // 
            // butFile
            // 
            this.butFile.Location = new System.Drawing.Point(486, 35);
            this.butFile.Name = "butFile";
            this.butFile.Size = new System.Drawing.Size(75, 23);
            this.butFile.TabIndex = 9;
            this.butFile.Text = "选择文件";
            this.butFile.UseVisualStyleBackColor = true;
            this.butFile.Click += new System.EventHandler(this.butFile_Click);
            // 
            // butReturnPath
            // 
            this.butReturnPath.Location = new System.Drawing.Point(486, 105);
            this.butReturnPath.Name = "butReturnPath";
            this.butReturnPath.Size = new System.Drawing.Size(75, 23);
            this.butReturnPath.TabIndex = 10;
            this.butReturnPath.Text = "选择文件夹";
            this.butReturnPath.UseVisualStyleBackColor = true;
            this.butReturnPath.Click += new System.EventHandler(this.butReturnPath_Click);
            // 
            // butChangeTwo
            // 
            this.butChangeTwo.Location = new System.Drawing.Point(671, 98);
            this.butChangeTwo.Name = "butChangeTwo";
            this.butChangeTwo.Size = new System.Drawing.Size(75, 23);
            this.butChangeTwo.TabIndex = 11;
            this.butChangeTwo.Text = "转换格式二";
            this.butChangeTwo.UseVisualStyleBackColor = true;
            this.butChangeTwo.Click += new System.EventHandler(this.butChangeTwo_Click);
            this.butChangeTwo.MouseEnter += new System.EventHandler(this.butChangeTwo_MouseEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butChangeTwo);
            this.Controls.Add(this.butReturnPath);
            this.Controls.Add(this.butFile);
            this.Controls.Add(this.txtReturnPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butChengeExcel);
            this.Controls.Add(this.comboBoxCardNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.dataGridViewReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExcelForm";
            this.Text = "Excel规则转换";
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            this.Resize += new System.EventHandler(this.ExcelForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCardNum;
        private System.Windows.Forms.Button butChengeExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtReturnPath;
        private System.Windows.Forms.Button butFile;
        private System.Windows.Forms.Button butReturnPath;
        private System.Windows.Forms.Button butChangeTwo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}