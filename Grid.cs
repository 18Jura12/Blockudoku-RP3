using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Blockudoku
{
    /*
     * Class represents the sudoku grid on witch the game is being played
     */
    class Grid
    {
        int n = 9; // number of blocks in grid
        int blockSize = 50; // blockSize
        int width = 450; //width
        int height = 450; //height
        int[,] net; // matrix which represents grid

        public Grid()
        {
            this.net = new int[9,9];
        }

        public Grid( int n, int velicinaBloka, int sirina, int visina )
        {
            this.n = n;
            this.blockSize = velicinaBloka;
            this.width = sirina;
            this.height = visina;
            this.net = new int[n, n];
        }

        /*
         * Draws grid on PlayStateForm
         */
        public void drawGrid(Graphics graphics, int width, int height, Color color, Color background)
        {
            graphics.Clear(background);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // centered grid
            int startX = (width - blockSize * 9) / 2;
            int startY = (height - blockSize * 9) / 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //draw block-separating lines on grid
                    if(i % 3 == 0)
                    {
                        Pen pen = new Pen(Color.DarkCyan, 3);
                        graphics.DrawLine(pen, startX + i * blockSize, startY + j * blockSize, startX + i * blockSize, startY + (j + 1) * blockSize);
                        graphics.DrawLine(pen, startX + j * blockSize, startY + i * blockSize, startX + (j + 1) * blockSize, startY + i * blockSize);
                    }
                    else if(i == 8)
                    {
                        Pen pen = new Pen(Color.DarkCyan, 3);
                        graphics.DrawLine(pen, startX + (i + 1) * blockSize, startY + j * blockSize, startX + (i + 1) * blockSize, startY + (j + 1) * blockSize);
                        graphics.DrawLine(pen, startX + j * blockSize, startY + (i + 1) * blockSize, startX + (j + 1) * blockSize, startY + (i + 1) * blockSize);
                    }

                    // if grid contains block; fill rectangle
                    if (net[i, j] > 0)
                    {
                        var brush = net[i, j] > 1 ? new SolidBrush(Color.DimGray) : new SolidBrush(color);
                        graphics.FillRectangle(brush, new Rectangle(i * blockSize + startX, j * blockSize + startY, blockSize, blockSize));
                    }

                    // grid contains obstacle; fill rectangle
                    if (net[i, j] > 1)
                    {
                        Font font = new Font("Papyrus", 16, FontStyle.Bold, GraphicsUnit.Point);
                        RectangleF rect = new Rectangle(i * blockSize + startX, j * blockSize + startY, blockSize, blockSize);

                        StringFormat sf = new StringFormat();
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;

                        graphics.DrawString(net[i, j].ToString(), font, new SolidBrush(Color.Orange), rect, sf);
                        graphics.DrawRectangle(Pens.DarkCyan, Rectangle.Round(rect));
                    }
                    // empty cell in grid; no fill
                    else
                    {
                        graphics.DrawRectangle(Pens.DarkCyan, i * blockSize + startX, j * blockSize + startY, blockSize, blockSize);
                    }
                }
            }
        }

        public int BlockNumber
        {
            get
            {
                return n;
            }
        }

        public int BlockSize
        {
            get
            {
                return blockSize;
            }
            set
            {
                blockSize = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int[,] Net
        {
            get
            {
                return net;
            }
        }

        /*
         * updates board with selected Mino
         */
        public void putOnBoard(int col, int row, Mino mino)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mino.content[i, j])
                    {
                        net[col + i, row + j]++;
                    }
                }
            }
        }

        /*
         * updates the board by removing and scoring full areas that were made in current move
         */
        public int updateBoard(ref int combo, ref int penalty)
        {
            bool full = true;
            int counter = 0;
            //counts how many full areas are done at once, so that it later multiplies the given score
            combo = 0;
            //added up penalties that are given for every obstacle that the full area contains
            penalty = 0;
            int temp_pen = 0;

            //remembers which row/col/block is full
            int[] rows = new int[9];
            int[] columns = new int[9];
            int[] blocks = new int[18];

            //check for full rows
            for (int i = 0; i < net.GetLength(0); i++)
            {
                full = true;
                for (int j = 0; j < net.GetLength(1); j++)
                {
                    if (net[j, i] == 0) 
                    {
                        full = false;
                        temp_pen = 0;
                        break;
                    } else
                    {
                        temp_pen += net[j, i] > 1 ? net[j, i] : 0;           
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
            for (int i = 0; i < net.GetLength(0); i++)
            {
                full = true;
                for (int j = 0; j < net.GetLength(1); j++)
                    if (net[i, j] == 0) 
                    { 
                        full = false;
                        temp_pen = 0;
                        break;
                    } else
                    {
                        temp_pen += net[i, j] > 1 ? net[i, j] : 0;
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
            for (int i = 0; i < net.GetLength(0); i += 3)
            {
                for (int j = 0; j < net.GetLength(1); j += 3)
                {
                    full = true;
                    for (int k = i; k < i + 3; k++)
                        for (int l = j; l < j + 3; l++)
                        {
                            if (net[k, l] == 0) 
                            { 
                                full = false;
                                temp_pen = 0;
                                break; 
                            } else
                            {
                                temp_pen += net[k, l] > 1 ? net[k, l] : 0;
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

            //update current score
            return 9 * combo + combo * combo - penalty;
        }

        //clears full rows by their index on the net
        public void clearRow(int i)
        {
            for (int j = 0; j < net.GetLength(0); j++) if (net[j, i] > 0) net[j, i]--;
        }

        //clears full columns by their index on the net
        public void clearColumn(int i)
        {
            for (int j = 0; j < net.GetLength(1); j++) if (net[i, j] > 0) net[i, j]--;
        }

        //clears full blocks by their index on the net ((0, 0) - (2, 2))
        public void clearBlock(int i, int j)
        {
            for (int k = i; k < i + 3; k++)
                for (int l = j; l < j + 3; l++) if (net[k, l] > 0) net[k, l]--;
        }

        /*
         * checks whether the given mino is possible to be put on current net
         */
        public bool isMinoPossible(Mino mino)
        {
            bool dobar = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < mino.content.GetLength(0); k++)
                        for (int l = 0; l < mino.content.GetLength(1); l++)
                        {
                            dobar = true;
                            if (mino.content[k, l])
                            {
                                //if mino goes outside the net area, it cannot be put there,
                                //else if something is already there, it cannot be put there
                                if (i + k - mino.minrow >= 9 || j + l - mino.mincol >= 9)
                                { 
                                    dobar = false; k = mino.content.GetLength(0); break; 

                                } else if(net[i + k - mino.minrow, j + l - mino.mincol] > 0)
                                {
                                    dobar = false; k = mino.content.GetLength(0); break;
                                }
                            }
                        }
                    if (dobar) return true;
                }
            return false;
        }

    }
}
