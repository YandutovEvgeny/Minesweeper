using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinescaperGame
{
    public partial class Form1 : Form
    {
        MinescaperGame minescaperGame;
        public Form1()
        {
            InitializeComponent();
        }
        void Refreshgrid()
        {
            dataGridView1.ColumnCount = minescaperGame.Size;    //кол-во колонок = размеру игрового поля
            dataGridView1.RowCount = minescaperGame.Size;    //кол-во строк = размеру игрового поля
            for(int i=0; i<minescaperGame.Size;i++)
            {
                dataGridView1.Rows[i].Height = 50;          //Устанавливаем ширину и высоту ячеек 
                dataGridView1.Columns[i].Width = 50;
            }
            Height = 50 * minescaperGame.Size + 70;
            Width = 50 * minescaperGame.Size + 70;
        }

        void ShowData()
        {
            //В массиве идёт вначале строка столбец, у dataGridView1 вначале столбец потом строка
            for (int col = 0; col < minescaperGame.Size; col++)   //столбец
                for (int row = 0; row < minescaperGame.Size; row++)   //строка
                    dataGridView1[col, row].Value = minescaperGame.Area[row, col].ToString();
        }

        private void новичокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minescaperGame = new MinescaperGame(10, 5);
            Refreshgrid();
            ShowData();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
