namespace Memory_Gabrieli
{
    partial class Form_Start
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomePlayer1_txt = new System.Windows.Forms.TextBox();
            this.NomePlayer2_txt = new System.Windows.Forms.TextBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Regole_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci nome player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(361, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci nome player 2:";
            // 
            // NomePlayer1_txt
            // 
            this.NomePlayer1_txt.Location = new System.Drawing.Point(17, 88);
            this.NomePlayer1_txt.Name = "NomePlayer1_txt";
            this.NomePlayer1_txt.Size = new System.Drawing.Size(244, 20);
            this.NomePlayer1_txt.TabIndex = 2;
            // 
            // NomePlayer2_txt
            // 
            this.NomePlayer2_txt.Location = new System.Drawing.Point(366, 88);
            this.NomePlayer2_txt.Name = "NomePlayer2_txt";
            this.NomePlayer2_txt.Size = new System.Drawing.Size(244, 20);
            this.NomePlayer2_txt.TabIndex = 3;
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_btn.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.ForeColor = System.Drawing.Color.White;
            this.Start_btn.Location = new System.Drawing.Point(255, 214);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(100, 48);
            this.Start_btn.TabIndex = 4;
            this.Start_btn.Text = "Start!!";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Regole_btn
            // 
            this.Regole_btn.BackColor = System.Drawing.Color.Transparent;
            this.Regole_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regole_btn.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regole_btn.ForeColor = System.Drawing.Color.White;
            this.Regole_btn.Location = new System.Drawing.Point(255, 294);
            this.Regole_btn.Name = "Regole_btn";
            this.Regole_btn.Size = new System.Drawing.Size(100, 48);
            this.Regole_btn.TabIndex = 5;
            this.Regole_btn.Text = "Regole";
            this.Regole_btn.UseVisualStyleBackColor = false;
            this.Regole_btn.Click += new System.EventHandler(this.Regole_btn_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Gabrieli.Properties.Resources.sfondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(622, 475);
            this.Controls.Add(this.Regole_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.NomePlayer2_txt);
            this.Controls.Add(this.NomePlayer1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomePlayer1_txt;
        private System.Windows.Forms.TextBox NomePlayer2_txt;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Regole_btn;
    }
}

