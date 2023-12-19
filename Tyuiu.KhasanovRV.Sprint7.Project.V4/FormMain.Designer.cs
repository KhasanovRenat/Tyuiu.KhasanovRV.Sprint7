namespace Tyuiu.KhasanovRV.Sprint7.Project.V4
{
    partial class FormMain
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
            this.menuStrip_KRV = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable_KRV = new System.Windows.Forms.DataGridView();
            this.Autor_KRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_KRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_KRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished_KRV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxMoves_KRV = new System.Windows.Forms.GroupBox();
            this.buttonOpen_KRV = new System.Windows.Forms.Button();
            this.buttonRefresh_KRV = new System.Windows.Forms.Button();
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.buttonAdd_KRV = new System.Windows.Forms.Button();
            this.buttonDownload_KRV = new System.Windows.Forms.Button();
            this.saveFileDialogTable_KRV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_KRV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipWiki_KRV = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxRead_KRV = new System.Windows.Forms.TextBox();
            this.labelRead_KRV = new System.Windows.Forms.Label();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KRV)).BeginInit();
            this.groupBoxMoves_KRV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_KRV
            // 
            this.menuStrip_KRV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_KRV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.aboutProgramToolStripMenuItem_KRV,
            this.exitToolStripMenuItem});
            this.menuStrip_KRV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_KRV.Name = "menuStrip_KRV";
            this.menuStrip_KRV.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip_KRV.TabIndex = 0;
            this.menuStrip_KRV.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem_KRV,
            this.saveToolStripMenuItem_KRV,
            this.addToolStripMenuItem_KRV,
            this.infoToolStripMenuItem_KRV,
            this.обновитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // openToolStripMenuItem_KRV
            // 
            this.openToolStripMenuItem_KRV.Name = "openToolStripMenuItem_KRV";
            this.openToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem_KRV.Text = "Открыть";
            this.openToolStripMenuItem_KRV.Click += new System.EventHandler(this.buttonOpen_KRV_Click);
            // 
            // saveToolStripMenuItem_KRV
            // 
            this.saveToolStripMenuItem_KRV.Name = "saveToolStripMenuItem_KRV";
            this.saveToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem_KRV.Text = "Сохранить";
            this.saveToolStripMenuItem_KRV.Click += new System.EventHandler(this.buttonSave_KRV_Click);
            // 
            // addToolStripMenuItem_KRV
            // 
            this.addToolStripMenuItem_KRV.Name = "addToolStripMenuItem_KRV";
            this.addToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.addToolStripMenuItem_KRV.Text = "Добавить";
            this.addToolStripMenuItem_KRV.Click += new System.EventHandler(this.buttonAdd_KRV_Click);
            // 
            // infoToolStripMenuItem_KRV
            // 
            this.infoToolStripMenuItem_KRV.Name = "infoToolStripMenuItem_KRV";
            this.infoToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.infoToolStripMenuItem_KRV.Text = "Инфо";
            this.infoToolStripMenuItem_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // aboutProgramToolStripMenuItem_KRV
            // 
            this.aboutProgramToolStripMenuItem_KRV.Name = "aboutProgramToolStripMenuItem_KRV";
            this.aboutProgramToolStripMenuItem_KRV.Size = new System.Drawing.Size(118, 26);
            this.aboutProgramToolStripMenuItem_KRV.Text = "О программе";
            this.aboutProgramToolStripMenuItem_KRV.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_KRV_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewTable_KRV
            // 
            this.dataGridViewTable_KRV.AllowUserToAddRows = false;
            this.dataGridViewTable_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable_KRV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KRV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autor_KRV,
            this.Book_KRV,
            this.Year_KRV,
            this.Finished_KRV});
            this.dataGridViewTable_KRV.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewTable_KRV.Name = "dataGridViewTable_KRV";
            this.dataGridViewTable_KRV.RowHeadersWidth = 51;
            this.dataGridViewTable_KRV.RowTemplate.Height = 24;
            this.dataGridViewTable_KRV.Size = new System.Drawing.Size(758, 434);
            this.dataGridViewTable_KRV.TabIndex = 1;
            this.dataGridViewTable_KRV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_KRV_RowPrePaint);
            // 
            // Autor_KRV
            // 
            this.Autor_KRV.HeaderText = "Автор";
            this.Autor_KRV.MinimumWidth = 6;
            this.Autor_KRV.Name = "Autor_KRV";
            // 
            // Book_KRV
            // 
            this.Book_KRV.HeaderText = "Название";
            this.Book_KRV.MinimumWidth = 6;
            this.Book_KRV.Name = "Book_KRV";
            // 
            // Year_KRV
            // 
            this.Year_KRV.HeaderText = "Год издания";
            this.Year_KRV.MinimumWidth = 6;
            this.Year_KRV.Name = "Year_KRV";
            // 
            // Finished_KRV
            // 
            this.Finished_KRV.HeaderText = "Прочитано";
            this.Finished_KRV.MinimumWidth = 6;
            this.Finished_KRV.Name = "Finished_KRV";
            // 
            // groupBoxMoves_KRV
            // 
            this.groupBoxMoves_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMoves_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_KRV.Controls.Add(this.buttonOpen_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonRefresh_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonInfo_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonAdd_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonDownload_KRV);
            this.groupBoxMoves_KRV.Location = new System.Drawing.Point(776, 31);
            this.groupBoxMoves_KRV.Name = "groupBoxMoves_KRV";
            this.groupBoxMoves_KRV.Size = new System.Drawing.Size(240, 358);
            this.groupBoxMoves_KRV.TabIndex = 2;
            this.groupBoxMoves_KRV.TabStop = false;
            this.groupBoxMoves_KRV.Text = "Действия";
            // 
            // buttonOpen_KRV
            // 
            this.buttonOpen_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_KRV.Location = new System.Drawing.Point(6, 21);
            this.buttonOpen_KRV.Name = "buttonOpen_KRV";
            this.buttonOpen_KRV.Size = new System.Drawing.Size(228, 60);
            this.buttonOpen_KRV.TabIndex = 0;
            this.buttonOpen_KRV.Text = "Открыть дневник";
            this.buttonOpen_KRV.UseVisualStyleBackColor = true;
            this.buttonOpen_KRV.Click += new System.EventHandler(this.buttonOpen_KRV_Click);
            // 
            // buttonRefresh_KRV
            // 
            this.buttonRefresh_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh_KRV.Location = new System.Drawing.Point(6, 285);
            this.buttonRefresh_KRV.Name = "buttonRefresh_KRV";
            this.buttonRefresh_KRV.Size = new System.Drawing.Size(228, 60);
            this.buttonRefresh_KRV.TabIndex = 0;
            this.buttonRefresh_KRV.Text = "Обновить";
            this.buttonRefresh_KRV.UseVisualStyleBackColor = true;
            this.buttonRefresh_KRV.Click += new System.EventHandler(this.buttonRefresh_KRV_Click);
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_KRV.Location = new System.Drawing.Point(6, 219);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(228, 60);
            this.buttonInfo_KRV.TabIndex = 0;
            this.buttonInfo_KRV.Text = "Информация о разработчике";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // buttonAdd_KRV
            // 
            this.buttonAdd_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_KRV.Location = new System.Drawing.Point(6, 153);
            this.buttonAdd_KRV.Name = "buttonAdd_KRV";
            this.buttonAdd_KRV.Size = new System.Drawing.Size(228, 60);
            this.buttonAdd_KRV.TabIndex = 0;
            this.buttonAdd_KRV.Text = "Добавить книгу";
            this.buttonAdd_KRV.UseVisualStyleBackColor = true;
            this.buttonAdd_KRV.Click += new System.EventHandler(this.buttonAdd_KRV_Click);
            // 
            // buttonDownload_KRV
            // 
            this.buttonDownload_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownload_KRV.Location = new System.Drawing.Point(6, 87);
            this.buttonDownload_KRV.Name = "buttonDownload_KRV";
            this.buttonDownload_KRV.Size = new System.Drawing.Size(228, 60);
            this.buttonDownload_KRV.TabIndex = 0;
            this.buttonDownload_KRV.Text = "Сохранить дневник";
            this.buttonDownload_KRV.UseVisualStyleBackColor = true;
            this.buttonDownload_KRV.Click += new System.EventHandler(this.buttonSave_KRV_Click);
            // 
            // openFileDialogTable_KRV
            // 
            this.openFileDialogTable_KRV.FileName = "openFileDialog1";
            // 
            // textBoxRead_KRV
            // 
            this.textBoxRead_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRead_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRead_KRV.Location = new System.Drawing.Point(776, 420);
            this.textBoxRead_KRV.Name = "textBoxRead_KRV";
            this.textBoxRead_KRV.ReadOnly = true;
            this.textBoxRead_KRV.Size = new System.Drawing.Size(240, 45);
            this.textBoxRead_KRV.TabIndex = 3;
            // 
            // labelRead_KRV
            // 
            this.labelRead_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRead_KRV.AutoSize = true;
            this.labelRead_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRead_KRV.Location = new System.Drawing.Point(777, 392);
            this.labelRead_KRV.Name = "labelRead_KRV";
            this.labelRead_KRV.Size = new System.Drawing.Size(120, 25);
            this.labelRead_KRV.TabIndex = 4;
            this.labelRead_KRV.Text = "Прочитано:";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.buttonRefresh_KRV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 477);
            this.Controls.Add(this.labelRead_KRV);
            this.Controls.Add(this.textBoxRead_KRV);
            this.Controls.Add(this.groupBoxMoves_KRV);
            this.Controls.Add(this.dataGridViewTable_KRV);
            this.Controls.Add(this.menuStrip_KRV);
            this.MainMenuStrip = this.menuStrip_KRV;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя библиотека";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip_KRV.ResumeLayout(false);
            this.menuStrip_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KRV)).EndInit();
            this.groupBoxMoves_KRV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_KRV;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem_KRV;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTable_KRV;
        private System.Windows.Forms.GroupBox groupBoxMoves_KRV;
        private System.Windows.Forms.Button buttonOpen_KRV;
        private System.Windows.Forms.Button buttonInfo_KRV;
        private System.Windows.Forms.Button buttonAdd_KRV;
        private System.Windows.Forms.Button buttonDownload_KRV;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_KRV;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_KRV;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_KRV;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem_KRV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_KRV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_KRV;
        private System.Windows.Forms.ToolTip toolTipWiki_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_KRV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished_KRV;
        private System.Windows.Forms.TextBox textBoxRead_KRV;
        private System.Windows.Forms.Label labelRead_KRV;
        private System.Windows.Forms.Button buttonRefresh_KRV;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    }
}

