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
                    grafika.DrawRectangle(Pens.DarkCyan, i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka);
                    //grafika.DrawRectangle(Pens.DarkBlue, i * velicinaBloka + 5, j * velicinaBloka + 5, velicinaBloka, velicinaBloka);
                    if (ploca[i, j] > 0)
                    {
                        grafika.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka));

                    }
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

        public int[,] Ploca
        {
            get
            {
                return ploca;
            }
        }

        public void putOnBoard(int col, int row, Mino mino)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mino.sadrzaj[i, j])
                    {
                        ploca[col + i, row + j]++;
                    }
                }
            }
        }

        public void updateBoard()
        {
            bool full = true;
            int counter = 0;

            //remembers which row/col/block is full
            int[] rows = new int[9];
            int[] columns = new int[9];
            int[] blocks = new int[18];

            //check for full rows
            for (int i = 0; i < ploca.GetLength(0); i++)
            {
                full = true;
                for (int j = 0; j < ploca.GetLength(1); j++)
                {
                    if (ploca[i, j] == 0) { full = false; break; }
                }
                if (full)
                {
                    rows[counter] = i; counter++;
                }
            }
            counter = 0;

            //check for full columns
            for (int i = 0; i < ploca.GetLength(0); i++)
            {
                full = true;
                for (int j = 0; j < ploca.GetLength(1); j++)
                    if (ploca[j, i] == 0) { full = false; break; }
                if (full)
                {
                    columns[counter] = i; counter++;
                }
            }
            counter = 0;

            //check for full blocks
            for (int i = 0; i < ploca.GetLength(0); i += 3)
            {
                for (int j = 0; j < ploca.GetLength(1); j += 3)
                {
                    full = true;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            if (ploca[k, l] == 0) { full = false; break; }
                            if (full == false) break;
                        }
                    if (full)
                    {
                        blocks[counter] = i; counter++;
                        blocks[counter] = j; counter++;
                    }
                }
            }

            //remove full areas from the grid
            for (int a = 0; a < rows.GetLength(0); a++) if (rows[a] > 0) clearRow(rows[a]);
            for (int a = 0; a < columns.GetLength(0); a++) if (columns[a] > 0) clearColumn(columns[a]);
            for (int a = 0; a < blocks.GetLength(0); a += 2) if (blocks[a] > 0) clearBlock(blocks[a], blocks[a + 1]);
        }

        public void clearRow(int i)
        {
            for (int j = 0; j < ploca.GetLength(0); j++) if (ploca[i, j] > 0) ploca[i, j]--;
        }

        public void clearColumn(int i)
        {
            for (int j = 0; j < ploca.GetLength(1); j++) if (ploca[i, j] > 0) ploca[i, j]--;
        }

        public void clearBlock(int i, int j)
        {
            for (int k = i; k < i + 3; k++)
                for (int l = j; l < j + 3; l++) if (ploca[k, l] > 0) ploca[k, l]--;
        }

    }
}
