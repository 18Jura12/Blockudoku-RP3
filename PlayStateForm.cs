using Blockudoku.Minos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockudoku
{
    public partial class PlayStateForm : StateForm
    {
        List<Mino> minos;
        Grid net;
        Mino selected;
        int spaceX;
        int spaceY;

        public PlayStateForm()
        {
            InitializeComponent();
            minos = makeMinos();
            net = new Grid();
            selected = null;
            //od klika za selected
            spaceX = 0;
            spaceY = 0;
        }

        List<Mino> makeMinos()
        {
            List<Mino> minos = new List<Mino>(3);

            int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);

            Random rand = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            Random rand4 = new Random();

            for (int i = 0; i < 3; i++)
            {
                //minos.Add(new Mono(45, 500, i*150));

                int randNum = rand.Next(0, 4);
                //MessageBox.Show(randNum.ToString());

                switch (randNum)
                {
                    case 0:
                        //minos.Add(new Mono(50, startX[i], startY));
                        minos.Add(new Mono(blockSize, 500, i * 200));
                        break;
                    case 1:
                        int randNum2 = rand2.Next(0, 2);
                        switch (randNum2)
                        {
                            case 0:
                                minos.Add(new DoVertical(blockSize, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new DoDiag(blockSize, 500, i * 200));
                                break;
                        }
                        break;
                    case 2:
                        int randNum3 = rand3.Next(0, 3);
                        switch (randNum3)
                        {
                            case 0:
                                minos.Add(new TriVertical(blockSize, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new TriDiag(blockSize, 500, i * 200));
                                break;
                            case 2:
                                minos.Add(new TriL(blockSize, 500, i * 200));
                                break;
                        }
                        break;
                    case 3:
                        int randNum4 = rand4.Next(0, 4);
                        switch (randNum4)
                        {
                            case 0:
                                minos.Add(new TetroVertical(blockSize, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new TetroL(blockSize, 500, i * 200));
                                break;
                            case 2:
                                minos.Add(new TetroZ(blockSize, 500, i * 200));
                                break;
                            case 3:
                                minos.Add(new TetroT(blockSize, 500, i * 200));
                                break;
                        }
                        break;
                }

            }

            return minos;
        }

        /*
        private void pictureBox_game_Paint(object sender, PaintEventArgs e)
        {            
            SuspendLayout();
            net.crtajPlocu(e.Graphics, pictureBox_game.Width, pictureBox_game.Height);
            ResumeLayout();

            pictureBox_game.Invalidate();
        }
        */

        private void pictureBox_grid_Paint(object sender, PaintEventArgs e)
        {
            SuspendLayout();
            net.crtajPlocu(e.Graphics, pictureBox_grid.Width, pictureBox_grid.Height);

            if (minos == null)
            {
                MessageBox.Show("null vrijednost");
            }
            else
            {
                //MessageBox.Show(minos[2].Stavljen.ToString());
                if (!minos[0].Stavljen && !minos[1].Stavljen && !minos[2].Stavljen)
                {
                    minos = makeMinos();
                }

                //smaller than original 15-->18
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);

                //int startY = (pictureBox_grid.Height - blockSize * 5) / 2;

                //int startY = (pictureBox_grid.Height - blockSize2 * 9);
                //int startY = (visina - velicinaBloka * 9) / 5; iz grida
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;

                if (minos[0].Stavljen) minos[0].crtaj(e.Graphics, startX, startY, blockSize);
                if (minos[1].Stavljen) minos[1].crtaj(e.Graphics, startX + 5 * blockSize, startY, blockSize);
                if (minos[2].Stavljen) minos[2].crtaj(e.Graphics, startX + 10 * blockSize, startY, blockSize);
            }

            ResumeLayout();

            pictureBox_grid.Invalidate();
        }

        private void PlayStateForm_SizeChanged(object sender, EventArgs e)
        {
            

            if ( net != null )
            {
                //Console.WriteLine(b.GetValue(0).ToString());
                pictureBox_grid.Width = Convert.ToInt32(tableLayoutPanel_game.GetColumnWidths().GetValue(1));
                pictureBox_grid.Height = Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

                // 2/3 pictureBox / 9
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) * 2 / 27) - 2;
                net.Sirina = blockSize * 9;
                net.Visina = blockSize * 9;
                net.VelicinaBloka = blockSize;
                
            }

            // mozda dodat još i mijenjanje startX i startY od svakog minos-a; PROVJERI!!
            if( minos != null )
            {
                pictureBox_grid.Width = Convert.ToInt32(tableLayoutPanel_game.GetColumnWidths().GetValue(1));
                pictureBox_grid.Height = Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

                //smaller than original 15-->18
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;
                for ( int i = 0; i < minos.Count; ++i )
                {
                    if( minos[i].Stavljen )
                    {
                        minos[i].BlockSize = blockSize;
                        minos[i].StartX = startX + i * 5 * blockSize;
                        minos[i].StartY = startY;
                        minos[i].X = startX + i * 5 * blockSize;
                        minos[i].Y = startY;
                    }
                }
            } 
        }

        private void pictureBox_grid_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            if( e.Button == MouseButtons.Left)
            {
                //odabran je neki mino
                if( selected != null )
                {
                    selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                } else
                {
                     
                    //još nije odabran oblik
                    if (minos[0].onItem(e.Location.X, e.Location.Y) && minos[0].Stavljen )
                    {
                        selected = minos[0];
                        spaceX = e.Location.X - minos[0].StartX;
                        spaceY = e.Location.Y - minos[0].StartY;
                        selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                        Console.WriteLine("LIJEVA TIPKA MISA.");
                    }

                    if (minos[1].onItem(e.Location.X, e.Location.Y) && minos[1].Stavljen )
                    {
                        selected = minos[1];
                        spaceX = e.Location.X - minos[1].StartX;
                        spaceY = e.Location.Y - minos[1].StartY;
                        //selected.moveMino(e.Location.X, e.Location.Y);
                        Console.WriteLine("LIJEVA TIPKA MISA.");
                    }

                    if (minos[2].onItem(e.Location.X, e.Location.Y) && minos[2].Stavljen )
                    {
                        selected = minos[2];
                        spaceX = e.Location.X - minos[2].StartX;
                        spaceY = e.Location.Y - minos[2].StartY;
                        //selected.moveMino(e.Location.X, e.Location.Y);
                        Console.WriteLine("LIJEVA TIPKA MISA.");
                    }
                }
                
            }
            */
        }

        private void pictureBox_grid_MouseUp(object sender, MouseEventArgs e)
        {
            //mis drzi neki mino
            if( selected != null )
            {
                int startX = (pictureBox_grid.Width - net.VelicinaBloka * 9) / 2;
                int startY = (pictureBox_grid.Height - net.VelicinaBloka * 9) / 5;
                //provjera dal je unutar ploce
                if ( e.Location.X >= startX && e.Location.X <= (startX + net.Sirina) && e.Location.Y >= startY && e.Location.Y <= (startY + net.Visina))
                {
                    checkPutOnBoard(e.Location.X, e.Location.Y);
                    Console.WriteLine("unutar");
                } else
                {
                    selected.resetPosition();
                }
            }
            selected = null;
            spaceX = 0;
            spaceY = 0;
        }

        private void pictureBox_grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                if (selected != null)
                {
                    selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                }
                else
                {

                    //još nije odabran oblik
                    if (minos[0].onItem(e.Location.X, e.Location.Y) && minos[0].Stavljen)
                    {
                        selected = minos[0];
                        spaceX = e.Location.X - minos[0].StartX;
                        spaceY = e.Location.Y - minos[0].StartY;
                        selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                        //Console.WriteLine("LIJEVA TIPKA MISA.");
                    }

                    if (minos[1].onItem(e.Location.X, e.Location.Y) && minos[1].Stavljen)
                    {
                        selected = minos[1];
                        spaceX = e.Location.X - minos[1].StartX;
                        spaceY = e.Location.Y - minos[1].StartY;
                        selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                        //Console.WriteLine("LIJEVA TIPKA MISA.");
                    }

                    if (minos[2].onItem(e.Location.X, e.Location.Y) && minos[2].Stavljen)
                    {
                        selected = minos[2];
                        spaceX = e.Location.X - minos[2].StartX;
                        spaceY = e.Location.Y - minos[2].StartY;
                        selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                        //Console.WriteLine("LIJEVA TIPKA MISA.");
                    }
                }
            }
        }

        private void pictureBox_grid_MouseClick(object sender, MouseEventArgs e)
        {
            spaceX = e.X;
            spaceY = e.Y;
        }

        private void checkPutOnBoard(int clickX, int clickY)
        {
            bool possible = true;

            //mino ispusten na tim retcima i stupcima
            int row = (clickY - (pictureBox_grid.Height - net.Visina) / 5) / net.VelicinaBloka;
            int col = (clickX - (pictureBox_grid.Width - net.Sirina) / 2) / net.VelicinaBloka;

            //location of the begining of Mino matrix based on the mouseClick location
            int rowS = (selected.Y - (pictureBox_grid.Height - net.Visina) / 5);
            int colS = (selected.X - (pictureBox_grid.Width - net.Sirina) / 2);
            rowS = rowS < 0 ? rowS / net.VelicinaBloka - 1 : rowS / net.VelicinaBloka;
            colS = colS < 0 ? colS / net.VelicinaBloka - 1 : colS / net.VelicinaBloka;

            for (int i = 0; i < selected.sadrzaj.GetLength(0); ++i)
            {
                for (int j = 0; j < selected.sadrzaj.GetLength(1); ++j)
                {
                    if (selected.sadrzaj[i, j])
                    {
                        if (i + colS > 8 || i + colS < 0 || j + rowS > 8 || j + rowS < 0 || net.Ploca[i + colS, j + rowS] == 1)
                        {
                            possible = false;
                        }
                    }
                }
            }

            if (possible)
            {
                selected.Stavljen = false;
                net.putOnBoard(colS, rowS, selected);
                net.updateBoard();
            }
            else
            {
                selected.resetPosition();
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

        /*
        private void pictureBox_shapes_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.AntiqueWhite);
            pictureBox_shapes.Update();
            SuspendLayout();

            if (minos == null)
            {
                MessageBox.Show("null vrijednost");
            }
            else
            {
                //MessageBox.Show(minos[2].Stavljen.ToString());
                if (!minos[0].Stavljen && !minos[1].Stavljen && !minos[2].Stavljen)
                {
                    minos = makeMinos();
                }

                int blockSize;                

                if (pictureBox_shapes.Width < pictureBox_shapes.Height)
                {
                    // 4/5 groupBox / 15
                    blockSize = Convert.ToInt32(Math.Min(pictureBox_shapes.Width, pictureBox_shapes.Height) * 4 / 75);                    
                } else
                {
                    // 4/5 groupBox / 5
                    blockSize = Convert.ToInt32(Math.Min(pictureBox_shapes.Width, pictureBox_shapes.Height) * 4 / 25);

                    // out of border
                    if (blockSize * 15 > pictureBox_shapes.Width )
                    {
                        blockSize = pictureBox_shapes.Width / 15;
                    }
                }

                int startY = (pictureBox_shapes.Height - blockSize * 5) / 2;
                int startX = (pictureBox_shapes.Width - blockSize * 15) / 2;

                minos[0].crtaj(e.Graphics, startX, startY, blockSize);
                minos[1].crtaj(e.Graphics, startX + 5 * blockSize, startY, blockSize);
                minos[2].crtaj(e.Graphics, startX + 10 * blockSize, startY, blockSize);
            }

            ResumeLayout();
            pictureBox_shapes.Invalidate();

        }
        */
    }
}
