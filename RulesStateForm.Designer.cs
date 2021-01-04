
namespace Blockudoku
{
    partial class RulesStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesStateForm));
            this.groupBox_Rules = new System.Windows.Forms.GroupBox();
            this.button_Rules_back = new System.Windows.Forms.Button();
            this.customTextBox_rules = new Blockudoku.CustomTextBox();
            this.groupBox_Rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Rules
            // 
            this.groupBox_Rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Rules.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Rules.Controls.Add(this.customTextBox_rules);
            this.groupBox_Rules.Controls.Add(this.button_Rules_back);
            this.groupBox_Rules.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Rules.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox_Rules.Location = new System.Drawing.Point(182, 43);
            this.groupBox_Rules.Name = "groupBox_Rules";
            this.groupBox_Rules.Size = new System.Drawing.Size(429, 397);
            this.groupBox_Rules.TabIndex = 0;
            this.groupBox_Rules.TabStop = false;
            this.groupBox_Rules.Text = "Rules";
            // 
            // button_Rules_back
            // 
            this.button_Rules_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Rules_back.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rules_back.Location = new System.Drawing.Point(129, 261);
            this.button_Rules_back.Name = "button_Rules_back";
            this.button_Rules_back.Size = new System.Drawing.Size(75, 23);
            this.button_Rules_back.TabIndex = 1;
            this.button_Rules_back.Text = "BACK";
            this.button_Rules_back.UseVisualStyleBackColor = true;
            this.button_Rules_back.Click += new System.EventHandler(this.button_Rules_back_Click);
            // 
            // customTextBox_rules
            // 
            this.customTextBox_rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox_rules.BackColor = System.Drawing.Color.Transparent;
            this.customTextBox_rules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox_rules.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox_rules.Location = new System.Drawing.Point(129, 152);
            this.customTextBox_rules.Multiline = true;
            this.customTextBox_rules.Name = "customTextBox_rules";
            this.customTextBox_rules.ReadOnly = true;
            this.customTextBox_rules.Size = new System.Drawing.Size(100, 22);
            this.customTextBox_rules.TabIndex = 1;
            this.customTextBox_rules.Text = resources.GetString("customTextBox_rules.Text");
            // 
            // RulesStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blockudoku.Properties.Resources.simple_blue_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 532);
            this.Controls.Add(this.groupBox_Rules);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RulesStateForm";
            this.Text = "RulesStateForm";
            this.SizeChanged += new System.EventHandler(this.RulesStateForm_SizeChanged);
            this.groupBox_Rules.ResumeLayout(false);
            this.groupBox_Rules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Rules;
        private System.Windows.Forms.Button button_Rules_back;
        private CustomTextBox customTextBox_rules;
    }
}