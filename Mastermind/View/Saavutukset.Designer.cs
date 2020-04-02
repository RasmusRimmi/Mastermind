namespace Mastermind
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbKayttaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSaavutukset = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btPaavalikko = new System.Windows.Forms.Button();
            this.btMute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaavutukset)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKayttaja
            // 
            this.cbKayttaja.FormattingEnabled = true;
            this.cbKayttaja.Location = new System.Drawing.Point(332, 99);
            this.cbKayttaja.Name = "cbKayttaja";
            this.cbKayttaja.Size = new System.Drawing.Size(146, 21);
            this.cbKayttaja.TabIndex = 6;
            this.cbKayttaja.SelectedValueChanged += new System.EventHandler(this.cbKayttaja_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(382, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "SAAVUTUKSET";
            // 
            // dgvSaavutukset
            // 
            this.dgvSaavutukset.AllowUserToAddRows = false;
            this.dgvSaavutukset.AllowUserToDeleteRows = false;
            this.dgvSaavutukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSaavutukset.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaavutukset.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSaavutukset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaavutukset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaavutukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaavutukset.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaavutukset.EnableHeadersVisualStyles = false;
            this.dgvSaavutukset.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSaavutukset.Location = new System.Drawing.Point(19, 186);
            this.dgvSaavutukset.Name = "dgvSaavutukset";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaavutukset.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaavutukset.RowHeadersVisible = false;
            this.dgvSaavutukset.Size = new System.Drawing.Size(901, 427);
            this.dgvSaavutukset.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(499, 99);
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
            this.btPaavalikko.Location = new System.Drawing.Point(816, 619);
            this.btPaavalikko.Name = "btPaavalikko";
            this.btPaavalikko.Size = new System.Drawing.Size(104, 30);
            this.btPaavalikko.TabIndex = 10;
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
            this.btMute.TabIndex = 18;
            this.btMute.UseVisualStyleBackColor = false;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // Saavutukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(931, 661);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.btPaavalikko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSaavutukset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKayttaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Saavutukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saavutukset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saavutukset_FormClosing);
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
        private System.Windows.Forms.Button btMute;
    }
}