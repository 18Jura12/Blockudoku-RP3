
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
            this.pictureBox_grid = new System.Windows.Forms.PictureBox();
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
            this.tableLayoutPanel_game.Controls.Add(this.pictureBox_grid, 1, 0);
            this.tableLayoutPanel_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_game.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_game.Name = "tableLayoutPanel_game";
            this.tableLayoutPanel_game.RowCount = 1;
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_game.Size = new System.Drawing.Size(1044, 545);
            this.tableLayoutPanel_game.TabIndex = 0;
            // 
            // pictureBox_grid
            // 
            this.pictureBox_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_grid.Location = new System.Drawing.Point(160, 4);
            this.pictureBox_grid.Name = "pictureBox_grid";
            this.pictureBox_grid.Size = new System.Drawing.Size(880, 537);
            this.pictureBox_grid.TabIndex = 0;
            this.pictureBox_grid.TabStop = false;
            this.pictureBox_grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_grid_Paint);
            this.pictureBox_grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_grid_MouseDown);
            // 
            // PlayStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.tableLayoutPanel_game);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlayStateForm";
            this.Text = "PlayStateForm";
            this.SizeChanged += new System.EventHandler(this.PlayStateForm_SizeChanged);
            this.tableLayoutPanel_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_game;
        private System.Windows.Forms.PictureBox pictureBox_grid;
    }
}