using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLine2XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ExceptionError = false; 
        private void ReadTextFile(string filename)
        {
            ExceptionError = false;
            dataGV.RowCount = 1;
            //StringBuilder sb = new StringBuilder();
            //"C:\test\1.txt"をShift-JISコードとして開く
            using (System.IO.StreamReader sr = new System.IO.StreamReader(
                filename,
                System.Text.Encoding.GetEncoding("shift_jis")))
            {
                while (sr.Peek() >= 0 && ExceptionError==false)
                {
                    //sb.Length = 0;
                    Analyze(sr.ReadLine());
                }
                AutoIdCreate();
            }
        }

        private void SaveTextFile(string filename)
        {
            using (System.IO.StreamWriter wr = new System.IO.StreamWriter(
                filename, false,
                System.Text.Encoding.GetEncoding("shift_jis")))
            {
                bool continueLoop=true;
                int gridIndex = 0; 
                while (continueLoop)
                {
                    wr.WriteLine(ExportText( ref continueLoop , ref gridIndex));
                }

            }

        }

        private string ExportText(int gridRowIndex)
        {
            int row = gridRowIndex;
            bool continueLoop = true;
            return ExportText(ref continueLoop, ref row);
        }

        private string ExportText(ref bool continueLoop, ref int gridIndex)
        {
            if(gridIndex> dataGV.RowCount - 2)
            {
                continueLoop = false;
                return "";
            }
            StringBuilder sb = new StringBuilder();
            DataGridViewRow oneRow = dataGV.Rows[gridIndex];
            foreach ( DataGridViewCell c in oneRow.Cells)
            {
                c.Value = c.Value ?? "";

                switch (c.ColumnIndex)
                {
                    case ID: break;
                    case COMMENT: sb.Append(c.Value.ToString()); break;
                    case SEC:sb.Append(c.Value.ToString()); break;
                    case TITLE:
                        if (oneRow.Cells[COMMENT].Value.ToString() != "")
                        {
                            sb.Append( c.Value.ToString().Substring(1)); 
                        }
                        else {
                            sb.Append('"' + c.Value.ToString() + '"'); 
                        }
                        break;
                    case DURATION: sb.Append(c.Value.ToString()); break;
                    case DURATION_SEC: sb.Append(c.Value.ToString()); break;
                    case SYNC: sb.Append(c.Value.ToString()); break;
                    case SYNC_TEXT:
                        if (oneRow.Cells[SYNC].Value.ToString() != "")
                        {
                            sb.Append('/' + c.Value.ToString() + "/");
                        }
                        break;
                    case WINDOW: sb.Append(c.Value.ToString()); break;
                    case WINDOW_VALUE:
                        if (oneRow.Cells[SYNC].Value.ToString() != "")
                        {
                            sb.Append(c.Value.ToString()); 
                        }
                        break;
                }
                if (c.Value.ToString() != "" && c.ColumnIndex!= COMMENT ) { sb.Append(' '); }
            }
            gridIndex++;
            return sb.ToString().Trim();
        }


        private void AutoIdCreate()
        {
            for(int i = 0; i<dataGV.RowCount-2;i++)
            {
                dataGV[ID, i].Value = (i + 1);
            }
            
        }

        //Grid col Index 
        const int ID = 0;
        const int COMMENT = 1;
        const int SEC = 2;
        const int TITLE = 3;
        const int DURATION = 4;
        const int DURATION_SEC = 5;
        const int SYNC = 6;
        const int SYNC_TEXT = 7;
        const int WINDOW = 8;
        const int WINDOW_VALUE = 9;

        //TimeLine Text 
        const int TEXT_SEC = 0;
        const int TEXT_TITLE = 1;
        const int TEXT_COL1 = 2;
        const int TEXT_COL2 = 4;
        const int TEXT_COL3 = 6;
        private StringBuilder sb = new StringBuilder();
        System.Collections.Generic.List<string> lineWork = new List<string>();
        int[] inTextCols = new int[] { TEXT_COL1, TEXT_COL2, TEXT_COL3 };

        private void Analyze(string s, int editRow = -1)
        {
            if (s == "") { return; }

            string[] linebuf = s.Split(' ');

            if(linebuf.Length == 0) { return; }

            if (linebuf[0].IndexOf("#") != -1)
            {
                int row;
                //コメント文
                if (editRow == -1)
                {
                    dataGV.Rows.Add();
                    row = dataGV.RowCount - 2;
                    //dataGV[COMMENT, row].Value = "#";//1行処理では値を変えない
                }
                else{
                    row = editRow;
                    //既にコメント文なので、処理を中断する
                    if(dataGV[COMMENT, row].Value.ToString() == "#"){return;}

                    dataGV[SYNC_TEXT, row].Value = "";
                    dataGV[DURATION_SEC, row].Value = "";
                    dataGV[WINDOW_VALUE, row].Value = "";
                }
                dataGV[DURATION, row].Value = "";
                dataGV[SYNC, row].Value = "";
                dataGV[WINDOW, row].Value = "";
                dataGV[TITLE, row].Value = s;
                return;
            }

            lineWork = new List<string>();
            bool isSync = false;
            sb.Length = 0;
            foreach (string str in linebuf)
            {
                if (isSync) {
                    if ((str.TrimEnd())[str.Length-1] == '/')
                    {
                        sb.Append(str);
                        lineWork.Add(sb.ToString().Replace("/",""));
                        isSync = false;
                    }else{
                        sb.Append(str);
                    }
                }
                else{
                    if (str.ToLower().IndexOf("sync") == -1)
                    {
                        lineWork.Add(str);
                    }
                    else{
                        lineWork.Add(str);
                        isSync = true;
                        sb.Length = 0;
                    }
                }
            }

            string[] line = lineWork.ToArray();
            if (line.Length == 0) { return; }
            try
            {
                int row;
                if (editRow == -1)
                {
                    dataGV.Rows.Add();
                    row = dataGV.RowCount - 2;
                }else
                {
                    row = editRow;
                }
                dataGV[SEC, row].Value = line[TEXT_SEC].Trim();
                dataGV[TITLE, row].Value = line[TEXT_TITLE].Trim(new char[] { '"' });

                dataGV[DURATION, row].Value = "";
                dataGV[SYNC, row].Value = "";
                dataGV[WINDOW, row].Value = "";

                if (line.Length > TEXT_COL1)
                {
                    int col = 0;
                    if (!SetGriddata(DURATION, DURATION_SEC, "duration", ref col, line, row)){return;}
                    if (!SetGriddata(SYNC, SYNC_TEXT, "sync", ref col, line, row)){return;}
                    if (!SetGriddata(WINDOW, WINDOW_VALUE, "window", ref col, line, row)){return;}
                }
            }
            catch (Exception e)
            {
                int row = dataGV.RowCount - 2;
                MessageBox.Show(e.ToString(), "Error:("+ row.ToString()+")", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExceptionError = true;
            }
        }
        private bool SetGriddata(int gridIndex , int gridIndexValue, string matchText ,ref int  col ,string[] line ,int row)
        {
            if (inTextCols[col] < line.Length)
            {
                if ( line[inTextCols[col]].Trim().ToLower() == matchText)
                {
                    dataGV[gridIndex, row].Value = matchText;
                    dataGV[gridIndexValue, row].Value = line[inTextCols[col] + 1].Trim();
                    col++;
                }
                return true;
            }else
            {
                return false;
            }
        }


        //Chenge  Grid
        private DataGridViewComboBoxEditingControl dataGridViewComboBox = null;
        private void dataGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "CommentOut")
                {
                    this.dataGridViewComboBox =
                        (DataGridViewComboBoxEditingControl)e.Control;
                    this.dataGridViewComboBox.SelectedIndexChanged +=
                        new EventHandler(dataGridViewComboBox_SelectedIndexChanged);
                }
            }
        }

        private void dataGridViewComboBox_SelectedIndexChanged(object sender,EventArgs e)
        {
            //選択されたアイテムを表示
            DataGridViewComboBoxEditingControl cb =(DataGridViewComboBoxEditingControl)sender;
            Point cellPositoin = ((System.Windows.Forms.DataGridView)cb.Parent.Parent).CurrentCellAddress;

            //2回飛んでこないようにハンドルを外す
            this.dataGridViewComboBox.SelectedIndexChanged -=
                                    new EventHandler(dataGridViewComboBox_SelectedIndexChanged);

            if (cb.Text == "#")
            {
                //コメントアウトにする
                if (dataGV[TITLE, cellPositoin.Y].Value.ToString()[0] != '#')
                {
                    Analyze("#" + ExportText(cellPositoin.Y), cellPositoin.Y);
                }
            }else
            {
                //コメントアウトを外す
                if (dataGV[TITLE, cellPositoin.Y].Value.ToString()[0] == '#')
                {
                    Analyze(dataGV[TITLE, cellPositoin.Y].Value.ToString().Substring(1), cellPositoin.Y);
                }
           }

            //元に戻す
            this.dataGridViewComboBox.SelectedIndexChanged +=
                                    new EventHandler(dataGridViewComboBox_SelectedIndexChanged);
        }

        //Panel Move Window
        private Point mousePoint;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;                
            }
        }

        private void LogForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (swResize)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            swResize = false;
        }

        bool swResize = false;
        private void btResize_Click(object sender, EventArgs e)
        {
            if (!swResize)
            {
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                swResize = true;
            }else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                swResize = false;
            }
        }

        

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }


        //Menu
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemOpenTimeLine_Click(object sender, EventArgs e)
        {
            if (openFLD.ShowDialog() == DialogResult.OK)
            {
                dataGV.RowCount = 1;
                ReadTextFile(openFLD.FileName);
            }
        }

        private void toolStripMenuItemSaveAsTimeLine_Click(object sender, EventArgs e)
        {
            if(saveFLD.ShowDialog() == DialogResult.OK)
            {
                SaveTextFile(saveFLD.FileName);
            }
        }

        private void ToolStripMenuItemSaveTimeLine_Click(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(saveFLD.FileName))
            {
                SaveTextFile(saveFLD.FileName);
                return;
            }else
            {
                if (System.IO.File.Exists(openFLD.FileName))
                {
                    SaveTextFile(saveFLD.FileName);
                    return;
                }
            }
            toolStripMenuItemSaveAsTimeLine_Click(sender,e);
        }


    }
}
