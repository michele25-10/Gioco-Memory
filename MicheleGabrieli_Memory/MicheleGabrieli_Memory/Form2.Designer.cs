namespace MicheleGabrieli_Memory
{
    partial class Form_Start
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
            this.NomePlayer1_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomePlayer2_txt = new System.Windows.Forms.TextBox();
            this.Play_btn = new System.Windows.Forms.Button();
            this.Regole_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Player 1:";
            // 
            // NomePlayer1_txt
            // 
            this.NomePlayer1_txt.Location = new System.Drawing.Point(45, 84);
            this.NomePlayer1_txt.Name = "NomePlayer1_txt";
            this.NomePlayer1_txt.Size = new System.Drawing.Size(158, 20);
            this.NomePlayer1_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Player 2:";
            // 
            // NomePlayer2_txt
            // 
            this.NomePlayer2_txt.Location = new System.Drawing.Point(546, 84);
            this.NomePlayer2_txt.Name = "NomePlayer2_txt";
            this.NomePlayer2_txt.Size = new System.Drawing.Size(158, 20);
            this.NomePlayer2_txt.TabIndex = 3;
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.Color.Transparent;
            this.Play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_btn.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_btn.ForeColor = System.Drawing.Color.White;
            this.Play_btn.Location = new System.Drawing.Point(239, 403);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(101, 52);
            this.Play_btn.TabIndex = 4;
            this.Play_btn.Text = "Play!!";
            this.Play_btn.UseVisualStyleBackColor = false;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Regole_btn
            // 
            this.Regole_btn.BackColor = System.Drawing.Color.Transparent;
            this.Regole_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regole_btn.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regole_btn.ForeColor = System.Drawing.Color.White;
            this.Regole_btn.Location = new System.Drawing.Point(405, 403);
            this.Regole_btn.Name = "Regole_btn";
            this.Regole_btn.Size = new System.Drawing.Size(101, 52);
            this.Regole_btn.TabIndex = 5;
            this.Regole_btn.Text = "Regole";
            this.Regole_btn.UseVisualStyleBackColor = false;
            this.Regole_btn.Click += new System.EventHandler(this.Regole_btn_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MicheleGabrieli_Memory.Properties.Resources.sfondo21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 603);
            this.Controls.Add(this.Regole_btn);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.NomePlayer2_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomePlayer1_txt);
            this.Controls.Add(this.label2);
            this.Name = "Form_Start";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomePlayer1_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomePlayer2_txt;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Regole_btn;
    }
}