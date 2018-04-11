using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ICSharpCode.SharpZipLib;
using Microsoft.Office.Interop.Excel;

namespace ExcleChange
{
    public partial class ChangeExcel : Form
    {
        public static ChangeExcel CE = null;
        public ChangeExcel()
        {
            InitializeComponent();
            CE = this;
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

        private void butReturnPath_Click(object sender, EventArgs e)
        {
            OptionPath();
        }
        //转换
        public string ExcelChenge(string NumCard)
        {
            uint OldCard = uint.Parse(NumCard.Trim());
            uint eOldCard = OldCard % 100000;
            uint sOldCard = OldCard / 100000;
            byte[] send_byte = new byte[4];
            send_byte[3] = (byte)sOldCard;
            send_byte[0] = (byte)(eOldCard);
            send_byte[1] = (byte)(eOldCard >> 8);
            send_byte[2] = (byte)(eOldCard >> 16);
            int NewCard = 0;
            int x = 0;
            for (int j = 0; j < send_byte.Length; j++)
            {
                if (send_byte[j] == 0)
                {
                    x = j;
                }
                else
                {
                    NewCard = NewCard + (send_byte[j] << (x * 8));
                    x++;
                }
            }
            return NewCard.ToString();
        }
        private void butChange_Click(object sender, EventArgs e)
        {
          
            System.Data.DataTable dt = Import(txtFilePath.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][3].ToString() != "")
                {
                    dt.Rows[i][3] = ExcelChenge(dt.Rows[i][3].ToString().Trim());
                }
            }
           
            FileStream fileStream = new FileStream(txtFilePath.Text, FileMode.Open);
            string filName = fileStream.Name.Substring(fileStream.Name.LastIndexOf("\\") + 1, fileStream.Name.LastIndexOf(".") - fileStream.Name.LastIndexOf("\\") - 1);//获取不包含扩展名的文件名
            //dataTableToCsv(dt, @"d:\2.xls"); //调用函数
            dataTableToCsv(dt, txtReturnPath.Text + "\\" + filName + DateTime.Now.ToString("yyyy-mm-dd") + ".xls");
            System.Diagnostics.Process.Start(txtReturnPath.Text + "\\" + filName + DateTime.Now.ToString("yyyy-mm-dd") + ".xls"); //打开excel文件
        }
        public enum HSSFCellType
        {
            Unknown = -1,
            NUMERIC = 0,
            STRING = 1,
            FORMULA = 2,
            BLANK = 3,
            BOOLEAN = 4,
            ERROR = 5,
        }

        //导入Excel
        public System.Data.DataTable Import(string strFileName)
       {
            bool hasTitle = true;
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Sheets sheets;
            object oMissiong = System.Reflection.Missing.Value;
            Workbook workbook = null;
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                if (app == null) return null;
                workbook = app.Workbooks.Open(strFileName, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;

                //将数据读入到DataTable中
                Worksheet worksheet = (Worksheet)sheets.get_Item(1);//读取第一张表  
                if (worksheet == null) return null;

                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                //生成列头
                for (int i = 0; i < iColCount; i++)
                {
                    var name = "column" + i;
                    if (hasTitle)
                    {
                        var txt = ((Range)worksheet.Cells[1, i + 1]).Text.ToString();
                        if (!string.IsNullOrEmpty(txt)) name = txt;
                    }
                    while (dt.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
                    dt.Columns.Add(new DataColumn(name, typeof(string)));
                }
                //生成行数据
                Range range;
                int rowIdx = hasTitle ? 2 : 1;
                for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dt.NewRow();
                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                        range = (Range)worksheet.Cells[iRow, iCol];
                        dr[iCol - 1] = (range.Value2 == null) ? "" : range.Text.ToString();
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch { return null; }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }
        }
        //导出Excel
        public void dataTableToCsv(System.Data.DataTable table, string file)

        {

            string title = "";

            FileStream fs = new FileStream(file, FileMode.OpenOrCreate);

            //FileStream fs1 = File.Open(file, FileMode.Open, FileAccess.Read);

            StreamWriter sw = new StreamWriter(new BufferedStream(fs), System.Text.Encoding.Default);

            for (int i = 0; i < table.Columns.Count; i++)

            {

                title += table.Columns[i].ColumnName + "\t"; //栏位：自动跳到下一单元格

            }

            title = title.Substring(0, title.Length - 1) + "\n";

            sw.Write(title);

            foreach (DataRow row in table.Rows)

            {

                string line = "";

                for (int i = 0; i < table.Columns.Count; i++)

                {

                    line += row[i].ToString().Trim() + "\t"; //内容：自动跳到下一单元格

                }

                line = line.Substring(0, line.Length - 1) + "\n";

                sw.Write(line);

            }

            sw.Close();

            fs.Close();

        }

    }
}
