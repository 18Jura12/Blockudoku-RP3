﻿using System;
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
        //pocetna pozicija za crtanje 5x5 mreze
        int startX;
        int startY;
        //ako jos nije stavljen na plocu je true, inace false
        bool stavljen;
        //je li označen od strane miša ili ne
        bool isSelected;
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
            stavljen = true;
            isSelected = false;
        }

        public void crtaj(Graphics grafika, int startX, int startY, int size, Color color)
        {
            SolidBrush myBrush = new System.Drawing.SolidBrush(color);

            for (int i = 0; i < sadrzaj.GetLength(0); i++)
            {
                for (int j = 0; j < sadrzaj.GetLength(1); j++)
                {
                    if (sadrzaj[i, j])
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
                    /*else
                    {
                        Rectangle rect = new Rectangle(i * size + startX, j * size + startY, size, size);
                        //Rectangle rect = new Rectangle(i * blockSize + x, j * blockSize + y, blockSize, blockSize);
                        grafika.DrawRectangle(Pens.AntiqueWhite, rect);
                    }*/
                }
            }
        }

        // checks if coordinates (x,y) are on item
        public bool onItem( int x, int y)
        {
            for (int i = 0; i < sadrzaj.GetLength(0) ; i++)
            {
                for (int j = 0; j < sadrzaj.GetLength(1); j++)
                {
                    if (sadrzaj[i, j])
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

        // updates coordinates of the selected Mino
        public void moveMino( int x, int y, int spaceX, int spaceY)
        {
            // new position of Mino (old position minus (longitude of user click and old position)
            int moveX = x - spaceX;
            int moveY = y - spaceY;

            this.x = moveX;
            this.y = moveY;
        }

        // move selected Mino to its start position
        public void resetPosition()
        {
            this.x = this.StartX;
            this.y = this.StartY;
            isSelected = false;
        }

        public bool Stavljen
        {
            get
            {
                return stavljen;
            }
            set
            {
                stavljen = value;
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
