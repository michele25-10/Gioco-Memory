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
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void Regole_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MEMORY: \n -Lo scopo del gioco è di trovare le coppie delle figure.\n" +
                "Il player che troverà più coppie vincerà.");
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            Program.NomePlayer1 = NomePlayer1_txt.Text;
            Program.NomePlayer2 = NomePlayer2_txt.Text;

            if (NomePlayer1_txt.Text == "")
            {
                MessageBox.Show("Inserisci Nome Player 1!");
            }
            if (NomePlayer2_txt.Text == "")
            {
                MessageBox.Show("Inserisci Nome Player 2!");
            }

            if (NomePlayer1_txt.Text != "" || NomePlayer2_txt.Text != "")
            {
                Form_Gioco Gioco = new Form_Gioco();
                Gioco.Show();
                this.Hide();
            }
        }
    }
}
