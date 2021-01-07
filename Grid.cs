using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Blockudoku
{
    class Grid
    {
        int n = 9; //broj blokova
        int velicinaBloka = 50; // velicina bloka u pixelima
        int sirina = 450;
        int visina = 450;
        int[,] ploca;

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

        public void crtajPlocu(Graphics grafika, int sirina, int visina, Color color, Color background)
        {
            grafika.Clear(background);
            grafika.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int startX = (sirina - velicinaBloka * 9) / 2;
            int startY = (visina - velicinaBloka * 9) / 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //grafika.DrawRectangle(Pens.DarkBlue, i * velicinaBloka + 5, j * velicinaBloka + 5, velicinaBloka, velicinaBloka);
                    if (ploca[i, j] > 0)
                    {
                        var brush = ploca[i, j] > 1 ? new SolidBrush(Color.DimGray) : new SolidBrush(color);
                        grafika.FillRectangle(brush, new Rectangle(i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka));
                    }

                    if (ploca[i, j] > 1)
                    {
                        Font font = new Font("Papyrus", 16, FontStyle.Bold, GraphicsUnit.Point);
                        RectangleF rect = new Rectangle(i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka);
                        //TextRenderer.DrawText(grafika, ploca[i, j].ToString(), font, rect, Color.Orange, TextFormatFlags.VerticalCenter);

                        StringFormat sf = new StringFormat();
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;

                        grafika.DrawString(ploca[i, j].ToString(), font, new SolidBrush(Color.Orange), rect, sf);
                        grafika.DrawRectangle(Pens.DarkCyan, Rectangle.Round(rect));
                    }
                    else
                    {
                        grafika.DrawRectangle(Pens.DarkCyan, i * velicinaBloka + startX, j * velicinaBloka + startY, velicinaBloka, velicinaBloka);
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

        /**
         * updates the board by removing and scoring full areas that were made in current move
         */
        public int updateBoard()
        {
            bool full = true;
            int counter = 0;
            //counts how many full areas are done at once, so that it later multiplies the given score
            int combo = 0;
            //added up penalties that are given for every obstacle that the full area contains
            int penalty = 0;
            int temp_pen = 0;

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
                    if (ploca[j, i] == 0) 
                    {
                        full = false;
                        temp_pen = 0;
                        break;
                    } else
                    {
                        temp_pen += ploca[j, i] > 1 ? ploca[j, i] : 0;           
                    }
                }
                if (full)
                {
                    //Console.WriteLine("row {0} full.", i);
                    rows[counter] = i+1; counter++; combo++;
                    penalty += temp_pen;
                }
            }
            counter = temp_pen = 0; 

            //check for full columns
            for (int i = 0; i < ploca.GetLength(0); i++)
            {
                full = true;
                for (int j = 0; j < ploca.GetLength(1); j++)
                    if (ploca[i, j] == 0) 
                    { 
                        full = false;
                        temp_pen = 0;
                        break;
                    } else
                    {
                        temp_pen += ploca[i, j] > 1 ? ploca[i, j] : 0;
                    }
                if (full)
                {
                    //Console.WriteLine("col {0} full.", i);
                    columns[counter] = i+1; counter++; combo++;
                    penalty += temp_pen;
                }
            }
            counter = temp_pen = 0;

            //check for full blocks
            for (int i = 0; i < ploca.GetLength(0); i += 3)
            {
                for (int j = 0; j < ploca.GetLength(1); j += 3)
                {
                    full = true;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            if (ploca[k, l] == 0) 
                            { 
                                full = false;
                                temp_pen = 0;
                                break; 
                            } else
                            {
                                temp_pen += ploca[k, l] > 1 ? ploca[k, l] : 0;
                            }
                            if (full == false) break;
                        }
                    if (full)
                    {
                        Console.WriteLine("block {0},{1} full.", i, j);
                        blocks[counter] = i+1; counter++;
                        blocks[counter] = j+1; counter++;
                        combo ++;
                        penalty += temp_pen;
                    }
                }
            }

            //remove full areas from the grid
            for (int a = 0; a < rows.GetLength(0); a++) if (rows[a] > 0) clearRow(rows[a]-1);
            for (int a = 0; a < columns.GetLength(0); a++) if (columns[a] > 0) clearColumn(columns[a]-1);
            for (int a = 0; a < blocks.GetLength(0); a += 2) if (blocks[a] > 0) clearBlock(blocks[a]-1, blocks[a + 1]-1);

            return 9 * combo + combo * combo - penalty;
        }

        public void clearRow(int i)
        {
            for (int j = 0; j < ploca.GetLength(0); j++) if (ploca[j, i] > 0) ploca[j, i]--;
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

        public bool isMinoPossible(Mino mino)
        {
            bool dobar = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < mino.sadrzaj.GetLength(0); k++)
                        for (int l = 0; l < mino.sadrzaj.GetLength(1); l++)
                        {
                            dobar = true;
                            if (mino.sadrzaj[k, l])
                            {
                                if (i + k - mino.minrow >= 9 || j + l - mino.mincol >= 9)
                                { 
                                    dobar = false; k = mino.sadrzaj.GetLength(0); break; 

                                } else if(ploca[i + k - mino.minrow, j + l - mino.mincol] > 0)
                                {
                                    dobar = false; k = mino.sadrzaj.GetLength(0); break;
                                }
                            }
                        }
                    if (dobar) return true;
                }
            return false;
        }

    }
}
