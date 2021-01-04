
namespace Blockudoku
{
    partial class MainMenuStateForm
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
            this.main_menu_panel = new System.Windows.Forms.TableLayoutPanel();
            this.unlock_level_button = new System.Windows.Forms.Button();
            this.options_button = new System.Windows.Forms.Button();
            this.top_scores_button = new System.Windows.Forms.Button();
            this.rules_button = new System.Windows.Forms.Button();
            this.arcade_game_button = new System.Windows.Forms.Button();
            this.standard_game_button = new System.Windows.Forms.Button();
            this.main_menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu_panel
            // 
            this.main_menu_panel.BackColor = System.Drawing.Color.White;
            this.main_menu_panel.BackgroundImage = global::Blockudoku.Properties.Resources.simple_blue_background1;
            this.main_menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_menu_panel.ColumnCount = 2;
            this.main_menu_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_menu_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_menu_panel.Controls.Add(this.unlock_level_button, 1, 2);
            this.main_menu_panel.Controls.Add(this.options_button, 0, 2);
            this.main_menu_panel.Controls.Add(this.top_scores_button, 1, 1);
            this.main_menu_panel.Controls.Add(this.rules_button, 0, 1);
            this.main_menu_panel.Controls.Add(this.arcade_game_button, 1, 0);
            this.main_menu_panel.Controls.Add(this.standard_game_button, 0, 0);
            this.main_menu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_menu_panel.Location = new System.Drawing.Point(0, 0);
            this.main_menu_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_menu_panel.Name = "main_menu_panel";
            this.main_menu_panel.RowCount = 3;
            this.main_menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.main_menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.main_menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.main_menu_panel.Size = new System.Drawing.Size(1067, 554);
            this.main_menu_panel.TabIndex = 0;
            // 
            // unlock_level_button
            // 
            this.unlock_level_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unlock_level_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.unlock_level_button.FlatAppearance.BorderSize = 2;
            this.unlock_level_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock_level_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlock_level_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.unlock_level_button.Location = new System.Drawing.Point(680, 424);
            this.unlock_level_button.Margin = new System.Windows.Forms.Padding(4);
            this.unlock_level_button.Name = "unlock_level_button";
            this.unlock_level_button.Size = new System.Drawing.Size(240, 74);
            this.unlock_level_button.TabIndex = 5;
            this.unlock_level_button.Text = "Unlock level";
            this.unlock_level_button.UseVisualStyleBackColor = true;
            // 
            // options_button
            // 
            this.options_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.options_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.options_button.FlatAppearance.BorderSize = 2;
            this.options_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.options_button.Location = new System.Drawing.Point(146, 424);
            this.options_button.Margin = new System.Windows.Forms.Padding(4);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(240, 74);
            this.options_button.TabIndex = 4;
            this.options_button.Text = "Options";
            this.options_button.UseVisualStyleBackColor = true;
            this.options_button.Click += new System.EventHandler(this.options_button_Click);
            // 
            // top_scores_button
            // 
            this.top_scores_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top_scores_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.top_scores_button.FlatAppearance.BorderSize = 2;
            this.top_scores_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.top_scores_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_scores_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.top_scores_button.Location = new System.Drawing.Point(680, 239);
            this.top_scores_button.Margin = new System.Windows.Forms.Padding(4);
            this.top_scores_button.Name = "top_scores_button";
            this.top_scores_button.Size = new System.Drawing.Size(240, 74);
            this.top_scores_button.TabIndex = 3;
            this.top_scores_button.Text = "Top scores";
            this.top_scores_button.UseVisualStyleBackColor = true;
            this.top_scores_button.Click += new System.EventHandler(this.top_scores_button_Click);
            // 
            // rules_button
            // 
            this.rules_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rules_button.FlatAppearance.BorderSize = 2;
            this.rules_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rules_button.Location = new System.Drawing.Point(146, 239);
            this.rules_button.Margin = new System.Windows.Forms.Padding(4);
            this.rules_button.Name = "rules_button";
            this.rules_button.Size = new System.Drawing.Size(240, 74);
            this.rules_button.TabIndex = 2;
            this.rules_button.Text = "Rules";
            this.rules_button.UseVisualStyleBackColor = true;
            this.rules_button.Click += new System.EventHandler(this.rules_button_Click);
            // 
            // arcade_game_button
            // 
            this.arcade_game_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arcade_game_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.arcade_game_button.FlatAppearance.BorderSize = 2;
            this.arcade_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arcade_game_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcade_game_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.arcade_game_button.Location = new System.Drawing.Point(680, 55);
            this.arcade_game_button.Margin = new System.Windows.Forms.Padding(4);
            this.arcade_game_button.Name = "arcade_game_button";
            this.arcade_game_button.Size = new System.Drawing.Size(240, 74);
            this.arcade_game_button.TabIndex = 1;
            this.arcade_game_button.Text = "Arcade game";
            this.arcade_game_button.UseVisualStyleBackColor = true;
            // 
            // standard_game_button
            // 
            this.standard_game_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.standard_game_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.standard_game_button.FlatAppearance.BorderSize = 2;
            this.standard_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standard_game_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standard_game_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.standard_game_button.Location = new System.Drawing.Point(146, 55);
            this.standard_game_button.Margin = new System.Windows.Forms.Padding(4);
            this.standard_game_button.Name = "standard_game_button";
            this.standard_game_button.Size = new System.Drawing.Size(240, 74);
            this.standard_game_button.TabIndex = 0;
            this.standard_game_button.Text = "Standard game";
            this.standard_game_button.UseVisualStyleBackColor = true;
            this.standard_game_button.Click += new System.EventHandler(this.standard_game_button_Click);
            // 
            // MainMenuStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.main_menu_panel);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainMenuStateForm";
            this.Text = "MainMenuForm";
            this.main_menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_menu_panel;
        private System.Windows.Forms.Button unlock_level_button;
        private System.Windows.Forms.Button options_button;
        private System.Windows.Forms.Button top_scores_button;
        private System.Windows.Forms.Button rules_button;
        private System.Windows.Forms.Button arcade_game_button;
        private System.Windows.Forms.Button standard_game_button;
    }
}