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

        public PlayStateForm()
        {
            InitializeComponent();
            minos = makeMinos();
            net = new Grid();
        }

        List<Mino> makeMinos()
        {
            List<Mino> minos = new List<Mino>(3);

            int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 20);

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

                //smaller than original 15-->20
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 20);

                //int startY = (pictureBox_grid.Height - blockSize * 5) / 2;

                //int startY = (pictureBox_grid.Height - blockSize2 * 9);
                //int startY = (visina - velicinaBloka * 9) / 5; iz grida
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;

                minos[0].crtaj(e.Graphics, startX, startY, blockSize);
                minos[1].crtaj(e.Graphics, startX + 5 * blockSize, startY, blockSize);
                minos[2].crtaj(e.Graphics, startX + 10 * blockSize, startY, blockSize);
            }

            ResumeLayout();

            pictureBox_grid.Invalidate();
        }

        private void PlayStateForm_SizeChanged(object sender, EventArgs e)
        {
            if( net != null )
            {
                // 2/3 pictureBox / 9
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) * 2 / 27) - 2;
                net.Sirina = blockSize * 9;
                net.Visina = blockSize * 9;
                net.VelicinaBloka = blockSize;
            }

            // mozda dodat još i mijenjanje startX i startY od svakog minos-a; PROVJERI!!
            if( minos != null )
            {
                //smaller than original 15-->20
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 20);
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;
                for ( int i = 0; i < minos.Count; ++i )
                {
                    if( minos[i].Stavljen )
                    {
                        minos[i].BlockSize = blockSize;
                        minos[i].StartX = startX + i * 5 * blockSize;
                        minos[i].StartY = startY;
                    }
                }
            }
            
        }

        private void pictureBox_grid_MouseDown(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Left)
            {
                if(minos[0].onItem(e.Location.X, e.Location.Y))
                {
                    Console.WriteLine("LIJEVA TIPKA MISA.");
                }

                if (minos[1].onItem(e.Location.X, e.Location.Y))
                {
                    Console.WriteLine("LIJEVA TIPKA MISA.");
                }

                if (minos[2].onItem(e.Location.X, e.Location.Y))
                {
                    Console.WriteLine("LIJEVA TIPKA MISA.");
                }


            }
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
