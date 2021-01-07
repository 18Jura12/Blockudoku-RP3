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
    /*
     * Represents game which user started
     */
    public partial class PlayStateForm : StateForm
    {
        // Three Mino which user must put on the grid
        List<Mino> minos;
        // Sudoku grid
        Grid net;
        // User selected some Mino
        Mino selected;

        // coordinates of mouse click
        int spaceX;
        int spaceY;

        // Timer
        Timer timer;
        // represents number of seconds for putting three Minos on board
        int counter;

        // top10 scores
        List<int> scores;

        // represents level
        int arcade;

        // obstacles
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

        /*
         * Prevents flickering
         */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        /*
         * Makes three instances of randomly selected Minos
         */
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
                int randNum = rand.Next(0, 4);

                switch (randNum)
                {
                    //Monomino
                    case 0:
                        //minos.Add(new Mono(50, startX[i], startY));
                        minos.Add(new Mono(blockSize, 500, i * 200));
                        break;
                    // DoMino
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
                    // TriMino
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
                    // TetroMino
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

        /*
         * Draws grid and Minos on the PlayStateForm
         */
        private void pictureBox_grid_Paint(object sender, PaintEventArgs e)
        {
            //for optimization
            SuspendLayout();
            
            // draws grid
            net.crtajPlocu(e.Graphics, pictureBox_grid.Width, pictureBox_grid.Height, this.colorBlocks, this.colorBackground);

            if (minos == null)
            {
                MessageBox.Show("null vrijednost");
            }
            else
            {
                //smaller than original 15-->16 (blockSize of Minos in threesome)
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) / 16);

                //position where drawing starts; centered
                int startY = net.Visina + (pictureBox_grid.Height - blockSize * 9) / 5;
                int startX = (pictureBox_grid.Width - blockSize * 15) / 2;

                // draws Minos which user puts on grid
                if (minos[0].Stavljen) minos[0].crtaj(e.Graphics, startX, startY, blockSize, this.colorBlocks);
                if (minos[1].Stavljen) minos[1].crtaj(e.Graphics, startX + 5 * blockSize, startY, blockSize, this.colorBlocks);
                if (minos[2].Stavljen) minos[2].crtaj(e.Graphics, startX + 10 * blockSize, startY, blockSize, this.colorBlocks);
            }

            ResumeLayout();

            pictureBox_grid.Invalidate();
        }

        /*
         * Resize objects on Form
         */
        private void PlayStateForm_SizeChanged(object sender, EventArgs e)
        {
            if ( net != null )
            {
                pictureBox_grid.Width = Convert.ToInt32(tableLayoutPanel_game.GetColumnWidths().GetValue(1));
                pictureBox_grid.Height = 4 * Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

                // 2/3 pictureBox / 9
                int blockSize = Convert.ToInt32(Math.Min(pictureBox_grid.Width, pictureBox_grid.Height) * 2 / 27) - 2;
                net.Sirina = blockSize * 9;
                net.Visina = blockSize * 9;
                net.VelicinaBloka = blockSize;
            }

            if( minos != null )
            {
                //change size of minos, because form changed its size
                resizeMinos();
            } 
        }

        /*
         * Resizes Minos according to the form size
         */
        public void resizeMinos()
        {
            //width and height of pictureBox in which grid and minos are drawn
            pictureBox_grid.Width = Convert.ToInt32(tableLayoutPanel_game.GetColumnWidths().GetValue(1));
            pictureBox_grid.Height = Convert.ToInt32(tableLayoutPanel_game.GetRowHeights().GetValue(0));

            //smaller than original 15-->16
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

        /*
         * When user releases left mouse button, method checks if selected Mino can be put on board
         */
        private void pictureBox_grid_MouseUp(object sender, MouseEventArgs e)
        {
            // Mouse holds some Mino
            if( selected != null )
            {
                int startX = (pictureBox_grid.Width - net.VelicinaBloka * 9) / 2;
                int startY = (pictureBox_grid.Height - net.VelicinaBloka * 9) / 5;
                // if mouse release position is inside board
                if ( e.Location.X >= startX && e.Location.X <= (startX + net.Sirina) && e.Location.Y >= startY && e.Location.Y <= (startY + net.Visina))
                {
                    // check if Mino can be put on boaard
                    checkPutOnBoard(e.Location.X, e.Location.Y);
                } else
                {
                    //Mino can't be put on board, reset its position
                    selected.resetPosition();
                }
            }
            selected = null;
            spaceX = 0;
            spaceY = 0;
        }

        /*
         * Update position of selected Mino when mouse moves
         */
        private void pictureBox_grid_MouseMove(object sender, MouseEventArgs e)
        {
            // left button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // User already selected some Mino before
                if (selected != null)
                {
                    //Update position of selected Mino using mouse location
                    selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                }
                else
                {
                    // User selected some Mino now
                    foreach(Mino mino in minos)
                    {
                        // if user clicked on Mino
                        if (mino.onItem(e.Location.X, e.Location.Y) && mino.Stavljen)
                        {
                            selected = mino;
                            mino.IsSelected = true;
                            //longitude between mouse location and Mino
                            spaceX = e.Location.X - mino.StartX;
                            spaceY = e.Location.Y - mino.StartY;
                            selected.moveMino(e.Location.X, e.Location.Y, spaceX, spaceY);
                            break;
                        }
                    }
                }
            }
        }

        //Coordinates of mouse click
        private void pictureBox_grid_MouseClick(object sender, MouseEventArgs e)
        {
            spaceX = e.X;
            spaceY = e.Y;
        }

        /*
         * Checks if released Mino can be put on board
         */
        private void checkPutOnBoard(int clickX, int clickY)
        {
            bool possible = true;

            //Row and column of mouse release
            int row = (clickY - (pictureBox_grid.Height - net.Visina) / 5) / net.VelicinaBloka;
            int col = (clickX - (pictureBox_grid.Width - net.Sirina) / 2) / net.VelicinaBloka;

            //location of the beginning of Mino matrix based on the mouseClick location
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
                        // Mino has some content outside the grid
                        if (i + colS > 8 || i + colS < 0 || j + rowS > 8 || j + rowS < 0 || net.Ploca[i + colS, j + rowS] > 0)
                        {
                            possible = false;
                        }
                    }
                }
            }

            // if Mino can be put on board
            // update net
            // update score
            if (possible)
            {
                selected.Stavljen = false;
                selected.IsSelected = false;
                net.putOnBoard(colS, rowS, selected);
                score += net.updateBoard();
                this.score_label.Text = "Score: " + score.ToString();

                if (!minos[0].Stavljen && !minos[1].Stavljen && !minos[2].Stavljen)
                {
                    //make new Minos if user put all three of them
                    minos = makeMinos();
                    resizeMinos();

                }
                if (isEnd())
                {
                    // no more moves can be made -> endGame
                    endMessage();
                }
            }
            else
            {
                //Mino can't be put on board; reset position of selected Mino
                selected.resetPosition();
            }

        }

        /*
         * Go back to Main Menu through back button
         */
        private void button_back_Click(object sender, EventArgs e)
        {
            if(arcade > 0)
            {
                Program.stateManager.Transition(new ArcadeGameStateForm());
            } else
            {
                Program.stateManager.Transition(new MainMenuStateForm());
            }
        }

        /*
         * Checks if at least one Mino of the given ones can be put on board
         */
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
            return end;
        }

        /*
         * Timer starts counting down 10 seconds
         */
        private void resetTimer()
        {
            timer.Interval = 1000; // 1 second
            timer.Start();
            counter = 10;
            label_timer.Text = "Timer: " + counter + "s";
        }

        /*
         * Get top 10 scores from file
         */
        private void getScores()
        {
            // list for 10 scores
            scores = new List<int>(10);

            string basePath = Environment.CurrentDirectory;
            //go to directory which contains wanted file
            string newPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\"));

            //Console.WriteLine($"Current directory:\n   {Environment.CurrentDirectory}");
            //Console.WriteLine($"new directory:\n   {newPath}");

            newPath += "top10.txt";

            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(newPath))
                {
                    while (sr.Peek() >= 0)
                    {
                        // add score to list with socres
                        scores.Add(Convert.ToInt32(sr.ReadLine()));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Get data when loading form
         */
        private void PlayStateForm_Load(object sender, EventArgs e)
        {
            // get top 10 scores
            getScores();

            // if user plays arcade game, prepare game
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

            // prepare timer
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

            // prepare obstacles
            if(this.obstacles)
            {
                generateObstacles();
            }

            // change background color
            this.tableLayoutPanel_game.BackColor = this.colorBackground;
            resizeMinos();
        }

        /*
         * Notify user about game goals
         */
        private void prepareState(int target_score)
        {
            this.desired_score_label.Text = "Level " + arcade.ToString() + "\n\nTarget score: " + target_score.ToString();
        }

        /*
         * Generate obstacles and positions for them in grid
         */
        private void generateObstacles()
        {
            Random rand = new Random();
            int x;
            int y;
            for (int i = 0; i < 8; i++)
            {
                while(true)
                {
                    x = rand.Next(0, 9);
                    y = rand.Next(0, 9);
                    if (net.Ploca[x, y] == 0)
                    {
                        net.Ploca[x, y] = arcade > 0 ? obstacles_generated : rand.Next(2, obstacles_generated + 1);
                        break;
                    }
                }
            }
        }

        /*
         * Method writes top 10 scores in file
         */
        private void updateScores()
        {
            string basePath = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\"));

            //Console.WriteLine($"Current directory:\n   {Environment.CurrentDirectory}");
            //Console.WriteLine($"new directory:\n   {newPath}");

            newPath += "top10.txt";

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

        /*
         * Checks if user has good enough score
         */
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

        /*
         * Message shown to user when game is over
         */
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

        /*
         * Updates label with remaining seconds
         */
        private void timer_Tick(object sender, EventArgs e)
        {
            // game over
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
