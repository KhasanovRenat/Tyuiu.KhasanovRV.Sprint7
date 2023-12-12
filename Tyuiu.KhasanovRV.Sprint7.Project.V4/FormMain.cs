using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KhasanovRV.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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

        }

        private void buttonDownload_KRV_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_KRV_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KRV.Rows.Add();
        }

        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {

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
