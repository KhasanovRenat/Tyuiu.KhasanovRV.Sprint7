using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhasanovRV.Sprint7.Project.V4.Lib;

namespace Tyuiu.KhasanovRV.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        string openFilePath;
        public static string[,] arrayValues;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа является читательским дневником пользователя, куда он может вносить книги, которые хочет прочитать, и отмечать уже прочитанные.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_KRV_Click(object sender, EventArgs e)
        {
            int cols, rows;
            openFileDialogTable_KRV.ShowDialog();
            openFilePath = openFileDialogTable_KRV.FileName;
            arrayValues = ds.LoadFromFileData(openFilePath);

            dataGridViewTable_KRV.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTable_KRV.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    dataGridViewTable_KRV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0;i < rows; i++)
            {
                if (arrayValues[i,3] == "True")
                    dataGridViewTable_KRV.Rows[i].Cells[3].Value = true;
                else
                    dataGridViewTable_KRV.Rows[i].Cells[3].Value = false;
            }
        }

        private void buttonSave_KRV_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_KRV.FileName = "OutPutFileProject.csv";
            saveFileDialogTable_KRV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_KRV.ShowDialog();

            string path = saveFileDialogTable_KRV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTable_KRV.RowCount;
            int columns = dataGridViewTable_KRV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_KRV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTable_KRV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAdd_KRV_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KRV.Rows.Add();
        }

        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            Finished_KRV.SortMode = DataGridViewColumnSortMode.Automatic;


            
        }

        private void buttonRefresh_KRV_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewTable_KRV.RowCount;
            int columns = dataGridViewTable_KRV.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridViewTable_KRV.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;
                    
                }
                
            }
            textBoxRead_KRV.Text = ds.Readed(matrix);
        }

        private void dataGridViewTable_KRV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTable_KRV.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTable_KRV.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
