using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V3.Lib;
using System.IO;
namespace Project.V3
{
    public partial class FormMain_SMS : Form
    {
        public FormMain_SMS()
        {
            InitializeComponent();
           //openFileDialogTask_SMS.Filter = "Значения, разделенные запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
           //saveFileDialogMatrix_SMS.Filter = "Значения, разделенные запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
        }



        static string openPathFile;
        DataService ds = new DataService();
        private void buttonOpenFile_SMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMS.ShowDialog();
            openPathFile = openFileDialogTask_SMS.FileName;

            
            string[,] Matrix = ds.GetMatrix(openPathFile);

            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            dataGridViewFile_SMS.RowCount = rows;
            dataGridViewFile_SMS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewFile_SMS.Columns[i].Width = 160;
                    dataGridViewFile_SMS.Rows[j].Height = 20; 
                }
    }

            dataGridViewFile_SMS.Columns[0].HeaderText = "ФИО";
            dataGridViewFile_SMS.Columns[1].HeaderText = "Должность";
            dataGridViewFile_SMS.Columns[2].HeaderText = "Дисциплина";
            dataGridViewFile_SMS.Columns[3].HeaderText = "Аудитория";
            dataGridViewFile_SMS.Columns[4].HeaderText = "Тип контроля";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewFile_SMS.Rows[r].Cells[c].Value = Matrix[r, c];
                }
            }
            Matrix = ds.GetMatrix(openPathFile);
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            FormAbout_SMS formAbout = new FormAbout_SMS();
            formAbout.ShowDialog();
        }

        private void buttonSave_SMS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SMS.FileName = "University.cvs";
            saveFileDialogMatrix_SMS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SMS.ShowDialog();


            string path = saveFileDialogMatrix_SMS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists == true)
            {
                File.Delete(path);
            }

            int rows = dataGridViewFile_SMS.RowCount;
            int columns = dataGridViewFile_SMS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewFile_SMS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewFile_SMS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSearch_SMS_Click(object sender, EventArgs e)
        {

            var data = ds.GetMatrix(openPathFile);
            var searchText = textBoxSearch_SMS.Text.ToLower();
            if (string.IsNullOrEmpty(searchText)) return;
            var filteredData = new List<string[]>();


            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText) || 
                    data[i, 2].ToLower().Contains(searchText) || data[i, 3].ToLower().Contains(searchText) || 
                    data[i, 4].ToLower().Contains(searchText))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filteredData.Add(row);
                }
            }


            var filteredDataArray = filteredData.ToArray();
            dataGridViewFile_SMS.RowCount = filteredDataArray.Length;
            dataGridViewFile_SMS.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;


            for (int r = 0; r < filteredDataArray.Length; r++)
            {
                for (int c = 0; c < filteredDataArray[0].Length; c++)
                {
                    dataGridViewFile_SMS.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                }
            }
        }

        private void buttonAdd_SMS_Click(object sender, EventArgs e)
        {
            string FIO = textBoxFIO_SMS.Text;
            string Post = textBoxPost_SMS.Text;
            string Discipline = textBoxDiscipline_SMS.Text;
            string Class = textBoxClass_SMS.Text;
            string ControlType = textBoxControlType_SMS.Text;

            string[] rowArray = { FIO, Post, Discipline, Class, ControlType };

            bool added = ds.AddRow(openPathFile, rowArray);

            if (added == true)
            {
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            string[,] Matrix = ds.GetMatrix(openPathFile);

            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            dataGridViewFile_SMS.RowCount = rows;
            dataGridViewFile_SMS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewFile_SMS.Columns[i].Width = 160;
                    dataGridViewFile_SMS.Rows[j].Height = 20;
                }
            }

            dataGridViewFile_SMS.Columns[0].HeaderText = "ФИО";
            dataGridViewFile_SMS.Columns[1].HeaderText = "Должность";
            dataGridViewFile_SMS.Columns[2].HeaderText = "Дисциплина";
            dataGridViewFile_SMS.Columns[3].HeaderText = "Аудитория";
            dataGridViewFile_SMS.Columns[4].HeaderText = "Тип контроля";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewFile_SMS.Rows[r].Cells[c].Value = Matrix[r, c];
                }
            }
        }

        private void buttonDiagram_SMS_Click(object sender, EventArgs e)
        {
            FormDiagram_SMS formDiagram = new FormDiagram_SMS();
            formDiagram.Show();
        }

        private void buttonManual_SMS_Click(object sender, EventArgs e)
        {
            FormManual_SMS formManual = new FormManual_SMS();
            formManual.Show();
        }
    }
    
}

