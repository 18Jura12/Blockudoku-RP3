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

        public PlayStateForm()
        {
            InitializeComponent();
            minos = makeMinos();
        }

        private void PlayStateForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafika = CreateGraphics();
            Grid net = new Grid();
            SuspendLayout();
            net.crtajPlocu(grafika, this.Size.Width, this.Size.Height);

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
                // MessageBox.Show(minos[0].GetType().ToString()+ minos[1].GetType().ToString()+ minos[2].GetType().ToString());
                minos[0].crtaj(grafika, this.Size.Width, this.Size.Height);
                minos[1].crtaj(grafika, this.Size.Width, this.Size.Height);
                minos[2].crtaj(grafika, this.Size.Width, this.Size.Height);
            }

            ResumeLayout();
        }

        List<Mino> makeMinos()
        {
            List<Mino> minos = new List<Mino>(3);
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
                        minos.Add(new Mono(40, 500, i * 200));
                        break;
                    case 1:
                        int randNum2 = rand2.Next(0, 2);
                        switch (randNum2)
                        {
                            case 0:
                                minos.Add(new DoVertical(40, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new DoDiag(40, 500, i * 200));
                                break;
                        }
                        break;
                    case 2:
                        int randNum3 = rand3.Next(0, 3);
                        switch (randNum3)
                        {
                            case 0:
                                minos.Add(new TriVertical(40, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new TriDiag(40, 500, i * 200));
                                break;
                            case 2:
                                minos.Add(new TriL(40, 500, i * 200));
                                break;
                        }
                        break;
                    case 3:
                        int randNum4 = rand4.Next(0, 4);
                        switch (randNum4)
                        {
                            case 0:
                                minos.Add(new TetroVertical(40, 500, i * 200));
                                break;
                            case 1:
                                minos.Add(new TetroL(40, 500, i * 200));
                                break;
                            case 2:
                                minos.Add(new TetroZ(40, 500, i * 200));
                                break;
                            case 3:
                                minos.Add(new TetroT(40, 500, i * 200));
                                break;
                        }
                        break;
                }

            }

            return minos;
        }
    }
}
