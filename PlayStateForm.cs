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
using System.IO;

namespace Blockudoku
{
    public partial class PlayStateForm : StateForm
    {
        List<Mino> minos;
        Grid net;
        Mino selected;
        int spaceX;
        int spaceY;

        Timer timer;
        int counter;

        List<int> scores;

        int arcade;
        int obstacles_generated;

        public PlayStateForm()
        {
            InitializeComponent();
            minos = makeMinos();
            net = new Grid();
            selected = null;
            //od klika za selected
            spaceX = 0;
            spaceY = 0;
            score = 0;
            arcade = 0;
            obstacles_generated = 5;
           
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        List<Mino> makeMinos()
        {
            //timer stuff
            if (this.timed)
            {
                timer.Stop();
                resetTimer();
            }

            List<Mino> minos = new List<Mino>(3);

            int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);

            Random rand = new Random();

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
                        randNum = rand.Next(0, 2);
                        switch (randNum)
                        {
                            case 0:
                                minos.Add(new DoVertical(blockSize, 500, i * 200));
                                //minos.Add(new DoVertical(blockSize, startX + 5 * i * blockSize, startY));
                                break;
                            case 1:
                                minos.Add(new DoDiag(blockSize, 500, i * 200));
                                break;
                        }
                        break;
                    case 2:
                        randNum = rand.Next(0, 3);
                        switch (randNum)
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
                        randNum = rand.Next(0, 4);
                        switch (randNum)
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


        private void pictureBox_grid_Paint(object sender, PaintEventArgs e)
        {
            SuspendLayout();
            //Console.WriteLine(this.colorBackground);
            net.crtajPlocu(e.Graphics, pictureBox_grid.Width, pictureBox_grid.Height, this.colorBlocks, this.colorBackground);

            if (minos == null)
            {
                MessageBox.Show("null vrijednost");
            }
            else
            {
                //MessageBox.Show(minos[2].Stavljen.ToString());

                //smaller than original 15-->16
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);

                //int startY = (pictureBox_grid.Height - blockSize * 5) / 2;

                //int startY = (pictureBox_grid.Height - blockSize2 * 9);
                //int startY = (visina - velicinaBloka * 9) / 5; iz grida
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;

                if (minos[0].Stavljen) minos[0].crtaj(e.Graphics, startX, startY, blockSize, this.colorBlocks);
                if (minos[1].Stavljen) minos[1].crtaj(e.Graphics, startX + 5 * blockSize, startY, blockSize, this.colorBlocks);
                if (minos[2].Stavljen) minos[2].crtaj(e.Graphics, startX + 10 * blockSize, startY, blockSize, this.colorBlocks);
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
                pictureBox_grid.Height = 4 * Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

                // 2/3 pictureBox / 9
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) * 2 / 27) - 2;
                net.Sirina = blockSize * 9;
                net.Visina = blockSize * 9;
                net.VelicinaBloka = blockSize;
                
            }

