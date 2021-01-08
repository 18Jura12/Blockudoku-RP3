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
    public partial class TopScoresStateForm : StateForm
    {
        public TopScoresStateForm()
        {
            InitializeComponent();
            customTextBox_topTen.Enter += (s, e) => { customTextBox_topTen.Parent.Focus(); };
            this.Text = "";
        }


        /*
         * Update size of objects on form
         */
        private void TopScoresStateForm_SizeChanged(object sender, EventArgs e)
        {
            this.groupBox_Scores.Width = this.Width * 2 / 3;
            this.groupBox_Scores.Height = this.Height * 2 / 3;

            // 2/3 gropubox, 1/6 left,right,top,down
            int x1 = Convert.ToInt32(this.Width / 6);
            int y1 = Convert.ToInt32(this.Height / 6);

            this.groupBox_Scores.Location = new Point(x1, y1);

            //this.textBox_Scores.Width = this.groupBox_Scores.Width * 2 / 3;
            //this.textBox_Scores.Height = this.groupBox_Scores.Height * 2 / 3;

            this.customTextBox_topTen.Width = this.groupBox_Scores.Width * 2 / 3;
            this.customTextBox_topTen.Height = this.groupBox_Scores.Height * 2 / 3;

            // 2/3 textBox, 1/6 left,right,top,down
            int x2 = Convert.ToInt32(this.groupBox_Scores.Width / 6);
            int y2 = Convert.ToInt32(this.groupBox_Scores.Height / 6);

            //this.textBox_Scores.Location = new Point(x2, y2);
            this.customTextBox_topTen.Location = new Point(x2, y2);

            //button
            this.button_Scores_back.Width = customTextBox_topTen.Width / 4;
            this.button_Scores_back.Height = customTextBox_topTen.Height / 8;
            //this.button_Scores_back.Width = textBox_Scores.Width / 4;
            //this.button_Scores_back.Height = textBox_Scores.Height / 8;

            // 1/4 button, 3/8 left,right, top: textbox+y2
            int x3 = Convert.ToInt32(this.groupBox_Scores.Width * 3 / 8);
            int y3 = Convert.ToInt32(y2 + customTextBox_topTen.Height);
            //int y3 = Convert.ToInt32(y2 + textBox_Scores.Height);

            this.button_Scores_back.Location = new Point(x3, y3);

            this.panel_buttons.Width = this.Width;
            this.panel_buttons.Height = this.Height / 12;
            this.panel_buttons.Location = new Point(0, 0);
        }

        /*
         * back to Main Menu through back button
         */
        private void button_Scores_back_Click(object sender, EventArgs e)
        {
            Program.stateManager.Transition(new MainMenuStateForm());
        }

        /*
         * Gets 10 scores from file and writes them in CustomTextBox
         */
        private void TopScoresStateForm_Load(object sender, EventArgs e)
        {
            normal_radioButton.Checked = true;

            displayScores("top10_normal.txt");
        }

        //reads the file and displays the scores inside of it
        private void displayScores(string path)
        {
            this.customTextBox_topTen.Text = "";
            string basePath = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\Scores\"));

            //Console.WriteLine($"Current directory:\n   {Environment.CurrentDirectory}");

            newPath += path;

            //Console.WriteLine($"new directory:\n   {newPath}");

            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(newPath))
                {
                    // Read the stream as a string, and write the string to the console.
                    //Console.WriteLine(sr.ReadToEnd());
                    var i = 1;

                    while (sr.Peek() >= 0)
                    {
                        this.customTextBox_topTen.AppendText(i.ToString() + ".\t" + sr.ReadLine() + Environment.NewLine);
                        ++i;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void normal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(this.normal_radioButton.Checked == true)
            {
                displayScores("top10_normal.txt");
            }
        }

        private void timed_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.timed_radioButton.Checked == true)
            {
                displayScores("top10_timed.txt");
            }
        }

        private void obstacles_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.obstacles_radioButton.Checked == true)
            {
                displayScores("top10_obstacles.txt");
            }
        }

        private void timed_obstacles_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.timed_obstacles_radioButton.Checked == true)
            {
                displayScores("top10_timed_obstacles.txt");
            }
        }
    }
}
