﻿namespace Mastermind
{
    partial class Saavutukset
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
            this.cbKayttaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSaavutukset = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaavutukset)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKayttaja
            // 
            this.cbKayttaja.FormattingEnabled = true;
            this.cbKayttaja.Location = new System.Drawing.Point(19, 112);
            this.cbKayttaja.Name = "cbKayttaja";
            this.cbKayttaja.Size = new System.Drawing.Size(146, 21);
            this.cbKayttaja.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "SAAVUTUKSET";
            // 
            // dgvSaavutukset
            // 
            this.dgvSaavutukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaavutukset.Location = new System.Drawing.Point(19, 186);
            this.dgvSaavutukset.Name = "dgvSaavutukset";
            this.dgvSaavutukset.Size = new System.Drawing.Size(323, 252);
            this.dgvSaavutukset.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(186, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "VALITSE KÄYTTÄJÄ";
            // 
            // btPaavalikko
            // 
            this.btPaavalikko.BackColor = System.Drawing.Color.LightCoral;
            this.btPaavalikko.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btPaavalikko.FlatAppearance.BorderSize = 3;
            this.btPaavalikko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPaavalikko.Font = new System.Drawing.Font("Mistral", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaavalikko.ForeColor = System.Drawing.Color.Black;
            this.btPaavalikko.Location = new System.Drawing.Point(238, 457);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 10;
            this.btPaavalikko.Text = "PÄÄVALIKKO";
            this.btPaavalikko.UseVisualStyleBackColor = false;
            this.btPaavalikko.Click += new System.EventHandler(this.btPaavalikko_Click);
            // 
            // Saavutukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(366, 515);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSaavutukset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKayttaja);
            this.Name = "Saavutukset";
            this.Text = "Saavutukset";
            this.Load += new System.EventHandler(this.Saavutukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaavutukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKayttaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSaavutukset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPaavalikko;
    }
}