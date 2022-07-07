namespace Marcus_Exe_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bnt_LigaDesliga = new System.Windows.Forms.Button();
            this.Bnt_TrocaBateria = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bnt_LigaDesliga
            // 
            this.Bnt_LigaDesliga.BackColor = System.Drawing.Color.White;
            this.Bnt_LigaDesliga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bnt_LigaDesliga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bnt_LigaDesliga.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Bnt_LigaDesliga.Location = new System.Drawing.Point(360, 97);
            this.Bnt_LigaDesliga.Name = "Bnt_LigaDesliga";
            this.Bnt_LigaDesliga.Size = new System.Drawing.Size(114, 46);
            this.Bnt_LigaDesliga.TabIndex = 1;
            this.Bnt_LigaDesliga.Text = "LigaDesliga";
            this.Bnt_LigaDesliga.UseVisualStyleBackColor = false;
            this.Bnt_LigaDesliga.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bnt_TrocaBateria
            // 
            this.Bnt_TrocaBateria.Location = new System.Drawing.Point(360, 160);
            this.Bnt_TrocaBateria.Name = "Bnt_TrocaBateria";
            this.Bnt_TrocaBateria.Size = new System.Drawing.Size(114, 46);
            this.Bnt_TrocaBateria.TabIndex = 2;
            this.Bnt_TrocaBateria.Text = "Troca Bateria";
            this.Bnt_TrocaBateria.UseMnemonic = false;
            this.Bnt_TrocaBateria.UseVisualStyleBackColor = true;
            this.Bnt_TrocaBateria.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Marcus_Exe_2.Properties.Resources.luz;
            this.pictureBox2.Location = new System.Drawing.Point(217, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marcus_Exe_2.Properties.Resources.Lanterna1;
            this.pictureBox1.Location = new System.Drawing.Point(217, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.Bnt_TrocaBateria);
            this.Controls.Add(this.Bnt_LigaDesliga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Wind";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bnt_LigaDesliga;
        private System.Windows.Forms.Button Bnt_TrocaBateria;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

