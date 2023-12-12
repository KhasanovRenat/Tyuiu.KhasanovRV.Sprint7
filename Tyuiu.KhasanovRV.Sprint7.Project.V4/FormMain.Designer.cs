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
            this.menuStrip_KRV = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem_KRV = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable_KRV = new System.Windows.Forms.DataGridView();
            this.groupBoxMoves_KRV = new System.Windows.Forms.GroupBox();
            this.buttonOpen_KRV = new System.Windows.Forms.Button();
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.buttonAdd_KRV = new System.Windows.Forms.Button();
            this.buttonDownload_KRV = new System.Windows.Forms.Button();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.infoToolStripMenuItem_KRV});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // openToolStripMenuItem_KRV
            // 
            this.openToolStripMenuItem_KRV.Name = "openToolStripMenuItem_KRV";
            this.openToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem_KRV.Text = "Открыть";
            // 
            // saveToolStripMenuItem_KRV
            // 
            this.saveToolStripMenuItem_KRV.Name = "saveToolStripMenuItem_KRV";
            this.saveToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem_KRV.Text = "Сохранить";
            // 
            // addToolStripMenuItem_KRV
            // 
            this.addToolStripMenuItem_KRV.Name = "addToolStripMenuItem_KRV";
            this.addToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.addToolStripMenuItem_KRV.Text = "Добавить";
            // 
            // infoToolStripMenuItem_KRV
            // 
            this.infoToolStripMenuItem_KRV.Name = "infoToolStripMenuItem_KRV";
            this.infoToolStripMenuItem_KRV.Size = new System.Drawing.Size(166, 26);
            this.infoToolStripMenuItem_KRV.Text = "Инфо";
            // 
            // aboutProgramToolStripMenuItem_KRV
            // 
            this.aboutProgramToolStripMenuItem_KRV.Name = "aboutProgramToolStripMenuItem_KRV";
            this.aboutProgramToolStripMenuItem_KRV.Size = new System.Drawing.Size(118, 24);
            this.aboutProgramToolStripMenuItem_KRV.Text = "О программе";
            this.aboutProgramToolStripMenuItem_KRV.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_KRV_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
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
            this.Autor,
            this.Book,
            this.Year,
            this.Finished});
            this.dataGridViewTable_KRV.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewTable_KRV.Name = "dataGridViewTable_KRV";
            this.dataGridViewTable_KRV.RowHeadersWidth = 51;
            this.dataGridViewTable_KRV.RowTemplate.Height = 24;
            this.dataGridViewTable_KRV.Size = new System.Drawing.Size(758, 334);
            this.dataGridViewTable_KRV.TabIndex = 1;
            this.dataGridViewTable_KRV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_KRV_RowPrePaint);
            // 
            // groupBoxMoves_KRV
            // 
            this.groupBoxMoves_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMoves_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_KRV.Controls.Add(this.buttonOpen_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonInfo_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonAdd_KRV);
            this.groupBoxMoves_KRV.Controls.Add(this.buttonDownload_KRV);
            this.groupBoxMoves_KRV.Location = new System.Drawing.Point(776, 31);
            this.groupBoxMoves_KRV.Name = "groupBoxMoves_KRV";
            this.groupBoxMoves_KRV.Size = new System.Drawing.Size(240, 334);
            this.groupBoxMoves_KRV.TabIndex = 2;
            this.groupBoxMoves_KRV.TabStop = false;
            this.groupBoxMoves_KRV.Text = "Действия";
            // 
            // buttonOpen_KRV
            // 
            this.buttonOpen_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KRV.Location = new System.Drawing.Point(6, 15);
            this.buttonOpen_KRV.Name = "buttonOpen_KRV";
            this.buttonOpen_KRV.Size = new System.Drawing.Size(226, 48);
            this.buttonOpen_KRV.TabIndex = 0;
            this.buttonOpen_KRV.Text = "Открыть дневник";
            this.buttonOpen_KRV.UseVisualStyleBackColor = true;
            this.buttonOpen_KRV.Click += new System.EventHandler(this.buttonOpen_KRV_Click);
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KRV.Location = new System.Drawing.Point(6, 177);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(226, 48);
            this.buttonInfo_KRV.TabIndex = 0;
            this.buttonInfo_KRV.Text = "Информация о разработчике";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // buttonAdd_KRV
            // 
            this.buttonAdd_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd_KRV.Location = new System.Drawing.Point(6, 123);
            this.buttonAdd_KRV.Name = "buttonAdd_KRV";
            this.buttonAdd_KRV.Size = new System.Drawing.Size(226, 48);
            this.buttonAdd_KRV.TabIndex = 0;
            this.buttonAdd_KRV.Text = "Добавить книгу";
            this.buttonAdd_KRV.UseVisualStyleBackColor = true;
            this.buttonAdd_KRV.Click += new System.EventHandler(this.buttonAdd_KRV_Click);
            // 
            // buttonDownload_KRV
            // 
            this.buttonDownload_KRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload_KRV.Location = new System.Drawing.Point(6, 69);
            this.buttonDownload_KRV.Name = "buttonDownload_KRV";
            this.buttonDownload_KRV.Size = new System.Drawing.Size(226, 48);
            this.buttonDownload_KRV.TabIndex = 0;
            this.buttonDownload_KRV.Text = "Сохранить дневник";
            this.buttonDownload_KRV.UseVisualStyleBackColor = true;
            this.buttonDownload_KRV.Click += new System.EventHandler(this.buttonDownload_KRV_Click);
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Автор";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            // 
            // Book
            // 
            this.Book.HeaderText = "Название";
            this.Book.MinimumWidth = 6;
            this.Book.Name = "Book";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Finished
            // 
            this.Finished.HeaderText = "Прочитано";
            this.Finished.MinimumWidth = 6;
            this.Finished.Name = "Finished";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 377);
            this.Controls.Add(this.groupBoxMoves_KRV);
            this.Controls.Add(this.dataGridViewTable_KRV);
            this.Controls.Add(this.menuStrip_KRV);
            this.MainMenuStrip = this.menuStrip_KRV;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finished;
    }
}

