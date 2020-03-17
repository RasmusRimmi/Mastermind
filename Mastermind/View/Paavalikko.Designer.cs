namespace Mastermind
{
    partial class Paavalikko
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
            this.btYksinpeli = new System.Windows.Forms.Button();
            this.btMoninpeli = new System.Windows.Forms.Button();
            this.btSaavutukset = new System.Windows.Forms.Button();
            this.btTulokset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btYksinpeli
            // 
            this.btYksinpeli.BackColor = System.Drawing.Color.LightCoral;
            this.btYksinpeli.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btYksinpeli.FlatAppearance.BorderSize = 3;
            this.btYksinpeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYksinpeli.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYksinpeli.ForeColor = System.Drawing.Color.Black;
            this.btYksinpeli.Location = new System.Drawing.Point(16, 171);
            this.btYksinpeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btYksinpeli.Name = "btYksinpeli";
            this.btYksinpeli.Size = new System.Drawing.Size(287, 142);
            this.btYksinpeli.TabIndex = 0;
            this.btYksinpeli.Text = "YKSINPELI";
            this.btYksinpeli.UseVisualStyleBackColor = false;
            this.btYksinpeli.Click += new System.EventHandler(this.btYksinpeli_Click);
            // 
            // btMoninpeli
            // 
            this.btMoninpeli.BackColor = System.Drawing.Color.LightCoral;
            this.btMoninpeli.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btMoninpeli.FlatAppearance.BorderSize = 3;
            this.btMoninpeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMoninpeli.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoninpeli.Location = new System.Drawing.Point(436, 171);
            this.btMoninpeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMoninpeli.Name = "btMoninpeli";
            this.btMoninpeli.Size = new System.Drawing.Size(287, 142);
            this.btMoninpeli.TabIndex = 1;
            this.btMoninpeli.Text = "CREDITS";
            this.btMoninpeli.UseVisualStyleBackColor = false;
            this.btMoninpeli.Click += new System.EventHandler(this.btMoninpeli_Click);
            // 
            // btSaavutukset
            // 
            this.btSaavutukset.BackColor = System.Drawing.Color.LightCoral;
            this.btSaavutukset.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btSaavutukset.FlatAppearance.BorderSize = 3;
            this.btSaavutukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaavutukset.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaavutukset.Location = new System.Drawing.Point(16, 336);
            this.btSaavutukset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSaavutukset.Name = "btSaavutukset";
            this.btSaavutukset.Size = new System.Drawing.Size(287, 142);
            this.btSaavutukset.TabIndex = 2;
            this.btSaavutukset.Text = "SAAVUTUKSET";
            this.btSaavutukset.UseVisualStyleBackColor = false;
            this.btSaavutukset.Click += new System.EventHandler(this.btSaavutukset_Click);
            // 
            // btTulokset
            // 
            this.btTulokset.BackColor = System.Drawing.Color.LightCoral;
            this.btTulokset.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btTulokset.FlatAppearance.BorderSize = 3;
            this.btTulokset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTulokset.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTulokset.Location = new System.Drawing.Point(436, 336);
            this.btTulokset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTulokset.Name = "btTulokset";
            this.btTulokset.Size = new System.Drawing.Size(287, 142);
            this.btTulokset.TabIndex = 3;
            this.btTulokset.Text = "TILASTOT";
            this.btTulokset.UseVisualStyleBackColor = false;
            this.btTulokset.Click += new System.EventHandler(this.btTulokset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(151, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 101);
            this.label1.TabIndex = 4;
            this.label1.Text = "MASTERMIND";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btMute.Location = new System.Drawing.Point(16, 15);
            this.btMute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMute.Name = "btMute";
            this.btMute.Size = new System.Drawing.Size(81, 54);
            this.btMute.TabIndex = 5;
            this.btMute.UseVisualStyleBackColor = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(743, 510);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTulokset);
            this.Controls.Add(this.btSaavutukset);
            this.Controls.Add(this.btMoninpeli);
            this.Controls.Add(this.btYksinpeli);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Paavalikko";
            this.Text = "MASTERMIND";
            this.Load += new System.EventHandler(this.Paavalikko_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYksinpeli;
        private System.Windows.Forms.Button btMoninpeli;
        private System.Windows.Forms.Button btSaavutukset;
        private System.Windows.Forms.Button btTulokset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMute;
    }
}

