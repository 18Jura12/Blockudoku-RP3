
namespace Blockudoku
{
    partial class ArcadeGameStateForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.level_2_button = new System.Windows.Forms.Button();
            this.level_3_button = new System.Windows.Forms.Button();
            this.level_1_button = new System.Windows.Forms.Button();
            this.level_4_button = new System.Windows.Forms.Button();
            this.level_5_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.back_button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.level_2_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.level_1_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.level_5_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.level_4_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.level_3_button, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // level_2_button
            // 
            this.level_2_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_2_button.Enabled = false;
            this.level_2_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.level_2_button.FlatAppearance.BorderSize = 2;
            this.level_2_button.Font = new System.Drawing.Font("Papyrus", 23.75F, System.Drawing.FontStyle.Bold);
            this.level_2_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.level_2_button.Location = new System.Drawing.Point(85, 302);
            this.level_2_button.Name = "level_2_button";
            this.level_2_button.Size = new System.Drawing.Size(70, 70);
            this.level_2_button.TabIndex = 2;
            this.level_2_button.Text = "2";
            this.level_2_button.UseVisualStyleBackColor = true;
            // 
            // level_3_button
            // 
            this.level_3_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_3_button.Enabled = false;
            this.level_3_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.level_3_button.FlatAppearance.BorderSize = 2;
            this.level_3_button.Font = new System.Drawing.Font("Papyrus", 26.75F, System.Drawing.FontStyle.Bold);
            this.level_3_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.level_3_button.Location = new System.Drawing.Point(320, 297);
            this.level_3_button.Name = "level_3_button";
            this.level_3_button.Size = new System.Drawing.Size(80, 80);
            this.level_3_button.TabIndex = 3;
            this.level_3_button.Text = "3";
            this.level_3_button.UseVisualStyleBackColor = true;
            // 
            // level_1_button
            // 
            this.level_1_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_1_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.level_1_button.FlatAppearance.BorderSize = 2;
            this.level_1_button.Font = new System.Drawing.Font("Papyrus", 20.75F, System.Drawing.FontStyle.Bold);
            this.level_1_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.level_1_button.Location = new System.Drawing.Point(90, 82);
            this.level_1_button.Name = "level_1_button";
            this.level_1_button.Size = new System.Drawing.Size(60, 60);
            this.level_1_button.TabIndex = 1;
            this.level_1_button.Text = "1";
            this.level_1_button.UseVisualStyleBackColor = true;
            // 
            // level_4_button
            // 
            this.level_4_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_4_button.Enabled = false;
            this.level_4_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.level_4_button.FlatAppearance.BorderSize = 2;
            this.level_4_button.Font = new System.Drawing.Font("Papyrus", 29.75F, System.Drawing.FontStyle.Bold);
            this.level_4_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.level_4_button.Location = new System.Drawing.Point(315, 67);
            this.level_4_button.Name = "level_4_button";
            this.level_4_button.Size = new System.Drawing.Size(90, 90);
            this.level_4_button.TabIndex = 4;
            this.level_4_button.Text = "4";
            this.level_4_button.UseVisualStyleBackColor = true;
            // 
            // level_5_button
            // 
            this.level_5_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_5_button.Enabled = false;
            this.level_5_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.level_5_button.FlatAppearance.BorderSize = 2;
            this.level_5_button.Font = new System.Drawing.Font("Papyrus", 31.75F, System.Drawing.FontStyle.Bold);
            this.level_5_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.level_5_button.Location = new System.Drawing.Point(590, 62);
            this.level_5_button.Name = "level_5_button";
            this.level_5_button.Size = new System.Drawing.Size(100, 100);
            this.level_5_button.TabIndex = 5;
            this.level_5_button.Text = "5";
            this.level_5_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.FlatAppearance.BorderSize = 2;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Papyrus", 8.75F, System.Drawing.FontStyle.Bold);
            this.back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.Location = new System.Drawing.Point(595, 322);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(90, 30);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ArcadeGameStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ArcadeGameStateForm";
            this.Text = "ArcadeGameStateForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button level_1_button;
        private System.Windows.Forms.Button level_2_button;
        private System.Windows.Forms.Button level_3_button;
        private System.Windows.Forms.Button level_4_button;
        private System.Windows.Forms.Button level_5_button;
        private System.Windows.Forms.Button back_button;
    }
}