
namespace Blockudoku
{
    partial class TopScoresStateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Scores = new System.Windows.Forms.GroupBox();
            this.button_Scores_back = new System.Windows.Forms.Button();
            this.customTextBox_topTen = new Blockudoku.CustomTextBox();
            this.groupBox_Scores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Scores
            // 
            this.groupBox_Scores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Scores.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Scores.Controls.Add(this.customTextBox_topTen);
            this.groupBox_Scores.Controls.Add(this.button_Scores_back);
            this.groupBox_Scores.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Scores.Location = new System.Drawing.Point(206, 106);
            this.groupBox_Scores.Name = "groupBox_Scores";
            this.groupBox_Scores.Size = new System.Drawing.Size(352, 213);
            this.groupBox_Scores.TabIndex = 0;
            this.groupBox_Scores.TabStop = false;
            this.groupBox_Scores.Text = "Top10";
            // 
            // button_Scores_back
            // 
            this.button_Scores_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Scores_back.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Scores_back.Location = new System.Drawing.Point(132, 165);
            this.button_Scores_back.Name = "button_Scores_back";
            this.button_Scores_back.Size = new System.Drawing.Size(75, 23);
            this.button_Scores_back.TabIndex = 1;
            this.button_Scores_back.Text = "BACK";
            this.button_Scores_back.UseVisualStyleBackColor = true;
            this.button_Scores_back.Click += new System.EventHandler(this.button_Scores_back_Click);
            // 
            // customTextBox_topTen
            // 
            this.customTextBox_topTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox_topTen.BackColor = System.Drawing.Color.Transparent;
            this.customTextBox_topTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox_topTen.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox_topTen.Location = new System.Drawing.Point(132, 87);
            this.customTextBox_topTen.Multiline = true;
            this.customTextBox_topTen.Name = "customTextBox_topTen";
            this.customTextBox_topTen.ReadOnly = true;
            this.customTextBox_topTen.Size = new System.Drawing.Size(100, 22);
            this.customTextBox_topTen.TabIndex = 2;
            // 
            // TopScoresStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blockudoku.Properties.Resources.simple_blue_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Scores);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TopScoresStateForm";
            this.Text = "TopScoresStateForm";
            this.Load += new System.EventHandler(this.TopScoresStateForm_Load);
            this.SizeChanged += new System.EventHandler(this.TopScoresStateForm_SizeChanged);
            this.groupBox_Scores.ResumeLayout(false);
            this.groupBox_Scores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Scores;
        private System.Windows.Forms.Button button_Scores_back;
        private CustomTextBox customTextBox_topTen;
    }
}