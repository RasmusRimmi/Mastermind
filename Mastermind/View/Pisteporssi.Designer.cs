﻿namespace Mastermind
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
            this.dgvPisteporssi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPisteporssi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(133, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "TOP 10";
            // 
            // dgvPisteporssi
            // 
            this.dgvPisteporssi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPisteporssi.Location = new System.Drawing.Point(19, 150);
            this.dgvPisteporssi.Name = "dgvPisteporssi";
            this.dgvPisteporssi.Size = new System.Drawing.Size(323, 282);
            this.dgvPisteporssi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(82, 22);
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
            this.btPaavalikko.Location = new System.Drawing.Point(238, 453);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 13;
            this.btPaavalikko.Text = "PÄÄVALIKKO";
            this.btPaavalikko.UseVisualStyleBackColor = false;
            this.btPaavalikko.Click += new System.EventHandler(this.btPaavalikko_Click);
            // 
            // Pisteporssi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 507);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPisteporssi);
            this.Controls.Add(this.label1);
            this.Name = "Pisteporssi";
            this.Text = "Pistepörssi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPisteporssi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPisteporssi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPaavalikko;
    }
}