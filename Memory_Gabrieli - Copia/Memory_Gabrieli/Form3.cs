using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Gabrieli
{
    public partial class Form_Vincitore : Form
    {
        public Form_Vincitore()
        {
            InitializeComponent();
        }

        private void Form_Vicnitore_Load(object sender, EventArgs e)        //Controllo dei punteggi dei player e comunicazione di chi ha vinto
        {
            if (Program.PunteggioPlayer1 > Program.PunteggioPlayer2)
            {
                label1.Text = "Complimenti " + Program.NomePlayer1 + "!!! Hai vinto la partita!";
            }
            if (Program.PunteggioPlayer2 > Program.PunteggioPlayer1)
            {
                label1.Text = "Complimenti " + Program.NomePlayer2 + "!!! Hai vinto la partita!";
            }
            if (Program.PunteggioPlayer1 == Program.PunteggioPlayer2)
            {
                label1.Text = "Bella partita ragazzi, siete allo stesso livello";
            }
        }

        private void Home_btn_Click(object sender, EventArgs e) //impostazioni torna alla home
        {
            Program.PunteggioPlayer1 = 0;
            Program.PunteggioPlayer2 = 0;
            Program.NomePlayer1 = "";
            Program.NomePlayer2 = "";

            Form_Start Start = new Form_Start();
            Start.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e) // impostazioni chiude i form
        {
            Application.Exit();
        }
    }
}
