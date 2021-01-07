using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku
{
    // class which represents shape with four rectangles; letter T
    // switch case represents rotations of shape
    class TetroT : Mino
    {
        public TetroT(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 4);

            switch (randNum)
            {
                case 0:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
                case 2:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[2,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 3:
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    sadrzaj[3,2] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
            }
        }


    }

    // class which represents shape with four rectangles; letter Z
    // switch case represents rotations of shape
    class TetroZ : Mino
    {
        public TetroZ(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 4);

            switch (randNum)
            {
                case 0:
                    sadrzaj[1, 1] = true;
                    sadrzaj[1, 2] = true;
                    sadrzaj[2, 2] = true;
                    sadrzaj[2, 3] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    sadrzaj[2, 1] = true;
                    sadrzaj[3, 1] = true;
                    sadrzaj[1, 2] = true;
                    sadrzaj[2, 2] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 2:
                    sadrzaj[3,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    sadrzaj[3,2] = true;

                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 3:
                    sadrzaj[1,1] = true;
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
            }
        }
    }

    // class which represents shape with four rectangles; vertical position
    // switch case represents rotations of shape
    class TetroVertical : Mino
    {
        public TetroVertical(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 2);

            switch (randNum)
            {
                case 0:
                    sadrzaj[0, 2] = true;
                    sadrzaj[1, 2] = true;
                    sadrzaj[2, 2] = true;
                    sadrzaj[3, 2] = true;
                    this.mincol = 2;
                    this.minrow = 0;
                    break;
                case 1:
                    sadrzaj[2, 0] = true;
                    sadrzaj[2, 1] = true;
                    sadrzaj[2, 2] = true;
                    sadrzaj[2, 3] = true;
                    this.mincol = 0;
                    this.minrow = 2;
                    break;
            }
        }
    }

    // class which represents shape with four rectangles; letter L
    // switch case represents rotations of shape
    class TetroL : Mino
    {
        public TetroL(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 8);

            switch (randNum)
            {
                case 0:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[3,3] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
                case 1:
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,1] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 2:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[1,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 3:
                    sadrzaj[3,3] = true;
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 4:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[3,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 5:
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    sadrzaj[1,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 6:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    sadrzaj[1,3] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
                case 7:
                    sadrzaj[1,3] = true;
                    sadrzaj[2,1] = true;
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
            }
        }
    }

}
