namespace Memory_Gabrieli
{
    partial class Form_Vincitore
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
            this.label1 = new System.Windows.Forms.Label();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 0;
            // 
            // Home_btn
            // 
            this.Home_btn.BackColor = System.Drawing.Color.Black;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home_btn.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Location = new System.Drawing.Point(12, 403);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(98, 35);
            this.Home_btn.TabIndex = 18;
            this.Home_btn.Text = "HOME";
            this.Home_btn.UseVisualStyleBackColor = false;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Black;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn.Font = new System.Drawing.Font("Sylfaen", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(690, 403);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(98, 35);
            this.Exit_btn.TabIndex = 19;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Form_Vincitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Gabrieli.Properties.Resources.The_Avengers_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form_Vincitore";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form_Vicnitore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}