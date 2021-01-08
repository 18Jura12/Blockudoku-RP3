
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
            this.customTextBox_topTen = new Blockudoku.CustomTextBox();
            this.button_Scores_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timed_obstacles_radioButton = new System.Windows.Forms.RadioButton();
            this.obstacles_radioButton = new System.Windows.Forms.RadioButton();
            this.timed_radioButton = new System.Windows.Forms.RadioButton();
            this.normal_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox_Scores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Scores
            // 
            this.groupBox_Scores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Scores.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Scores.Controls.Add(this.customTextBox_topTen);
            this.groupBox_Scores.Controls.Add(this.button_Scores_back);
            this.groupBox_Scores.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Scores.Location = new System.Drawing.Point(154, 86);
            this.groupBox_Scores.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Scores.Name = "groupBox_Scores";
            this.groupBox_Scores.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Scores.Size = new System.Drawing.Size(264, 173);
            this.groupBox_Scores.TabIndex = 0;
            this.groupBox_Scores.TabStop = false;
            this.groupBox_Scores.Text = "Top10";
            // 
            // customTextBox_topTen
            // 
            this.customTextBox_topTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox_topTen.BackColor = System.Drawing.Color.Transparent;
            this.customTextBox_topTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox_topTen.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox_topTen.Location = new System.Drawing.Point(99, 71);
            this.customTextBox_topTen.Margin = new System.Windows.Forms.Padding(2);
            this.customTextBox_topTen.Multiline = true;
            this.customTextBox_topTen.Name = "customTextBox_topTen";
            this.customTextBox_topTen.ReadOnly = true;
            this.customTextBox_topTen.Size = new System.Drawing.Size(75, 18);
            this.customTextBox_topTen.TabIndex = 2;
            // 
            // button_Scores_back
            // 
            this.button_Scores_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Scores_back.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Scores_back.Location = new System.Drawing.Point(99, 134);
            this.button_Scores_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_Scores_back.Name = "button_Scores_back";
            this.button_Scores_back.Size = new System.Drawing.Size(56, 19);
            this.button_Scores_back.TabIndex = 1;
            this.button_Scores_back.Text = "BACK";
            this.button_Scores_back.UseVisualStyleBackColor = true;
            this.button_Scores_back.Click += new System.EventHandler(this.button_Scores_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.timed_obstacles_radioButton);
            this.panel1.Controls.Add(this.obstacles_radioButton);
            this.panel1.Controls.Add(this.timed_radioButton);
            this.panel1.Controls.Add(this.normal_radioButton);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 47);
            this.panel1.TabIndex = 1;
            // 
            // timed_obstacles_radioButton
            // 
            this.timed_obstacles_radioButton.AutoSize = true;
            this.timed_obstacles_radioButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timed_obstacles_radioButton.Location = new System.Drawing.Point(403, 15);
            this.timed_obstacles_radioButton.Name = "timed_obstacles_radioButton";
            this.timed_obstacles_radioButton.Size = new System.Drawing.Size(144, 25);
            this.timed_obstacles_radioButton.TabIndex = 3;
            this.timed_obstacles_radioButton.Text = "timed + obstacles";
            this.timed_obstacles_radioButton.UseVisualStyleBackColor = true;
            this.timed_obstacles_radioButton.CheckedChanged += new System.EventHandler(this.timed_obstacles_radioButton_CheckedChanged);
            // 
            // obstacles_radioButton
            // 
            this.obstacles_radioButton.AutoSize = true;
            this.obstacles_radioButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstacles_radioButton.Location = new System.Drawing.Point(260, 15);
            this.obstacles_radioButton.Name = "obstacles_radioButton";
            this.obstacles_radioButton.Size = new System.Drawing.Size(92, 25);
            this.obstacles_radioButton.TabIndex = 2;
            this.obstacles_radioButton.Text = "obstacles";
            this.obstacles_radioButton.UseVisualStyleBackColor = true;
            this.obstacles_radioButton.CheckedChanged += new System.EventHandler(this.obstacles_radioButton_CheckedChanged);
            // 
            // timed_radioButton
            // 
            this.timed_radioButton.AutoSize = true;
            this.timed_radioButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timed_radioButton.Location = new System.Drawing.Point(142, 15);
            this.timed_radioButton.Name = "timed_radioButton";
            this.timed_radioButton.Size = new System.Drawing.Size(64, 25);
            this.timed_radioButton.TabIndex = 1;
            this.timed_radioButton.Text = "timed";
            this.timed_radioButton.UseVisualStyleBackColor = true;
            this.timed_radioButton.CheckedChanged += new System.EventHandler(this.timed_radioButton_CheckedChanged);
            // 
            // normal_radioButton
            // 
            this.normal_radioButton.AutoSize = true;
            this.normal_radioButton.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal_radioButton.Location = new System.Drawing.Point(19, 15);
            this.normal_radioButton.Name = "normal_radioButton";
            this.normal_radioButton.Size = new System.Drawing.Size(73, 25);
            this.normal_radioButton.TabIndex = 0;
            this.normal_radioButton.Text = "normal";
            this.normal_radioButton.UseVisualStyleBackColor = true;
            this.normal_radioButton.CheckedChanged += new System.EventHandler(this.normal_radioButton_CheckedChanged);
            // 
            // TopScoresStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blockudoku.Properties.Resources.simple_blue_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_Scores);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TopScoresStateForm";
            this.Text = "TopScoresStateForm";
            this.Load += new System.EventHandler(this.TopScoresStateForm_Load);
            this.SizeChanged += new System.EventHandler(this.TopScoresStateForm_SizeChanged);
            this.groupBox_Scores.ResumeLayout(false);
            this.groupBox_Scores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Scores;
        private System.Windows.Forms.Button button_Scores_back;
        private CustomTextBox customTextBox_topTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton timed_obstacles_radioButton;
        private System.Windows.Forms.RadioButton obstacles_radioButton;
        private System.Windows.Forms.RadioButton timed_radioButton;
        private System.Windows.Forms.RadioButton normal_radioButton;
    }
}