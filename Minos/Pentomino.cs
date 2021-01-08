using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku.Minos
{
    // class which represents shape with five rectangles; letter T
    // switch case represents rotations of shape
    class PentoT : Mino
    { 
        public PentoT(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5,5];

            Random rand = new Random();

            switch (rand.Next(0, 4))
            {
                case 0:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[1, 3] = true;
                    break;
                case 1:
                    content[1, 3] = true;
                    content[2, 2] = true;
                    content[2, 1] = true;
                    content[2, 3] = true;
                    content[3, 3] = true;
                    break;
                case 2:
                    content[1, 2] = true;
                    content[3, 1] = true;
                    content[3, 2] = true;
                    content[3, 3] = true;
                    content[2, 2] = true;
                    break;
                case 3:
                    content[2, 2] = true;
                    content[1, 1] = true;
                    content[2, 1] = true;
                    content[3, 1] = true;
                    content[2, 3] = true;
                    break;

            }
            this.mincol = 1;
            this.minrow = 1;
        }

    }

    // class which represents shape with five rectangles; letter I
    // switch case represents rotations of shape
    class PentoI : Mino
    {

        public PentoI(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 2))
            {
                case 0:
                    content[0, 2] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[4, 2] = true;
                    this.mincol = 2;
                    this.minrow = 0;
                    break;
                case 1:
                    content[2, 0] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;
                    content[2, 4] = true;
                    this.mincol = 0;
                    this.minrow = 2;
                    break;
            }
        }
 
    }

    // class which represents shape with five rectangles; letter X
    // switch case represents rotations of shape
    class PentoX : Mino
    {

        public PentoX(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            content[2, 1] = true;
            content[2, 2] = true;
            content[2, 3] = true;
            content[1, 2] = true;
            content[3, 2] = true;

            this.mincol = 1;
            this.minrow = 1;

        }
 
    }

    // class which represents shape with five rectangles; even letter L
    // switch case represents rotations of shape
    class PentoL : Mino
    {


        public PentoL(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 4))
            {
                case 0:
                    content[1, 1] = true;
                    content[2, 1] = true;
                    content[3, 1] = true;
                    content[3, 2] = true;
                    content[3, 3] = true;
                    break;
                case 1:
                    content[3, 1] = true;
                    content[3, 2] = true;
                    content[3, 3] = true;
                    content[1, 3] = true;
                    content[2, 3] = true;
                    break;
                case 2:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[1, 3] = true;
                    content[2, 3] = true;
                    content[3, 3] = true;
                    break;
                case 3:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[1, 3] = true;
                    content[2, 1] = true;
                    content[3, 1] = true;
                    break;

            }
            this.mincol = 1;
            this.minrow = 1;
        }
  
    }

    // class which represents shape with five rectangles; letter F
    // switch case represents rotations of shape
    class PentoF : Mino
    {


        public PentoF(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 4))
            {
                case 0:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[3, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[0, 1] = true;

                    this.mincol = 1;
                    this.minrow = 0;
                    break;
                case 2:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 0] = true;

                    this.mincol = 0;
                    this.minrow = 1;
                    break;
                case 3:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[1, 3] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;

            }
        }
  
    }

    // class which represents shape with five rectangles; letter Z
    // switch case represents rotations of shape
    class PentoZ : Mino
    {


        public PentoZ(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 4))
            {
                case 0:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[3, 3] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    content[1, 3] = true;
                    content[2, 3] = true;
                    content[2, 2] = true;
                    content[2, 1] = true;
                    content[3, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 2:
                    content[1, 2] = true;
                    content[1, 3] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[3, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 3:
                    content[1, 1] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;
                    content[3, 3] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;

            }
        }
  
    }

    // class which represents shape with five rectangles; normal lettter L
    // switch case represents rotations of shape
    class PentoL1 : Mino
    {

        public PentoL1(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 8))
            {
                case 0:
                    content[0, 2] = true;
                    content[0, 3] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;

                    this.mincol = 2;
                    this.minrow = 0;
                    break;
                case 1:
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;
                    content[2, 4] = true;
                    content[3, 4] = true;

                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 2:
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[4, 2] = true;
                    content[4, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 3:
                    content[1, 0] = true;
                    content[2, 0] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;

                    this.mincol = 0;
                    this.minrow = 1;
                    break;
                case 4:
                    content[0, 2] = true;
                    content[0, 1] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;

                    this.mincol = 1;
                    this.minrow = 0;
                    break;
                case 5:
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;
                    content[2, 4] = true;
                    content[1, 4] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 6:
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[4, 2] = true;
                    content[4, 3] = true;

                    this.mincol = 2;
                    this.minrow = 1;
                    break;
                case 7:
                    content[2, 0] = true;
                    content[3, 0] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;

                    this.mincol = 0;
                    this.minrow = 2;
                    break;

            }
        }
  
    }

    // class which represents shape with five rectangles; letter T
    // switch case represents rotations of shape
    class PentoC : Mino
    {

        public PentoC(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            content = new bool[5, 5];

            Random rand = new Random();

            switch (rand.Next(0, 4))
            {
                case 0:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[1, 3] = true;
                    content[2, 3] = true;
                    content[2, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 1:
                    content[1, 1] = true;
                    content[2, 1] = true;
                    content[3, 1] = true;
                    content[1, 2] = true;
                    content[1, 3] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 2:
                    content[1, 1] = true;
                    content[2, 1] = true;
                    content[2, 2] = true;
                    content[2, 3] = true;
                    content[1, 3] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;
                case 3:
                    content[1, 1] = true;
                    content[1, 2] = true;
                    content[2, 2] = true;
                    content[3, 2] = true;
                    content[3, 1] = true;

                    this.mincol = 1;
                    this.minrow = 1;
                    break;

            }
        }

    }

}
