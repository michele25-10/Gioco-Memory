using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicheleGabrieli_Memory
{
    public partial class Form_Gioco : Form
    {
        public Form_Gioco()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Start_btn.Visible = false;
            Esci_btn.Visible = false;

            PictureBox pictureBox1 = new PictureBox();  //Creazzione picture box da sostituire a bottone start_btn nel table panel
            pictureBox1.Visible = false;
            pictureBox1.ClientSize = new Size(253, 175);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox pictureBox4 = new PictureBox();  //Creazzione picture box da sostituire a bottone esci_btn nel table panel
            pictureBox1.Visible = false;
            pictureBox1.ClientSize = new Size(253, 175);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            AssegnazioneImmagini();
        }

        private void Esci_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

        private void AssegnazioneImmagini()
        {
            Random random = new Random();
            int NumeroCasuale;
            NumeroCasuale = random.Next(0, 15);
        }
    }
}
