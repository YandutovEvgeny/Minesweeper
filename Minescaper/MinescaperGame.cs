using System;
using System.Collections.Generic;
using System.Text;

namespace MinescaperGame
{
    class MinescaperGame
    {
        public int[,] Area { get; private set; }       //Поле
        public int Size { get; private set; }          //Размер поля
        public int MinesCount { get; private set; }    //Количество мин
        public MinescaperGame()
        {
            Size = 10;
            MinesCount = 10;
            Area = new int[Size, Size];
            GenerateArea();
        }
        public MinescaperGame(int Size, int MinesCount)
        {
            this.Size = Math.Abs(Size);
            this.MinesCount = Math.Abs(MinesCount);

            if (MinesCount >= Size * Size)
                this.MinesCount = Size;

            Area = new int[Size, Size];
            GenerateArea();
        }
        private void GenerateArea()
        {
            Random random = new Random();
            for (int i = 0; i < MinesCount;)
            {
                int x = random.Next(Size);
                int y = random.Next(Size);
                if(Area[x,y]<10)
                {
                    Area[x, y] = 50;
                    i++;
                    if(x>0)                     Area[x - 1, y]++;
                    if(x<Size-1)                Area[x + 1, y]++;

                    if(x>0 && y>0)              Area[x - 1, y-1]++;
                    if(x<Size-1 && y>0)         Area[x + 1, y-1]++;
                    if(y>0)                     Area[x, y-1]++;
                    
                    if (x > 0 && y<Size-1)      Area[x - 1, y + 1]++;
                    if(x<Size-1 && y<Size-1 )   Area[x + 1, y+1]++;
                    if(y<Size-1)                Area[x, y+1]++;
                }
            }
        }
    }
}
