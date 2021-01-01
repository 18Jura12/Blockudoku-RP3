using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blockudoku
{
    class Grid
    {
        int n = 9; //broj blokova
        int velicinaBloka = 50; // velicina bloka u pixelima
        int sirina = 450;
        int visina = 450;
        int[,] ploca;
        int rezultat = 0;

        public Grid()
        {
            this.ploca = new int[9,9];
        }

        public Grid( int n, int velicinaBloka, int sirina, int visina )
        {
            this.n = n;
            this.velicinaBloka = velicinaBloka;
            this.sirina = sirina;
            this.visina = visina;
            this.ploca = new int[n, n];
        }

        public void crtajPlocu(Graphics grafika, int sirina, int visina)
        {
            grafika.Clear(Color.White);
            grafika.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int startX = (sirina - velicinaBloka * 9) / 2;
            int startY = (visina - velicinaBloka * 9) / 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grafika.DrawRectangle(Pens.DarkBlue, i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka);
                    //grafika.DrawRectangle(Pens.DarkBlue, i * velicinaBloka + 5, j * velicinaBloka + 5, velicinaBloka, velicinaBloka);
                }
            }
        }

        public int BrojBlokova
        {
            get
            {
                return n;
            }
        }

        public int VelicinaBloka
        {
            get
            {
                return velicinaBloka;
            }
            set
            {
                velicinaBloka = value;
            }
        }

        public int Sirina
        {
            get
            {
                return sirina;
            }
            set
            {
                sirina = value;
            }
        }

        public int Visina
        {
            get
            {
                return visina;
            }
            set
            {
                visina = value;
            }
        }

        public int Rezultat
        {
            get;
        }
    }
}
