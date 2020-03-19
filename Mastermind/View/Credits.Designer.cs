namespace Mastermind
{
    partial class Credits
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
            this.lbTekijat = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNimi2 = new System.Windows.Forms.Label();
            this.lbNimi1 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTekijat
            // 
            this.lbTekijat.AutoSize = true;
            this.lbTekijat.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbTekijat.ForeColor = System.Drawing.Color.White;
            this.lbTekijat.Location = new System.Drawing.Point(232, 260);
            this.lbTekijat.Name = "lbTekijat";
            this.lbTekijat.Size = new System.Drawing.Size(145, 55);
            this.lbTekijat.TabIndex = 0;
            this.lbTekijat.Text = "TEKIJÄT";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Mistral", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(267, 86);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(289, 68);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "MASTERMIND";
            // 
            // lbNimi2
            // 
            this.lbNimi2.AutoSize = true;
            this.lbNimi2.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbNimi2.ForeColor = System.Drawing.Color.White;
            this.lbNimi2.Location = new System.Drawing.Point(497, 295);
            this.lbNimi2.Name = "lbNimi2";
            this.lbNimi2.Size = new System.Drawing.Size(79, 35);
            this.lbNimi2.TabIndex = 3;
            this.lbNimi2.Text = "RIINA";
            // 
            // lbNimi1
            // 
            this.lbNimi1.AutoSize = true;
            this.lbNimi1.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbNimi1.ForeColor = System.Drawing.Color.White;
            this.lbNimi1.Location = new System.Drawing.Point(497, 260);
            this.lbNimi1.Name = "lbNimi1";
            this.lbNimi1.Size = new System.Drawing.Size(101, 35);
            this.lbNimi1.TabIndex = 6;
            this.lbNimi1.Text = "RASMUS";
            // 
            // btPaavalikko
            // 
            this.btPaavalikko.BackColor = System.Drawing.Color.LightCoral;
            this.btPaavalikko.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btPaavalikko.FlatAppearance.BorderSize = 3;
            this.btPaavalikko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaavalikko.Font = new System.Drawing.Font("Mistral", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaavalikko.ForeColor = System.Drawing.Color.Black;
            this.btPaavalikko.Location = new System.Drawing.Point(660, 412);
            this.btPaavalikko.Margin = new System.Windows.Forms.Padding(4);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(139, 37);
            this.btPaavalikko.TabIndex = 14;
            this.btPaavalikko.Text = "PÄÄVALIKKO";
            this.btPaavalikko.UseVisualStyleBackColor = false;
            this.btPaavalikko.Click += new System.EventHandler(this.btPaavalikko_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(838, 486);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.lbNimi1);
            this.Controls.Add(this.lbNimi2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbTekijat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Credits";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTekijat;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNimi2;
        private System.Windows.Forms.Label lbNimi1;
        private System.Windows.Forms.Button btPaavalikko;
    }
}