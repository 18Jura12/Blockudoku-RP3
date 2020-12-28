using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku
{
    class DoVertical : Mino
    {
        public DoVertical(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 2);

            switch (randNum)
            {
                case 0:
                    sadrzaj[2,2] = true;
                    sadrzaj[2,3] = true;
                    break;
                case 1:
                    sadrzaj[2,2] = true;
                    sadrzaj[3,2] = true;
                    break;
            }

            this.minrow = 2;
            this.mincol = 2;
        }
    }

    class DoDiag : Mino
    {
        public DoDiag(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 2);

            switch (randNum)
            {
                case 0:
                    sadrzaj[2,2] = true;
                    sadrzaj[3,1] = true;
                    this.mincol = 1;
                    this.minrow = 2;
                    break;
                case 1:
                    sadrzaj[1,2] = true;
                    sadrzaj[2,3] = true;
                    this.mincol = 2;
                    this.minrow = 1;
                    break;
            }
        }
    }
}
