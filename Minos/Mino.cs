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
        //Content of object represented by 5x5 matrix;
        public bool[,] content;
        //size of block
        int blockSize;
        //position on Mino; important when mouse moves
        int x;
        int y;
        //position where Mino is created
        int startX;
        int startY;
        //true if Mino isn't on board, otherwise is false
        bool notOnBoard;
        //true if Mino is selected by mouse
        bool isSelected;
        //smallest row where Mino has content in 5x5 matrix
        public int minrow;
        //smallest column where Mino has content in 5x5 matrix
        public int mincol;

        public Mino(int blockSize, int X, int Y)
        {
            this.startX = X;
            this.startY = Y;
            this.x = X;
            this.y = Y;
            this.blockSize = blockSize;
            this.content = new bool[5, 5];
            notOnBoard = true;
            isSelected = false;
        }

        /*
         *  Draws Mino on form
         */
        public void drawMino(Graphics grafika, int startX, int startY, int size, Color color)
        {
            SolidBrush myBrush = new System.Drawing.SolidBrush(color);

            for (int i = 0; i < content.GetLength(0); i++)
            {
                for (int j = 0; j < content.GetLength(1); j++)
                {
                    if (content[i, j])
                    {
                        Rectangle rect;
                        if(isSelected)
                        {
                            rect = new Rectangle(i * blockSize + x, j * blockSize + y, blockSize, blockSize);
                        } else
                        {
                            rect = new Rectangle(i * size + startX, j * size + startY, size, size);
                        }

                        grafika.FillRectangle(myBrush, rect);
                        grafika.DrawRectangle(Pens.AntiqueWhite, rect);
                    }
                }
            }
        }

        /*
         * Checks if coordinates (x,y) are on item
         */
        public bool onItem( int x, int y)
        {
            for (int i = 0; i < content.GetLength(0) ; i++)
            {
                for (int j = 0; j < content.GetLength(1); j++)
                {
                    if (content[i, j])
                    {
                        // if coordinates are over Mino
                        if (x >= (startX + i * blockSize) && x <= (startX + (i + 1) * blockSize) && y >= (startY + j * blockSize) && y <= (startY + (j + 1) * blockSize))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /*
         * updates coordinates of the selected Mino
         */
        public void moveMino( int x, int y, int spaceX, int spaceY)
        {
            // new position of Mino (old position minus (longitude of user click and old position)
            int moveX = x - spaceX;
            int moveY = y - spaceY;

            this.x = moveX;
            this.y = moveY;
        }

        /*
         * move selected Mino to its start position
         */
        public void resetPosition()
        {
            this.x = this.StartX;
            this.y = this.StartY;
            isSelected = false;
        }

        public bool NotOnBoard
        {
            get
            {
                return notOnBoard;
            }
            set
            {
                notOnBoard = value;
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

        public int StartX
        {
            get
            {
                return startX;
            }
            set
            {
                startX = value;
            }
        }

        public int StartY
        {
            get
            {
                return startY;
            }
            set
            {
                startY = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
            }
        }
    }
}
