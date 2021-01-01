using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku
{
    abstract class Mino
    {

        //sadrzaj objekta, svi su smjesetni u matrici 5x5, na onim mjestim na kojim se nalazi blok je true
        public bool[,] sadrzaj;
        //velicina bloka
        int blockSize;
        //trenutna pozicija
        int x;
        int y;
        //pocetna pozcija
        int startX;
        int startY;
        //ako jos nije stavljen na plocu je true, inace false OKRENI!!!!
        bool stavljen = true;
        //najmanji redak u kojem se nalazi neki blok u 5x5 matrici
        public int minrow;
        //najmanji stupac u kojem se nalazi neki blok u 5x5 matrici
        public int mincol;

        public Mino(int blockSize, int X, int Y)
        {
            this.startX = X;
            this.startY = Y;
            this.x = X;
            this.y = Y;
            this.blockSize = blockSize;
            this.sadrzaj = new bool[5, 5];
        }

        public void crtaj(Graphics grafika, int sirina, int visina)
        {
            //int nXs = X;
            //int nYs = Y;
            //int nY = nYs;
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkBlue);
            int velicina = Convert.ToInt32(Math.Min(sirina, visina) * 2 / 36);
            int pocetakSirina = Convert.ToInt32(sirina * 3 / 5);
            int pocetakVisina = Convert.ToInt32(visina * 3 / 5);
            Console.WriteLine("sirina: " + sirina.ToString());
            Console.WriteLine("visina: " + visina.ToString());
            Console.WriteLine("pocetakSirina: " + pocetakSirina.ToString());
            Console.WriteLine("pocetakVisina: " + pocetakVisina.ToString());
            Console.WriteLine("velicina: " + velicina.ToString());
            //int a = Convert.ToInt32(startX/pocetakSirina*startX)
            for (int i = 0; i < sadrzaj.GetLength(0); i++)
            {
                //int nX = nXs;
                for (int j = 0; j < sadrzaj.GetLength(1); j++)
                {

                    if (sadrzaj[i, j])
                    {
                        int a = Convert.ToInt32(startX / pocetakSirina * startX);
                        int b = Convert.ToInt32(startY / pocetakVisina * startY);
                        Rectangle rect = new Rectangle(i * velicina + startX, j * velicina + startY, velicina, velicina);
                        //Rectangle rect = new Rectangle(i * velicina + pocetakSirina, j * velicina + pocetakVisina, velicina, velicina);
                        //Rectangle rect = new Rectangle(i * velicina + a, j * velicina + b, velicina, velicina);

                        //grafika.DrawRectangle(Pens.DarkBlue, i * blockSize + startX, j * blockSize + startY, blockSize, blockSize);
                        grafika.FillRectangle(myBrush, rect);
                        grafika.DrawRectangle(Pens.AntiqueWhite, rect);
                    }
                    //nX = nX + 42;
                }
                //nY = nY + 42;
            }
        }

        public bool Stavljen
        {
            get
            {
                return stavljen;
            }
        }
    }
}
