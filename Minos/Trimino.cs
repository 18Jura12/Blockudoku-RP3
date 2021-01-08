using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku
{
    // class which represents shape with three rectangles; vertical position
    // switch case represents rotations of shape
    class TriVertical : Mino
    {
        public TriVertical(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 2);

            switch (randNum)
            {
                case 0:
                    content[2,1] = true;
                    content[2,2] = true;
                    content[2,3] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 1:
                    content[1,2] = true;
                    content[2,2] = true;
                    content[3,2] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
            }
        }
    }

    // class which represents shape with three rectangles; diagonal position
    // switch case represents rotations of shape
    class TriDiag : Mino
    {
        public TriDiag(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 2);

            switch (randNum)
            {
                case 0:
                    content[1,1] = true;
                    content[2,2] = true;
                    content[3,3] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    content[1,3] = true;
                    content[2,2] = true;
                    content[3,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
            }
        }
    }

    // class which represents shape with three rectangles; letter L 
    // switch case represents rotations of shape
    class TriL : Mino
    {
        public TriL(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 4);

            switch (randNum)
            {
                case 0:
                    content[1,2] = true;
                    content[2,2] = true;
                    content[2,3] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
                case 1:
                    content[2,3] = true;
                    content[2,2] = true;
                    content[3,2] = true;
                    this.mincol = 2;
                    this.minrow = 2;
                    break;
                case 2:
                    content[2,1] = true;
                    content[2,2] = true;
                    content[3,2] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 3:
                    content[1,2] = true;
                    content[2,2] = true;
                    content[2,1] = true;
                    this.mincol = 1;
                    this.minrow = 1;
                    break;
            }
        }
    }
}
