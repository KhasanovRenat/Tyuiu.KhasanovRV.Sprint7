namespace Tyuiu.KhasanovRV.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_KRV = new System.Windows.Forms.PictureBox();
            this.richTextBoxInfo_KRV = new System.Windows.Forms.RichTextBox();
            this.buttonOK_KRV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_KRV
            // 
            this.pictureBoxMe_KRV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_KRV.Image")));
            this.pictureBoxMe_KRV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_KRV.Name = "pictureBoxMe_KRV";
            this.pictureBoxMe_KRV.Size = new System.Drawing.Size(202, 268);
            this.pictureBoxMe_KRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMe_KRV.TabIndex = 0;
            this.pictureBoxMe_KRV.TabStop = false;
            // 
            // richTextBoxInfo_KRV
            // 
            this.richTextBoxInfo_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxInfo_KRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo_KRV.Location = new System.Drawing.Point(224, 12);
            this.richTextBoxInfo_KRV.Name = "richTextBoxInfo_KRV";
            this.richTextBoxInfo_KRV.ReadOnly = true;
            this.richTextBoxInfo_KRV.Size = new System.Drawing.Size(371, 159);
            this.richTextBoxInfo_KRV.TabIndex = 2;
            this.richTextBoxInfo_KRV.Text = resources.GetString("richTextBoxInfo_KRV.Text");
            // 
            // buttonOK_KRV
            // 
            this.buttonOK_KRV.Location = new System.Drawing.Point(476, 243);
            this.buttonOK_KRV.Name = "buttonOK_KRV";
            this.buttonOK_KRV.Size = new System.Drawing.Size(119, 42);
            this.buttonOK_KRV.TabIndex = 3;
            this.buttonOK_KRV.Text = "Ок";
            this.buttonOK_KRV.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 297);
            this.Controls.Add(this.buttonOK_KRV);
            this.Controls.Add(this.richTextBoxInfo_KRV);
            this.Controls.Add(this.pictureBoxMe_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_KRV;
        private System.Windows.Forms.RichTextBox richTextBoxInfo_KRV;
        private System.Windows.Forms.Button buttonOK_KRV;
    }
}