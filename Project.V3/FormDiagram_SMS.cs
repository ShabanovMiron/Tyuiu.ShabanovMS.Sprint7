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
namespace Project.V3
{
    public partial class FormDiagram_SMS : Form
    {
        public FormDiagram_SMS()
        {
            InitializeComponent();
            string path = @"..\BackEnd\University.csv";  

            DataService ds = new DataService();
            string[,] Matrix = ds.GetMatrix(path);

            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            int countPlus = 0;
            int countMinus = 0;
            int Z = 4;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(j == Z)
                    {
                        if (Matrix[i,j] == "Зачет")
                        {
                            countPlus++;
                        }
                        if(Matrix[i, j] == "Экзамен")
                        {
                            countMinus++;
                        }
                    }
                }
            }
            chartControlTypeKrug_SMS.Series[0].Points.AddXY("Зачет", countPlus);
            chartControlTypeKrug_SMS.Series[0].Points.AddXY("Экзамен", countMinus);

            chartControlTypePalka_SMS.Series[0].Points.AddXY("Зачет", countPlus);
            chartControlTypePalka_SMS.Series[0].Points.AddXY("Экзамен", countMinus);
        }
    }
}
