
namespace Blockudoku
{
    partial class OptionsStateForm
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
            this.options_groupBox = new System.Windows.Forms.GroupBox();
            this.back_button = new System.Windows.Forms.Button();
            this.theme_comboBox = new System.Windows.Forms.ComboBox();
            this.theme_label = new System.Windows.Forms.Label();
            this.obstacles_checkBox = new System.Windows.Forms.CheckBox();
            this.timed_checkBox = new System.Windows.Forms.CheckBox();
            this.options_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // options_groupBox
            // 
            this.options_groupBox.Controls.Add(this.back_button);
            this.options_groupBox.Controls.Add(this.theme_comboBox);
            this.options_groupBox.Controls.Add(this.theme_label);
            this.options_groupBox.Controls.Add(this.obstacles_checkBox);
            this.options_groupBox.Controls.Add(this.timed_checkBox);
            this.options_groupBox.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_groupBox.ForeColor = System.Drawing.Color.Crimson;
            this.options_groupBox.Location = new System.Drawing.Point(153, 12);
            this.options_groupBox.Name = "options_groupBox";
            this.options_groupBox.Size = new System.Drawing.Size(498, 413);
            this.options_groupBox.TabIndex = 0;
            this.options_groupBox.TabStop = false;
            this.options_groupBox.Text = "Options";
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.back_button.FlatAppearance.BorderSize = 2;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Crimson;
            this.back_button.Location = new System.Drawing.Point(72, 271);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(180, 60);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // theme_comboBox
            // 
            this.theme_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.theme_comboBox.BackColor = System.Drawing.Color.LightCyan;
            this.theme_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme_comboBox.Font = new System.Drawing.Font("Papyrus", 16.25F, System.Drawing.FontStyle.Bold);
            this.theme_comboBox.ForeColor = System.Drawing.Color.Crimson;
            this.theme_comboBox.FormattingEnabled = true;
            this.theme_comboBox.Items.AddRange(new object[] {
            "Theme 1",
            "Theme 2",
            "Theme 3"});
            this.theme_comboBox.Location = new System.Drawing.Point(175, 203);
            this.theme_comboBox.Name = "theme_comboBox";
            this.theme_comboBox.Size = new System.Drawing.Size(121, 42);
            this.theme_comboBox.TabIndex = 3;
            this.theme_comboBox.SelectedIndexChanged += new System.EventHandler(this.theme_comboBox_SelectedIndexChanged);
            // 
            // theme_label
            // 
            this.theme_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.theme_label.AutoSize = true;
            this.theme_label.Font = new System.Drawing.Font("Papyrus", 16.25F, System.Drawing.FontStyle.Bold);
            this.theme_label.Location = new System.Drawing.Point(66, 206);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(100, 34);
            this.theme_label.TabIndex = 2;
            this.theme_label.Text = "Theme :";
            // 
            // obstacles_checkBox
            // 
            this.obstacles_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obstacles_checkBox.AutoSize = true;
            this.obstacles_checkBox.Font = new System.Drawing.Font("Papyrus", 16.25F, System.Drawing.FontStyle.Bold);
            this.obstacles_checkBox.Location = new System.Drawing.Point(72, 144);
            this.obstacles_checkBox.Name = "obstacles_checkBox";
            this.obstacles_checkBox.Size = new System.Drawing.Size(144, 38);
            this.obstacles_checkBox.TabIndex = 1;
            this.obstacles_checkBox.Text = "Obstacles";
            this.obstacles_checkBox.UseVisualStyleBackColor = true;
            this.obstacles_checkBox.CheckedChanged += new System.EventHandler(this.obstacles_checkBox_CheckedChanged);
            // 
            // timed_checkBox
            // 
            this.timed_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timed_checkBox.AutoSize = true;
            this.timed_checkBox.Font = new System.Drawing.Font("Papyrus", 16.25F, System.Drawing.FontStyle.Bold);
            this.timed_checkBox.Location = new System.Drawing.Point(72, 84);
            this.timed_checkBox.Name = "timed_checkBox";
            this.timed_checkBox.Size = new System.Drawing.Size(102, 38);
            this.timed_checkBox.TabIndex = 0;
            this.timed_checkBox.Text = "Timed";
            this.timed_checkBox.UseVisualStyleBackColor = true;
            this.timed_checkBox.CheckedChanged += new System.EventHandler(this.timed_checkBox_CheckedChanged);
            // 
            // OptionsStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.options_groupBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OptionsStateForm";
            this.Text = "OptionsStateForm";
            this.Load += new System.EventHandler(this.OptionsStateForm_Load);
            this.SizeChanged += new System.EventHandler(this.OptionsStateForm_SizeChanged);
            this.options_groupBox.ResumeLayout(false);
            this.options_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox options_groupBox;
        private System.Windows.Forms.ComboBox theme_comboBox;
        private System.Windows.Forms.Label theme_label;
        private System.Windows.Forms.CheckBox obstacles_checkBox;
        private System.Windows.Forms.CheckBox timed_checkBox;
        private System.Windows.Forms.Button back_button;
    }
}