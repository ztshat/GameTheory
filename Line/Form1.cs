using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line
{
    public partial class Form1 : Form
    {
        Graphics graph_A;
        Graphics graph_B;

        Bitmap myBitmap_A;
        Bitmap myBitmap_B;

        Pen myBlackPen;
        SolidBrush myRedBrush;
        Color selectedColor;
        int a;
        int b;
        int tranparent;
        int lineThikness;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Підлаштовуємо розмір Зображення під форму
            pb_Result_A.Width = 500;
            pb_Result_A.Height = 500;


            //створюємо віртуальне зображення: 
            myBitmap_A = new Bitmap(500, 500);
            myBitmap_B = new Bitmap(500, 500);
            //підключаємо віртуальне зображення до графіки:
            graph_A = Graphics.FromImage(myBitmap_A);
            graph_B = Graphics.FromImage(myBitmap_B);
            //створюємо об'єкт пензлик
            lineThikness = 2;
            myBlackPen = new Pen(Color.DimGray, lineThikness);
            //початковий колір заливки
            selectedColor = Color.Green;
            //початкова прозорість
            tranparent = 255;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A
            graph_A.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result_A.Image = myBitmap_A;

            //створюємо точки 
            Point point_A = new Point(50, 450);
            Point point_B = new Point(450, 450);
            //малюємо вісь
            graph_A.DrawLine(myBlackPen, point_A, point_B);
            graph_A.DrawLine(myBlackPen, 440, 445, 451, 451);
            graph_A.DrawLine(myBlackPen, 440, 455, 451, 449);
            //лінії стратегій 
            graph_A.DrawLine(myBlackPen, 75, 50, 75, 460);
                //стрілка
                graph_A.DrawLine(myBlackPen, 70, 60, 75, 50);
                graph_A.DrawLine(myBlackPen, 80, 60, 75, 50);

            graph_A.DrawLine(myBlackPen, 425, 50, 425, 460);
                //стрілка
                graph_A.DrawLine(myBlackPen, 430, 55, 425, 50);
                graph_A.DrawLine(myBlackPen, 420, 55, 425, 50);
            //
            //підписи до осей http://foxtools.ru/Unicode 
            graph_A.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Font lFont = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
           
            graph_A.DrawString("A" + ((char)8321).ToString(), lFont, Brushes.Black, 40, 40);
            graph_A.DrawString("A" + ((char)8322).ToString(), lFont, Brushes.Black, 430, 40);
            graph_A.DrawString("p", lFont, Brushes.Black, 450, 460);
            graph_A.DrawString("0", lFont, Brushes.Black, 65, 460);
            graph_A.DrawString("1", lFont, Brushes.Black, 415, 460);
            Font numFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            //підписи до осей A1
            for (int i=1; i<=21; i++)
            {
                graph_A.DrawString((i-11).ToString(), numFont, Brushes.Gray, 40, 445-i*17);
                graph_A.DrawLine(myBlackPen, 70, 450 - i * 17, 75, 450 - i * 17);

            }
            //підписи до осей A2
            for (int i = 1; i <= 21; i++)
            {
                graph_A.DrawString((i - 11).ToString(), numFont, Brushes.Gray, 450, 445 - i * 17);
                graph_A.DrawLine(myBlackPen, 425, 450 - i * 17, 430, 450 - i * 17);

            }
            //B
            graph_B.Clear(Color.White);
            //відображаємо зображення в компонент PictureBox:
            pb_Result_B.Image = myBitmap_B;

            //створюємо точки 

            //малюємо вісь
            graph_B.DrawLine(myBlackPen, point_A, point_B);
            graph_B.DrawLine(myBlackPen, 440, 445, 451, 451);
            graph_B.DrawLine(myBlackPen, 440, 455, 451, 449);
            //лінії стратегій 
            graph_B.DrawLine(myBlackPen, 75, 50, 75, 460);
            //стрілка
            graph_B.DrawLine(myBlackPen, 70, 60, 75, 50);
            graph_B.DrawLine(myBlackPen, 80, 60, 75, 50);

            graph_B.DrawLine(myBlackPen, 425, 50, 425, 460);
            //стрілка
            graph_B.DrawLine(myBlackPen, 430, 55, 425, 50);
            graph_B.DrawLine(myBlackPen, 420, 55, 425, 50);
            //
            //підписи до осей http://foxtools.ru/Unicode 
            graph_B.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            graph_B.DrawString("B" + ((char)8321).ToString(), lFont, Brushes.Black, 40, 40);
            graph_B.DrawString("B" + ((char)8322).ToString(), lFont, Brushes.Black, 430, 40);
            graph_B.DrawString("q", lFont, Brushes.Black, 450, 460);
            graph_B.DrawString("0", lFont, Brushes.Black, 65, 460);
            graph_B.DrawString("1", lFont, Brushes.Black, 415, 460);
            
            //підписи до осей B1
            for (int i = 1; i <= 21; i++)
            {
                graph_B.DrawString((i - 11).ToString(), numFont, Brushes.Gray, 40, 445 - i * 17);
                graph_B.DrawLine(myBlackPen, 70, 450 - i * 17, 75, 450 - i * 17);

            }
            //підписи до осей B2
            for (int i = 1; i <= 21; i++)
            {
                graph_B.DrawString((i - 11).ToString(), numFont, Brushes.Gray, 450, 445 - i * 17);
                graph_B.DrawLine(myBlackPen, 425, 450 - i * 17, 430, 450 - i * 17);

            }


        }

        private void pb_Result_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(nud_A.Value);
            int b = Convert.ToInt32(nud_B.Value);
            
            dgv_PayMatrix.ColumnCount = b;
            dgv_PayMatrix.RowCount = a;
            dgv_PayMatrix.RowHeadersWidth = 70;
            dgv_PayMatrix.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Regular);
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_PayMatrix.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            //dgw_PayMatrix.Columns.Add("Column", b.ToString());
            for (int i = 0; i < b; i++)
            {
                // Set the column header names.
                dgv_PayMatrix.Columns[i].Name = "B"+(i+1).ToString();
                dgv_PayMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < a; i++)
            {
                // Set the row header names.
                dgv_PayMatrix.Rows[i].HeaderCell.Value = "A" + (i + 1).ToString();
            }

        }
        //Заповнення випадковими даними http://www.cyberforum.ru/csharp-beginners/thread997446.html
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int x = 0; x < dgv_PayMatrix.ColumnCount; x++)
            {
                for (int y = 0; y < dgv_PayMatrix.RowCount; y++)
                {
                    dgv_PayMatrix[x, y].Value = rnd.Next(Convert.ToInt32(nud_Min.Text), Convert.ToInt32(nud_Max.Text)); // Значения берутся рандомно из заданного пользователем интервала
                }

            }
        }
    }
}
