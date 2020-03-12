namespace Mastermind
{
    partial class Pisteporssi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btVoitotHaviot = new System.Windows.Forms.Button();
            this.btMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(137, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "TOP 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "PISTEPÖRSSI";
            // 
            // btPaavalikko
            // 
            this.btPaavalikko.BackColor = System.Drawing.Color.LightCoral;
            this.btPaavalikko.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btPaavalikko.FlatAppearance.BorderSize = 3;
            this.btPaavalikko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaavalikko.Font = new System.Drawing.Font("Mistral", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaavalikko.ForeColor = System.Drawing.Color.Black;
            this.btPaavalikko.Location = new System.Drawing.Point(244, 400);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 13;
            this.btPaavalikko.Text = "PÄÄVALIKKO";
            this.btPaavalikko.UseVisualStyleBackColor = false;
            this.btPaavalikko.Click += new System.EventHandler(this.btPaavalikko_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(222, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "VOITOT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(14, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = "PELAAJA:";
            // 
            // btVoitotHaviot
            // 
            this.btVoitotHaviot.BackColor = System.Drawing.Color.LightCoral;
            this.btVoitotHaviot.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btVoitotHaviot.FlatAppearance.BorderSize = 3;
            this.btVoitotHaviot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoitotHaviot.Font = new System.Drawing.Font("Mistral", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoitotHaviot.ForeColor = System.Drawing.Color.Black;
            this.btVoitotHaviot.Location = new System.Drawing.Point(19, 396);
            this.btVoitotHaviot.Name = "btVoitotHaviot";
            this.btVoitotHaviot.Size = new System.Drawing.Size(84, 34);
            this.btVoitotHaviot.TabIndex = 26;
            this.btVoitotHaviot.Text = "HÄVIÖT";
            this.btVoitotHaviot.UseVisualStyleBackColor = false;
            this.btVoitotHaviot.Click += new System.EventHandler(this.btVoitotHaviot_Click);
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
            this.btMute.TabIndex = 27;
            this.btMute.UseVisualStyleBackColor = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // Pisteporssi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 443);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.btVoitotHaviot);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pisteporssi";
            this.Text = "Pistepörssi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPaavalikko;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btVoitotHaviot;
        private System.Windows.Forms.Button btMute;
    }
}