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
            this.btYksinpeli.Location = new System.Drawing.Point(12, 139);
            this.btYksinpeli.Name = "btYksinpeli";
            this.btYksinpeli.Size = new System.Drawing.Size(215, 115);
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
            this.btMoninpeli.Location = new System.Drawing.Point(327, 139);
            this.btMoninpeli.Name = "btMoninpeli";
            this.btMoninpeli.Size = new System.Drawing.Size(215, 115);
            this.btMoninpeli.TabIndex = 1;
            this.btMoninpeli.Text = "MONINPELI";
            this.btMoninpeli.UseVisualStyleBackColor = false;
            // 
            // btSaavutukset
            // 
            this.btSaavutukset.BackColor = System.Drawing.Color.LightCoral;
            this.btSaavutukset.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btSaavutukset.FlatAppearance.BorderSize = 3;
            this.btSaavutukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaavutukset.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaavutukset.Location = new System.Drawing.Point(12, 273);
            this.btSaavutukset.Name = "btSaavutukset";
            this.btSaavutukset.Size = new System.Drawing.Size(215, 115);
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
            this.btTulokset.Location = new System.Drawing.Point(327, 273);
            this.btTulokset.Name = "btTulokset";
            this.btTulokset.Size = new System.Drawing.Size(215, 115);
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
            this.label1.Location = new System.Drawing.Point(113, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "MASTERMIND";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(557, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTulokset);
            this.Controls.Add(this.btSaavutukset);
            this.Controls.Add(this.btMoninpeli);
            this.Controls.Add(this.btYksinpeli);
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
    }
}

