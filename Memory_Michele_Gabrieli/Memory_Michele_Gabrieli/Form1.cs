using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Michele_Gabrieli
{
    public partial class Schermata_Iniziale : Form
    {
        public Schermata_Iniziale()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Schermata_Iniziale Start = new Schermata_Gioco();
            Start.Show();
            this.Hide();
        }
    }
}
