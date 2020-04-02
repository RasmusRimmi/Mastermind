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
            this.btMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTekijat
            // 
            this.lbTekijat.AutoSize = true;
            this.lbTekijat.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbTekijat.ForeColor = System.Drawing.Color.White;
            this.lbTekijat.Location = new System.Drawing.Point(174, 211);
            this.lbTekijat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTekijat.Name = "lbTekijat";
            this.lbTekijat.Size = new System.Drawing.Size(94, 35);
            this.lbTekijat.TabIndex = 0;
            this.lbTekijat.Text = "TEKIJÄT";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Mistral", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(200, 70);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(233, 56);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "MASTERMIND";
            // 
            // lbNimi2
            // 
            this.lbNimi2.AutoSize = true;
            this.lbNimi2.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbNimi2.ForeColor = System.Drawing.Color.White;
            this.lbNimi2.Location = new System.Drawing.Point(373, 240);
            this.lbNimi2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNimi2.Name = "lbNimi2";
            this.lbNimi2.Size = new System.Drawing.Size(65, 29);
            this.lbNimi2.TabIndex = 3;
            this.lbNimi2.Text = "RIINA";
            // 
            // lbNimi1
            // 
            this.lbNimi1.AutoSize = true;
            this.lbNimi1.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.lbNimi1.ForeColor = System.Drawing.Color.White;
            this.lbNimi1.Location = new System.Drawing.Point(373, 211);
            this.lbNimi1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNimi1.Name = "lbNimi1";
            this.lbNimi1.Size = new System.Drawing.Size(83, 29);
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
            this.btPaavalikko.Location = new System.Drawing.Point(495, 335);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 14;
            this.btPaavalikko.Text = "PÄÄVALIKKO";
            this.btPaavalikko.UseVisualStyleBackColor = false;
            this.btPaavalikko.Click += new System.EventHandler(this.btPaavalikko_Click);
            // 
            // btMute
            // 
            this.btMute.BackColor = System.Drawing.Color.LightCoral;
            this.btMute.BackgroundImage = global::Mastermind.Properties.Resources.on;
            this.btMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMute.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btMute.FlatAppearance.BorderSize = 3;
            this.btMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMute.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMute.Location = new System.Drawing.Point(12, 12);
            this.btMute.Name = "btMute";
            this.btMute.Size = new System.Drawing.Size(61, 44);
            this.btMute.TabIndex = 19;
            this.btMute.UseVisualStyleBackColor = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(628, 395);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.lbNimi1);
            this.Controls.Add(this.lbNimi2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbTekijat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Credits_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTekijat;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNimi2;
        private System.Windows.Forms.Label lbNimi1;
        private System.Windows.Forms.Button btPaavalikko;
        private System.Windows.Forms.Button btMute;
    }
}