            // mozda dodat još i mijenjanje startX i startY od svakog minos-a; PROVJERI!!
            if( minos != null )
            {
                resizeMinos();
            } 
        }

        public void resizeMinos()
        {
            pictureBox_grid.Width = Convert.ToInt32(tableLayoutPanel_game.GetColumnWidths().GetValue(1));
            pictureBox_grid.Height = Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

            //smaller than original 15-->18
            int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);
            int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
            int startX = (pictureBox_grid.Width - blockSize * 15) / 2;
            for (int i = 0; i < minos.Count; ++i)
            {
                if (minos[i].Stavljen)
                {
                    minos[i].BlockSize = blockSize;
                    minos[i].StartX = startX + i * 5 * blockSize;
                    minos[i].StartY = startY;
                    minos[i].X = startX + i * 5 * blockSize;
                    minos[i].Y = startY;
                }
            }
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
                    //Console.WriteLine("unutar");
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
                    foreach(Mino mino in minos)
                    {
                        if (mino.onItem(e.Location.X, e.Location.Y) && mino.Stavljen)
                        {
                            selected = mino;
                            mino.IsSelected = true;
                            spaceX = e.Location.X - mino.StartX;
                            spaceY = e.Location.Y - mino.StartY;
                            selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                            break;
                            //Console.WriteLine("LIJEVA TIPKA MISA.");
                        }
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
                selected.IsSelected = false;
                net.putOnBoard(colS, rowS, selected);
                score += net.updateBoard();
                this.score_label.Text = "Score: " + score.ToString();

                if (!minos[0].Stavljen && !minos[1].Stavljen && !minos[2].Stavljen)
                {
                    minos = makeMinos();
                    resizeMinos();

                }
                if (isEnd())
                {
                    endMessage();
                }
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

        private bool isEnd()
        {
            bool end = true;
            foreach (Mino mino in minos)
            {
                if (mino.Stavljen && net.isMinoPossible(mino))
                {
                    end = false;
                    break;
                }
            }
            if (arcade != 0 && score >= arcade * 100) end = true;
            //Ovdje namjesti što se dogodi na kraju
            return end;
        }

        private void resetTimer()
        {
            timer.Interval = 1000; // 1 second
            timer.Start();
            counter = 10;
            label_timer.Text = "Timer: " + counter + "s";
        }

        private void getScores()
        {
            scores = new List<int>(10);

            string basePath = Environment.CurrentDirectory;
            //out of bin\Debug
            string newPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\"));

            Console.WriteLine($"Current directory:\n   {Environment.CurrentDirectory}");
            Console.WriteLine($"new directory:\n   {newPath}");

            newPath += "top10.txt";
            Console.WriteLine($"new directory:\n   {newPath}");

            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(newPath))
                {
                    while (sr.Peek() >= 0)
                    {
                        scores.Add(Convert.ToInt32(sr.ReadLine()));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            /*
            foreach( var line in scores )
            {
                Console.WriteLine(line.ToString());
            }
            */
        }

        private void PlayStateForm_Load(object sender, EventArgs e)
        {
            getScores();

            switch (arcade)
            {
                case 1:
                    timed = false;
                    obstacles = false;
                    prepareState(100);
                    break;
                case 2:
                    timed = false;
                    obstacles = true;
                    obstacles_generated = 2;
                    prepareState(200);
                    break;
                case 3:
                    timed = true;
                    obstacles = true;
                    obstacles_generated = 3;
                    prepareState(300);
                    break;
                case 4:
                    timed = true;
                    obstacles = true;
                    obstacles_generated = 4;
                    prepareState(400);
                    break;
                case 5:
                    timed = true;
                    obstacles = true;
                    obstacles_generated = 5;
                    prepareState(500);
                    break;
                default:
                    break;
            }

            if (this.timed)
            {
                timer = new Timer();
                timer.Tick += new EventHandler(timer_Tick);
                resetTimer();
            }
            else
            {
                label_timer.Text = "";
            }
            this.tableLayoutPanel_game.BackColor = this.colorBackground;
            resizeMinos();
        }

        private void prepareState(int target_score)
        {
            this.desired_score_label.Text = "Level " + arcade.ToString() + "\n\nTarget score: " + target_score.ToString();
        }

        private void updateScores()
        {
            string basePath = Environment.CurrentDirectory;
            //out of bin\Debug
            string newPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\"));

            Console.WriteLine($"Current directory:\n   {Environment.CurrentDirectory}");
            Console.WriteLine($"new directory:\n   {newPath}");

            newPath += "top10.txt";
            Console.WriteLine($"new directory:\n   {newPath}");

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(newPath);

                foreach (var sc in scores)
                {
                    sw.WriteLine(sc.ToString());
                }

                //Close the file
                sw.Close();

            }
            catch (IOException ex)
            {
                Console.WriteLine("Can't write in file.");
                Console.WriteLine(ex.Message);
            }
        }

        private bool checkTop10()
        {
            var myScore = this.score;
            for (int i = 0; i < scores.Count; i++)
            {
                if (myScore >= scores[i])
                {
                    scores.RemoveAt(scores.Count - 1);
                    scores.Insert(i, myScore);
                    updateScores();
                    return true;
                }
            }

            return false;
        }

        private void endMessage()
        {
            string message;
            if(arcade != 0)
            {
                if(score >= arcade*100)
                {
                    message = "Congratulations! :D \n Level unlocked: " + (arcade+1).ToString() +
                        "\n Code: " + MainMenuStateForm.levels[arcade - 1];
                    ArcadeGameStateForm.level = arcade + 1;
                } else
                {
                    message = "You lost! :( \n Better luck next time!";
                }
                var ok = MessageBox.Show(message, "", MessageBoxButtons.OK);
                
                if(ok == DialogResult.OK)
                {
                    arcade = 0;
                    Program.stateManager.Transition(new ArcadeGameStateForm());
                }

            } else
            {
                var newHeighScore = checkTop10();
                message = "Game Over!" + System.Environment.NewLine + "Your score: " + this.score;
                if (newHeighScore)
                {
                    message += Environment.NewLine;
                    message += "Score in Top10!";
                }
                const string caption = "Game over";
                var ok = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                if (ok == DialogResult.OK)
                {
                    Program.stateManager.Transition(new MainMenuStateForm());
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                timer.Stop();
                endMessage();
            }
            --counter;
            label_timer.Text = "Timer: " + counter + "s";
        }

        public int Arcade
        {
            get
            {
                return arcade;
            }
            set
            {
                arcade = value;
            }
        }

    }
}
