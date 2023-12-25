
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
            this.buttonDiagram_SMS = new System.Windows.Forms.Button();
            this.buttonManual_SMS = new System.Windows.Forms.Button();
            this.textBoxSearch_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.buttonSearch_SMS = new System.Windows.Forms.Button();
            this.buttonSave_SMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_SMS = new System.Windows.Forms.Button();
            this.dataGridViewFile_SMS = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogTask_SMS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_SMS = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxAdd_SMS = new System.Windows.Forms.GroupBox();
            this.buttonAdd_SMS = new System.Windows.Forms.Button();
            this.labelControlType_SMS = new System.Windows.Forms.Label();
            this.labelClass_SMS = new System.Windows.Forms.Label();
            this.labelDiscipline_SMS = new System.Windows.Forms.Label();
            this.labelPost_SMS = new System.Windows.Forms.Label();
            this.labelFIO_SMS = new System.Windows.Forms.Label();
            this.textBoxControlType_SMS = new System.Windows.Forms.TextBox();
            this.textBoxClass_SMS = new System.Windows.Forms.TextBox();
            this.textBoxDiscipline_SMS = new System.Windows.Forms.TextBox();
            this.textBoxPost_SMS = new System.Windows.Forms.TextBox();
            this.textBoxFIO_SMS = new System.Windows.Forms.TextBox();
            this.panelTop_SMS = new System.Windows.Forms.Panel();
            this.panelLeft_SMS = new System.Windows.Forms.Panel();
            this.panelRight_SMS = new System.Windows.Forms.Panel();
            this.groupBoxButtons_SMS.SuspendLayout();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile_SMS)).BeginInit();
            this.groupBoxAdd_SMS.SuspendLayout();
            this.panelTop_SMS.SuspendLayout();
            this.panelLeft_SMS.SuspendLayout();
            this.panelRight_SMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons_SMS
            // 
            this.groupBoxButtons_SMS.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBoxButtons_SMS.Controls.Add(this.buttonDiagram_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonManual_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.textBoxSearch_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.groupBoxTask_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonHelp_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonSearch_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonSave_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonOpenFile_SMS);
            this.groupBoxButtons_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtons_SMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_SMS.Name = "groupBoxButtons_SMS";
            this.groupBoxButtons_SMS.Size = new System.Drawing.Size(1294, 179);
            this.groupBoxButtons_SMS.TabIndex = 0;
            this.groupBoxButtons_SMS.TabStop = false;
            this.groupBoxButtons_SMS.Text = "Панель управления";
            // 
            // buttonDiagram_SMS
            // 
            this.buttonDiagram_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDiagram_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagram_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiagram_SMS.Location = new System.Drawing.Point(400, 22);
            this.buttonDiagram_SMS.Name = "buttonDiagram_SMS";
            this.buttonDiagram_SMS.Size = new System.Drawing.Size(93, 58);
            this.buttonDiagram_SMS.TabIndex = 4;
            this.buttonDiagram_SMS.Text = "Диаграммы";
            this.buttonDiagram_SMS.UseVisualStyleBackColor = false;
            this.buttonDiagram_SMS.Click += new System.EventHandler(this.buttonDiagram_SMS_Click);
            // 
            // buttonManual_SMS
            // 
            this.buttonManual_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonManual_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManual_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManual_SMS.Location = new System.Drawing.Point(1023, 23);
            this.buttonManual_SMS.Name = "buttonManual_SMS";
            this.buttonManual_SMS.Size = new System.Drawing.Size(90, 58);
            this.buttonManual_SMS.TabIndex = 3;
            this.buttonManual_SMS.Text = "Руководство пользователя";
            this.buttonManual_SMS.UseVisualStyleBackColor = false;
            this.buttonManual_SMS.Click += new System.EventHandler(this.buttonManual_SMS_Click);
            // 
            // textBoxSearch_SMS
            // 
            this.textBoxSearch_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch_SMS.Location = new System.Drawing.Point(656, 40);
            this.textBoxSearch_SMS.Name = "textBoxSearch_SMS";
            this.textBoxSearch_SMS.Size = new System.Drawing.Size(149, 21);
            this.textBoxSearch_SMS.TabIndex = 1;
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(0, 99);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(1294, 56);
            this.groupBoxTask_SMS.TabIndex = 2;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.BackColor = System.Drawing.Color.SeaGreen;
            this.textBoxTask_SMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SMS.ForeColor = System.Drawing.Color.Black;
            this.textBoxTask_SMS.Location = new System.Drawing.Point(7, 11);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(1287, 22);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.Text = "Разработать Desktop приложение на основе Windows Forms по предметной области. Все" +
    " данные должны храниться в формате файла CSV.";
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonHelp_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SMS.Location = new System.Drawing.Point(1196, 23);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonHelp_SMS.TabIndex = 0;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // buttonSearch_SMS
            // 
            this.buttonSearch_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_SMS.Location = new System.Drawing.Point(811, 40);
            this.buttonSearch_SMS.Name = "buttonSearch_SMS";
            this.buttonSearch_SMS.Size = new System.Drawing.Size(76, 21);
            this.buttonSearch_SMS.TabIndex = 0;
            this.buttonSearch_SMS.Text = "Поиск";
            this.buttonSearch_SMS.UseVisualStyleBackColor = false;
            this.buttonSearch_SMS.Click += new System.EventHandler(this.buttonSearch_SMS_Click);
            // 
            // buttonSave_SMS
            // 
            this.buttonSave_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSave_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave_SMS.Location = new System.Drawing.Point(190, 22);
            this.buttonSave_SMS.Name = "buttonSave_SMS";
            this.buttonSave_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonSave_SMS.TabIndex = 0;
            this.buttonSave_SMS.Text = "Сохранить";
            this.buttonSave_SMS.UseVisualStyleBackColor = false;
            this.buttonSave_SMS.Click += new System.EventHandler(this.buttonSave_SMS_Click);
            // 
            // buttonOpenFile_SMS
            // 
            this.buttonOpenFile_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonOpenFile_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_SMS.Location = new System.Drawing.Point(9, 22);
            this.buttonOpenFile_SMS.Name = "buttonOpenFile_SMS";
            this.buttonOpenFile_SMS.Size = new System.Drawing.Size(86, 59);
            this.buttonOpenFile_SMS.TabIndex = 0;
            this.buttonOpenFile_SMS.Text = "Выбрать файл";
            this.buttonOpenFile_SMS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SMS.Click += new System.EventHandler(this.buttonOpenFile_SMS_Click);
            // 
            // dataGridViewFile_SMS
            // 
            this.dataGridViewFile_SMS.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewFile_SMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFile_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFile_SMS.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFile_SMS.Name = "dataGridViewFile_SMS";
            this.dataGridViewFile_SMS.ReadOnly = true;
            this.dataGridViewFile_SMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewFile_SMS.RowHeadersVisible = false;
            this.dataGridViewFile_SMS.Size = new System.Drawing.Size(867, 491);
            this.dataGridViewFile_SMS.TabIndex = 1;
            // 
            // openFileDialogTask_SMS
            // 
            this.openFileDialogTask_SMS.FileName = "openFileDialogTask";
            // 
            // groupBoxAdd_SMS
            // 
            this.groupBoxAdd_SMS.Controls.Add(this.buttonAdd_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.labelControlType_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.labelClass_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.labelDiscipline_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.labelPost_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.labelFIO_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.textBoxControlType_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.textBoxClass_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.textBoxDiscipline_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.textBoxPost_SMS);
            this.groupBoxAdd_SMS.Controls.Add(this.textBoxFIO_SMS);
            this.groupBoxAdd_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAdd_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAdd_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAdd_SMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdd_SMS.Name = "groupBoxAdd_SMS";
            this.groupBoxAdd_SMS.Size = new System.Drawing.Size(409, 491);
            this.groupBoxAdd_SMS.TabIndex = 3;
            this.groupBoxAdd_SMS.TabStop = false;
            this.groupBoxAdd_SMS.Text = "Добавление строк";
            // 
            // buttonAdd_SMS
            // 
            this.buttonAdd_SMS.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAdd_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_SMS.Location = new System.Drawing.Point(220, 172);
            this.buttonAdd_SMS.Name = "buttonAdd_SMS";
            this.buttonAdd_SMS.Size = new System.Drawing.Size(115, 60);
            this.buttonAdd_SMS.TabIndex = 6;
            this.buttonAdd_SMS.Text = "Добавить";
            this.buttonAdd_SMS.UseVisualStyleBackColor = false;
            this.buttonAdd_SMS.Click += new System.EventHandler(this.buttonAdd_SMS_Click);
            // 
            // labelControlType_SMS
            // 
            this.labelControlType_SMS.AutoSize = true;
            this.labelControlType_SMS.Location = new System.Drawing.Point(6, 314);
            this.labelControlType_SMS.Name = "labelControlType_SMS";
            this.labelControlType_SMS.Size = new System.Drawing.Size(86, 15);
            this.labelControlType_SMS.TabIndex = 5;
            this.labelControlType_SMS.Text = "Тип контроля";
            // 
            // labelClass_SMS
            // 
            this.labelClass_SMS.AutoSize = true;
            this.labelClass_SMS.Location = new System.Drawing.Point(6, 240);
            this.labelClass_SMS.Name = "labelClass_SMS";
            this.labelClass_SMS.Size = new System.Drawing.Size(68, 15);
            this.labelClass_SMS.TabIndex = 5;
            this.labelClass_SMS.Text = "Аудитория";
            // 
            // labelDiscipline_SMS
            // 
            this.labelDiscipline_SMS.AutoSize = true;
            this.labelDiscipline_SMS.Location = new System.Drawing.Point(6, 177);
            this.labelDiscipline_SMS.Name = "labelDiscipline_SMS";
            this.labelDiscipline_SMS.Size = new System.Drawing.Size(78, 15);
            this.labelDiscipline_SMS.TabIndex = 5;
            this.labelDiscipline_SMS.Text = "Дисциплина";
            // 
            // labelPost_SMS
            // 
            this.labelPost_SMS.AutoSize = true;
            this.labelPost_SMS.Location = new System.Drawing.Point(6, 109);
            this.labelPost_SMS.Name = "labelPost_SMS";
            this.labelPost_SMS.Size = new System.Drawing.Size(73, 15);
            this.labelPost_SMS.TabIndex = 5;
            this.labelPost_SMS.Text = "Должность";
            // 
            // labelFIO_SMS
            // 
            this.labelFIO_SMS.AutoSize = true;
            this.labelFIO_SMS.Location = new System.Drawing.Point(7, 28);
            this.labelFIO_SMS.Name = "labelFIO_SMS";
            this.labelFIO_SMS.Size = new System.Drawing.Size(36, 15);
            this.labelFIO_SMS.TabIndex = 5;
            this.labelFIO_SMS.Text = "ФИО";
            // 
            // textBoxControlType_SMS
            // 
            this.textBoxControlType_SMS.Location = new System.Drawing.Point(7, 330);
            this.textBoxControlType_SMS.Name = "textBoxControlType_SMS";
            this.textBoxControlType_SMS.Size = new System.Drawing.Size(100, 21);
            this.textBoxControlType_SMS.TabIndex = 4;
            // 
            // textBoxClass_SMS
            // 
            this.textBoxClass_SMS.Location = new System.Drawing.Point(7, 256);
            this.textBoxClass_SMS.Name = "textBoxClass_SMS";
            this.textBoxClass_SMS.Size = new System.Drawing.Size(100, 21);
            this.textBoxClass_SMS.TabIndex = 3;
            // 
            // textBoxDiscipline_SMS
            // 
            this.textBoxDiscipline_SMS.Location = new System.Drawing.Point(7, 193);
            this.textBoxDiscipline_SMS.Name = "textBoxDiscipline_SMS";
            this.textBoxDiscipline_SMS.Size = new System.Drawing.Size(100, 21);
            this.textBoxDiscipline_SMS.TabIndex = 2;
            // 
            // textBoxPost_SMS
            // 
            this.textBoxPost_SMS.Location = new System.Drawing.Point(7, 125);
            this.textBoxPost_SMS.Name = "textBoxPost_SMS";
            this.textBoxPost_SMS.Size = new System.Drawing.Size(100, 21);
            this.textBoxPost_SMS.TabIndex = 1;
            // 
            // textBoxFIO_SMS
            // 
            this.textBoxFIO_SMS.Location = new System.Drawing.Point(7, 47);
            this.textBoxFIO_SMS.Name = "textBoxFIO_SMS";
            this.textBoxFIO_SMS.Size = new System.Drawing.Size(100, 21);
            this.textBoxFIO_SMS.TabIndex = 0;
            // 
            // panelTop_SMS
            // 
            this.panelTop_SMS.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTop_SMS.Controls.Add(this.groupBoxButtons_SMS);
            this.panelTop_SMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SMS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SMS.Name = "panelTop_SMS";
            this.panelTop_SMS.Size = new System.Drawing.Size(1294, 179);
            this.panelTop_SMS.TabIndex = 4;
            // 
            // panelLeft_SMS
            // 
            this.panelLeft_SMS.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelLeft_SMS.Controls.Add(this.groupBoxAdd_SMS);
            this.panelLeft_SMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SMS.Location = new System.Drawing.Point(0, 179);
            this.panelLeft_SMS.Name = "panelLeft_SMS";
            this.panelLeft_SMS.Size = new System.Drawing.Size(409, 491);
            this.panelLeft_SMS.TabIndex = 5;
            // 
            // panelRight_SMS
            // 
            this.panelRight_SMS.Controls.Add(this.dataGridViewFile_SMS);
            this.panelRight_SMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_SMS.Location = new System.Drawing.Point(427, 179);
            this.panelRight_SMS.Name = "panelRight_SMS";
            this.panelRight_SMS.Size = new System.Drawing.Size(867, 491);
            this.panelRight_SMS.TabIndex = 6;
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1294, 670);
            this.Controls.Add(this.panelRight_SMS);
            this.Controls.Add(this.panelLeft_SMS);
            this.Controls.Add(this.panelTop_SMS);
            this.MaximumSize = new System.Drawing.Size(1310, 709);
            this.MinimumSize = new System.Drawing.Size(1310, 709);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Университет";
            this.groupBoxButtons_SMS.ResumeLayout(false);
            this.groupBoxButtons_SMS.PerformLayout();
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile_SMS)).EndInit();
            this.groupBoxAdd_SMS.ResumeLayout(false);
            this.groupBoxAdd_SMS.PerformLayout();
            this.panelTop_SMS.ResumeLayout(false);
            this.panelLeft_SMS.ResumeLayout(false);
            this.panelRight_SMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons_SMS;
        private System.Windows.Forms.Button buttonSave_SMS;
        private System.Windows.Forms.Button buttonOpenFile_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonSearch_SMS;
        private System.Windows.Forms.DataGridView dataGridViewFile_SMS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMS;
        private System.Windows.Forms.TextBox textBoxSearch_SMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SMS;
        private System.Windows.Forms.GroupBox groupBoxAdd_SMS;
        private System.Windows.Forms.Label labelPost_SMS;
        private System.Windows.Forms.Label labelFIO_SMS;
        private System.Windows.Forms.TextBox textBoxControlType_SMS;
        private System.Windows.Forms.TextBox textBoxClass_SMS;
        private System.Windows.Forms.TextBox textBoxDiscipline_SMS;
        private System.Windows.Forms.TextBox textBoxPost_SMS;
        private System.Windows.Forms.TextBox textBoxFIO_SMS;
        private System.Windows.Forms.Label labelControlType_SMS;
        private System.Windows.Forms.Label labelClass_SMS;
        private System.Windows.Forms.Label labelDiscipline_SMS;
        private System.Windows.Forms.Button buttonAdd_SMS;
        private System.Windows.Forms.Panel panelTop_SMS;
        private System.Windows.Forms.Panel panelLeft_SMS;
        private System.Windows.Forms.Panel panelRight_SMS;
        private System.Windows.Forms.Button buttonManual_SMS;
        private System.Windows.Forms.Button buttonDiagram_SMS;
    }
}

