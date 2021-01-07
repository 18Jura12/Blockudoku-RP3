using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockudoku.Minos
{
    // class which represents shape with one rectangle
    class Mono : Mino
    {
        public Mono(int blockSize, int X, int Y) : base(blockSize, X, Y)
        {
            sadrzaj[2, 2] = true;

            this.minrow = 2;
            this.mincol = 2;
        }

    }
}
