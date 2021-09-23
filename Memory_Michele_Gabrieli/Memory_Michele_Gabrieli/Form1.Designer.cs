namespace Memory_Michele_Gabrieli
{
    partial class Schermata_Iniziale
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_btn.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.ForeColor = System.Drawing.Color.White;
            this.Start_btn.Location = new System.Drawing.Point(588, 388);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(112, 63);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start!";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Schermata_Iniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Michele_Gabrieli.Properties.Resources.Marvel_sfondo;
            this.ClientSize = new System.Drawing.Size(1181, 606);
            this.Controls.Add(this.Start_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Schermata_Iniziale";
            this.Text = "Marvel Edition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
    }
}

