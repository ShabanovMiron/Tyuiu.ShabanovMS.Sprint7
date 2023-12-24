
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
            this.pictureBoxAvatar_SMS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SMS
            // 
            this.pictureBoxAvatar_SMS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_SMS.Name = "pictureBoxAvatar_SMS";
            this.pictureBoxAvatar_SMS.Size = new System.Drawing.Size(120, 155);
            this.pictureBoxAvatar_SMS.TabIndex = 0;
            this.pictureBoxAvatar_SMS.TabStop = false;
            // 
            // FormAbout_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 286);
            this.Controls.Add(this.pictureBoxAvatar_SMS);
            this.Name = "FormAbout_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Разработик";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SMS;
    }
}