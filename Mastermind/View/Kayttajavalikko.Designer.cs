namespace Mastermind
{
    partial class Kayttajavalikko
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
            this.btUusiKayttaja = new System.Windows.Forms.Button();
            this.btValitse = new System.Windows.Forms.Button();
            this.tbKayttaja = new System.Windows.Forms.TextBox();
            this.cbKayttaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            this.btMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUusiKayttaja
            // 
            this.btUusiKayttaja.BackColor = System.Drawing.Color.LightCoral;
            this.btUusiKayttaja.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btUusiKayttaja.FlatAppearance.BorderSize = 3;
            this.btUusiKayttaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUusiKayttaja.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUusiKayttaja.ForeColor = System.Drawing.Color.Black;
            this.btUusiKayttaja.Location = new System.Drawing.Point(225, 101);
            this.btUusiKayttaja.Name = "btUusiKayttaja";
            this.btUusiKayttaja.Size = new System.Drawing.Size(146, 43);
            this.btUusiKayttaja.TabIndex = 1;
            this.btUusiKayttaja.Text = "LISÄÄ KÄYTTÄJÄ";
            this.btUusiKayttaja.UseVisualStyleBackColor = false;
            this.btUusiKayttaja.EnabledChanged += new System.EventHandler(this.tbKayttaja_TextChanged);
            this.btUusiKayttaja.Click += new System.EventHandler(this.btUusiKayttaja_Click);
            // 
            // btValitse
            // 
            this.btValitse.BackColor = System.Drawing.Color.LightCoral;
            this.btValitse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btValitse.FlatAppearance.BorderSize = 3;
            this.btValitse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValitse.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValitse.ForeColor = System.Drawing.Color.Black;
            this.btValitse.Location = new System.Drawing.Point(225, 187);
            this.btValitse.Name = "btValitse";
            this.btValitse.Size = new System.Drawing.Size(146, 43);
            this.btValitse.TabIndex = 2;
            this.btValitse.Text = "VALITSE";
            this.btValitse.UseVisualStyleBackColor = false;
            this.btValitse.Click += new System.EventHandler(this.btValitse_Click);
            // 
            // tbKayttaja
            // 
            this.tbKayttaja.Location = new System.Drawing.Point(48, 101);
            this.tbKayttaja.Name = "tbKayttaja";
            this.tbKayttaja.Size = new System.Drawing.Size(146, 20);
            this.tbKayttaja.TabIndex = 3;
            this.tbKayttaja.TextChanged += new System.EventHandler(this.tbKayttaja_TextChanged);
            // 
            // cbKayttaja
            // 
            this.cbKayttaja.FormattingEnabled = true;
            this.cbKayttaja.Location = new System.Drawing.Point(48, 187);
            this.cbKayttaja.Name = "cbKayttaja";
            this.cbKayttaja.Size = new System.Drawing.Size(146, 21);
            this.cbKayttaja.TabIndex = 4;
            this.cbKayttaja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbKayttaja_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "VALITSE KÄYTTÄJÄ";
            // 
            // btPaavalikko
            // 
            this.btPaavalikko.BackColor = System.Drawing.Color.LightCoral;
            this.btPaavalikko.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btPaavalikko.FlatAppearance.BorderSize = 3;
            this.btPaavalikko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaavalikko.Font = new System.Drawing.Font("Mistral", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaavalikko.ForeColor = System.Drawing.Color.Black;
            this.btPaavalikko.Location = new System.Drawing.Point(267, 267);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 6;
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
            this.btMute.TabIndex = 7;
            this.btMute.UseVisualStyleBackColor = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // Kayttajavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(401, 329);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKayttaja);
            this.Controls.Add(this.tbKayttaja);
            this.Controls.Add(this.btValitse);
            this.Controls.Add(this.btUusiKayttaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kayttajavalikko";
            this.Text = "Kayttajavalikko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUusiKayttaja;
        private System.Windows.Forms.Button btValitse;
        private System.Windows.Forms.TextBox tbKayttaja;
        private System.Windows.Forms.ComboBox cbKayttaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPaavalikko;
        private System.Windows.Forms.Button btMute;
    }
}