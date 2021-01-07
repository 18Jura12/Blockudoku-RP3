
namespace Blockudoku
{
    partial class PlayStateForm
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
            this.tableLayoutPanel_game = new System.Windows.Forms.TableLayoutPanel();
            this.desired_score_label = new System.Windows.Forms.Label();
            this.pictureBox_grid = new System.Windows.Forms.PictureBox();
            this.score_label = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.tableLayoutPanel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_game
            // 
            this.tableLayoutPanel_game.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_game.ColumnCount = 2;
            this.tableLayoutPanel_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95685F));
            this.tableLayoutPanel_game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.04315F));
            this.tableLayoutPanel_game.Controls.Add(this.desired_score_label, 0, 2);
            this.tableLayoutPanel_game.Controls.Add(this.pictureBox_grid, 1, 0);
            this.tableLayoutPanel_game.Controls.Add(this.score_label, 0, 0);
            this.tableLayoutPanel_game.Controls.Add(this.label_timer, 0, 1);
            this.tableLayoutPanel_game.Controls.Add(this.button_back, 0, 3);
            this.tableLayoutPanel_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_game.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_game.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel_game.Name = "tableLayoutPanel_game";
            this.tableLayoutPanel_game.RowCount = 4;
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_game.Size = new System.Drawing.Size(783, 443);
            this.tableLayoutPanel_game.TabIndex = 0;
            // 
            // desired_score_label
            // 
            this.desired_score_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desired_score_label.AutoSize = true;
            this.desired_score_label.Font = new System.Drawing.Font("Papyrus", 12.25F, System.Drawing.FontStyle.Bold);
            this.desired_score_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.desired_score_label.Location = new System.Drawing.Point(59, 262);
            this.desired_score_label.Name = "desired_score_label";
            this.desired_score_label.Size = new System.Drawing.Size(0, 27);
            this.desired_score_label.TabIndex = 5;
            this.desired_score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_grid
            // 
            this.pictureBox_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_grid.Location = new System.Drawing.Point(120, 3);
            this.pictureBox_grid.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_grid.Name = "pictureBox_grid";
            this.tableLayoutPanel_game.SetRowSpan(this.pictureBox_grid, 4);
            this.pictureBox_grid.Size = new System.Drawing.Size(660, 437);
            this.pictureBox_grid.TabIndex = 0;
            this.pictureBox_grid.TabStop = false;
            this.pictureBox_grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_grid_Paint);
            this.pictureBox_grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_grid_MouseClick);
            this.pictureBox_grid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_grid_MouseMove);
            this.pictureBox_grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_grid_MouseUp);
            // 
            // score_label
            // 
            this.score_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Papyrus", 12.25F, System.Drawing.FontStyle.Bold);
            this.score_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score_label.Location = new System.Drawing.Point(16, 42);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(86, 27);
            this.score_label.TabIndex = 3;
            this.score_label.Text = "Score: 0";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_back
            // 
            this.button_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_back.FlatAppearance.BorderSize = 2;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_back.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_back.Location = new System.Drawing.Point(13, 370);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(91, 33);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_timer
            // 
            this.label_timer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_timer.Location = new System.Drawing.Point(28, 153);
            this.label_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(62, 25);
            this.label_timer.TabIndex = 4;
            this.label_timer.Text = "Timer:";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 443);
            this.Controls.Add(this.tableLayoutPanel_game);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayStateForm";
            this.Text = "PlayStateForm";
            this.Load += new System.EventHandler(this.PlayStateForm_Load);
            this.SizeChanged += new System.EventHandler(this.PlayStateForm_SizeChanged);
            this.tableLayoutPanel_game.ResumeLayout(false);
            this.tableLayoutPanel_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_game;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox pictureBox_grid;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label desired_score_label;
    }
}