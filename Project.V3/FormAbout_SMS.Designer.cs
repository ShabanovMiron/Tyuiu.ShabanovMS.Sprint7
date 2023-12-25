
namespace Project.V3
{
    partial class FormAbout_SMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SMS));
            this.pictureBoxAvatar_SMS = new System.Windows.Forms.PictureBox();
            this.textBoxDeveloper_SMS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SMS
            // 
            this.pictureBoxAvatar_SMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SMS.Image")));
            this.pictureBoxAvatar_SMS.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxAvatar_SMS.Name = "pictureBoxAvatar_SMS";
            this.pictureBoxAvatar_SMS.Size = new System.Drawing.Size(120, 144);
            this.pictureBoxAvatar_SMS.TabIndex = 0;
            this.pictureBoxAvatar_SMS.TabStop = false;
            // 
            // textBoxDeveloper_SMS
            // 
            this.textBoxDeveloper_SMS.Location = new System.Drawing.Point(165, 24);
            this.textBoxDeveloper_SMS.Multiline = true;
            this.textBoxDeveloper_SMS.Name = "textBoxDeveloper_SMS";
            this.textBoxDeveloper_SMS.ReadOnly = true;
            this.textBoxDeveloper_SMS.Size = new System.Drawing.Size(274, 123);
            this.textBoxDeveloper_SMS.TabIndex = 1;
            this.textBoxDeveloper_SMS.TabStop = false;
            this.textBoxDeveloper_SMS.Text = "Разработчик: Шабанов М.С.\r\nГруппа: АСОиУб-23-1\r\n\r\nПрограмма разработана в рамках " +
    "изучения языка C#\r\n\r\nТюменский индустриальный университет (c) 2023\r\nВысшая школа" +
    " цифровых технологий (c) 2023";
            // 
            // FormAbout_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 198);
            this.Controls.Add(this.textBoxDeveloper_SMS);
            this.Controls.Add(this.pictureBoxAvatar_SMS);
            this.Name = "FormAbout_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Разработик";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SMS;
        private System.Windows.Forms.TextBox textBoxDeveloper_SMS;
    }
}