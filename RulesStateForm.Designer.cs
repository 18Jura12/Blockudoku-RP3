
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
            this.textBox_Rules = new System.Windows.Forms.TextBox();
            this.button_Rules_back = new System.Windows.Forms.Button();
            this.groupBox_Rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Rules
            // 
            this.groupBox_Rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Rules.Controls.Add(this.button_Rules_back);
            this.groupBox_Rules.Controls.Add(this.textBox_Rules);
            this.groupBox_Rules.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Rules.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox_Rules.Location = new System.Drawing.Point(182, 43);
            this.groupBox_Rules.Name = "groupBox_Rules";
            this.groupBox_Rules.Size = new System.Drawing.Size(462, 400);
            this.groupBox_Rules.TabIndex = 0;
            this.groupBox_Rules.TabStop = false;
            this.groupBox_Rules.Text = "Rules";
            // 
            // textBox_Rules
            // 
            this.textBox_Rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Rules.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_Rules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rules.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rules.Location = new System.Drawing.Point(88, 123);
            this.textBox_Rules.Multiline = true;
            this.textBox_Rules.Name = "textBox_Rules";
            this.textBox_Rules.ReadOnly = true;
            this.textBox_Rules.Size = new System.Drawing.Size(100, 22);
            this.textBox_Rules.TabIndex = 0;
            this.textBox_Rules.Text = resources.GetString("textBox_Rules.Text");
            // 
            // button_Rules_back
            // 
            this.button_Rules_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Rules_back.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rules_back.Location = new System.Drawing.Point(183, 357);
            this.button_Rules_back.Name = "button_Rules_back";
            this.button_Rules_back.Size = new System.Drawing.Size(75, 23);
            this.button_Rules_back.TabIndex = 1;
            this.button_Rules_back.Text = "BACK";
            this.button_Rules_back.UseVisualStyleBackColor = true;
            this.button_Rules_back.Click += new System.EventHandler(this.button_Rules_back_Click);
            // 
            // RulesStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 532);
            this.Controls.Add(this.groupBox_Rules);
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
        private System.Windows.Forms.TextBox textBox_Rules;
        private System.Windows.Forms.Button button_Rules_back;
    }
}