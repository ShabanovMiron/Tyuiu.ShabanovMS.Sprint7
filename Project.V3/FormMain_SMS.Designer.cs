
namespace Project.V3
{
    partial class FormMain_SMS
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
            this.groupBoxButtons_SMS = new System.Windows.Forms.GroupBox();
            this.buttonSave_SMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_SMS = new System.Windows.Forms.Button();
            this.buttonSort_SMS = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.dataGridViewFile_SMS = new System.Windows.Forms.DataGridView();
            this.groupBoxButtons_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons_SMS
            // 
            this.groupBoxButtons_SMS.Controls.Add(this.buttonHelp_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.button4);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonSort_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonSave_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonOpenFile_SMS);
            this.groupBoxButtons_SMS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxButtons_SMS.Name = "groupBoxButtons_SMS";
            this.groupBoxButtons_SMS.Size = new System.Drawing.Size(1269, 100);
            this.groupBoxButtons_SMS.TabIndex = 0;
            this.groupBoxButtons_SMS.TabStop = false;
            this.groupBoxButtons_SMS.Text = "Панель управления";
            // 
            // buttonSave_SMS
            // 
            this.buttonSave_SMS.Location = new System.Drawing.Point(99, 19);
            this.buttonSave_SMS.Name = "buttonSave_SMS";
            this.buttonSave_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonSave_SMS.TabIndex = 0;
            this.buttonSave_SMS.Text = "Сохранить";
            this.buttonSave_SMS.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_SMS
            // 
            this.buttonOpenFile_SMS.Location = new System.Drawing.Point(7, 20);
            this.buttonOpenFile_SMS.Name = "buttonOpenFile_SMS";
            this.buttonOpenFile_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonOpenFile_SMS.TabIndex = 0;
            this.buttonOpenFile_SMS.Text = "Выбрать файл";
            this.buttonOpenFile_SMS.UseVisualStyleBackColor = true;
            // 
            // buttonSort_SMS
            // 
            this.buttonSort_SMS.Location = new System.Drawing.Point(191, 20);
            this.buttonSort_SMS.Name = "buttonSort_SMS";
            this.buttonSort_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonSort_SMS.TabIndex = 0;
            this.buttonSort_SMS.Text = "Сортировка";
            this.buttonSort_SMS.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 59);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.Location = new System.Drawing.Point(1162, 20);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonHelp_SMS.TabIndex = 0;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFile_SMS
            // 
            this.dataGridViewFile_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile_SMS.Location = new System.Drawing.Point(600, 129);
            this.dataGridViewFile_SMS.Name = "dataGridViewFile_SMS";
            this.dataGridViewFile_SMS.Size = new System.Drawing.Size(682, 509);
            this.dataGridViewFile_SMS.TabIndex = 1;
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 650);
            this.Controls.Add(this.dataGridViewFile_SMS);
            this.Controls.Add(this.groupBoxButtons_SMS);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Университет";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxButtons_SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons_SMS;
        private System.Windows.Forms.Button buttonSave_SMS;
        private System.Windows.Forms.Button buttonOpenFile_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSort_SMS;
        private System.Windows.Forms.DataGridView dataGridViewFile_SMS;
    }
}

