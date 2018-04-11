using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcleChange;
using System.IO;

namespace ExcleChange
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
            //dataGridViewReturn.Width=this.Width-10;
            comboBoxCardNum.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        // public Form changeExcel = new ChangeExcel();
        public ChangeExcel changeExcel = new ChangeExcel();
        private void butChange_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Trim() != "")
            {
                // C:\Users\yf-04\Documents\Tencent Files\2351592225\FileRecv\郑西库.xls
                // changeExcel.CE.Import(@"C:\Users\yf-04\Documents\Tencent Files\2351592225\FileRecv\郑西库.xls");
                DataTable dt = new DataTable();
                dt = changeExcel.Import(txtFilePath.Text);
                dataGridViewReturn.DataSource = dt;
                //MessageBox.Show(dt.Columns[0].Caption);//获取列的标题
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    comboBoxCardNum.Items.Add(dt.Columns[i].Caption);
                }
                //MessageBox.Show(dt.Rows[14][4].ToString().Replace("\\", "-")
                //    + "\n" + dt.Rows[2][dt.Columns.Count - 1].ToString().Substring(0, dt.Rows[2][dt.Columns.Count - 1].ToString().Length - 3).Replace("/", "-"));

                //dataGridViewReturn
            }
            else
                MessageBox.Show("请先选择文件");

        }

        private void dataGridViewReturn_Resize(object sender, EventArgs e)
        {

        }

        private void ExcelForm_Resize(object sender, EventArgs e)
        {
            //dataGridViewReturn.Size = new Size(this.Width-10, this.Height-10);
        }

        private void butChengeExcel_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.ToString().Trim() == "")
            { MessageBox.Show("请选择文件！"); }
            else
            {
                dataGridViewReturn.DataBindings.Clear();
                DataTable dta = new DataTable();
                dta = changeExcel.Import(txtFilePath.Text);
                //switch (comboBoxCardNum.SelectedText.Trim())
                //{
                //    case dta.Columns
                //}
                int j = 0;
                for (int i = 0; i < dta.Columns.Count; i++)
                {
                    if (comboBoxCardNum.SelectedItem.ToString() == dta.Columns[i].Caption)
                        j = i;
                }
                for (int x = 0; x < dta.Rows.Count; x++)
                {
                    if (dta.Rows[x][3].ToString() != "")
                    {
                        dta.Rows[x][3] = changeExcel.ExcelChenge(dta.Rows[x][3].ToString().Trim());
                    }
                }
                dataGridViewReturn.DataSource = dta;
                //if (txtReturnPath.Text.Trim() != "")
                ReName(dta); 
            }
        }

        //选择文件夹
        public void OptionPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtReturnPath.Text = foldPath;
                MessageBox.Show("已选择文件夹：" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //打开文件夹
        public void OptionOpen()
        {
            System.Diagnostics.Process.Start("应用程序.exe", "文件路径（c:\\windows）");
        }
        private void butFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择Excel文件";
            fileDialog.Filter = "Excel文件(*.xls)|*.xls";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                txtFilePath.Text = file;
                MessageBox.Show("已选择文件：" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butReturnPath_Click(object sender, EventArgs e)
        {
            OptionPath();
        }
        //重命名
        public void ReName(DataTable dt)
        {
            //FileStream fileStream = new FileStream(txtFilePath.Text, FileMode.Open);
            //string filName = fileStream.Name.Substring(fileStream.Name.LastIndexOf("\\") + 1, fileStream.Name.LastIndexOf(".") - fileStream.Name.LastIndexOf("\\") - 1);//获取不包含扩展名的文件名
            string filName = txtFilePath.Text.Substring(txtFilePath.Text.LastIndexOf("\\") + 1,txtFilePath.Text.LastIndexOf(".")-txtFilePath.Text.LastIndexOf("\\")-1);
            //changeExcel.dataTableToCsv(dt, txtReturnPath.Text + "\\" + filName + DateTime.Now.ToString("yyyy-mm-dd") + ".xls");
            //System.Diagnostics.Process.Start(txtReturnPath.Text + "\\" + filName + DateTime.Now.ToString("yyyy-mm-dd") + ".xls"); //打开excel文件
            changeExcel.dataTableToCsv(dt, txtReturnPath.Text + "\\" + filName + DateTime.Now.ToString("hh-mm-ss") + ".xls");
        }
        public Form1 form1 = new Form1();
        private void butChangeTwo_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturn.RowCount > 0)
            {
                dataGridViewReturn.DataBindings.Clear();
                DataTable dta = new DataTable();
                dta = changeExcel.Import(txtFilePath.Text);
                //switch (comboBoxCardNum.SelectedText.Trim())
                //{
                //    case dta.Columns
                //}
                int j = 0;
                for (int i = 0; i < dta.Columns.Count; i++)
                {
                    if (comboBoxCardNum.SelectedItem.ToString() == dta.Columns[i].Caption)
                        j = i;
                }
                for (int x = 0; x < dta.Rows.Count; x++)
                {
                    if (dta.Rows[x][j].ToString() != "")
                    {
                        //dta.Rows[x][j] = changeExcel.ExcelChenge(dta.Rows[x][3].ToString().Trim());

                        //int i = 0;

                        int Num = 0;
                        if (form1.ChangeStr(dta.Rows[x][j].ToString()) <= 6)
                            Num = form1.ChangeStr(dta.Rows[x][j].ToString());
                        else
                            Num = 6;
                        string strCardOne = System.Text.RegularExpressions.Regex.Replace(dta.Rows[x][j].ToString(), "0{" + Num + "}$", "");//去掉字符串后面所有的0
                        dta.Rows[x][j] = form1.CardInSite(strCardOne);

                    }
                }
                dataGridViewReturn.DataSource = dta;
                ReName(dta);
            }
            else
                MessageBox.Show("请先加载！");
        }

        private void butChangeTwo_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.butChangeTwo, "现场读卡卡号转成克立司帝卡号格式");
        }

        private void ExcelForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            MessageBox.Show(time.ToString("yyyy-mm-dd hh:mm:ss"));
        }
    }
}
