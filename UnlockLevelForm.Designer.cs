
namespace Blockudoku
{
    partial class UnlockLevelForm
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
            this.unlock_level_label = new System.Windows.Forms.Label();
            this.unlock_level_textBox = new System.Windows.Forms.TextBox();
            this.outcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unlock_level_label
            // 
            this.unlock_level_label.AutoSize = true;
            this.unlock_level_label.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold);
            this.unlock_level_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.unlock_level_label.Location = new System.Drawing.Point(28, 62);
            this.unlock_level_label.Name = "unlock_level_label";
            this.unlock_level_label.Size = new System.Drawing.Size(228, 42);
            this.unlock_level_label.TabIndex = 0;
            this.unlock_level_label.Text = "Enter password:";
            // 
            // unlock_level_textBox
            // 
            this.unlock_level_textBox.BackColor = System.Drawing.Color.LightCyan;
            this.unlock_level_textBox.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold);
            this.unlock_level_textBox.Location = new System.Drawing.Point(52, 126);
            this.unlock_level_textBox.MaxLength = 4;
            this.unlock_level_textBox.Name = "unlock_level_textBox";
            this.unlock_level_textBox.Size = new System.Drawing.Size(177, 50);
            this.unlock_level_textBox.TabIndex = 1;
            this.unlock_level_textBox.TextChanged += new System.EventHandler(this.unlock_level_textBox_TextChanged);
            // 
            // outcome_label
            // 
            this.outcome_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outcome_label.Font = new System.Drawing.Font("Papyrus", 10.25F, System.Drawing.FontStyle.Bold);
            this.outcome_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.outcome_label.Location = new System.Drawing.Point(0, 240);
            this.outcome_label.Name = "outcome_label";
            this.outcome_label.Size = new System.Drawing.Size(284, 22);
            this.outcome_label.TabIndex = 2;
            this.outcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnlockLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outcome_label);
            this.Controls.Add(this.unlock_level_textBox);
            this.Controls.Add(this.unlock_level_label);
            this.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnlockLevelForm";
            this.Text = "Unlock Level";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unlock_level_label;
        private System.Windows.Forms.TextBox unlock_level_textBox;
        private System.Windows.Forms.Label outcome_label;
    }
}