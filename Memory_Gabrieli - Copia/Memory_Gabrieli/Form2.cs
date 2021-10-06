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
    public partial class Form_Gioco : Form
    {
        public Form_Gioco()
        {
            InitializeComponent();
        }

        bool TurnoPL1;
        static int Thor = 0, Wanda = 0, Hulk = 0, Captain = 0;
        int[] QuantitàGenerate = new int[4] { Thor, Wanda, Hulk, Captain };
        string[] EroeGenerato = new string[8];
        PictureBox[] Carte = new PictureBox[8];
        Button[] Bottoni = new Button[8];
        int CarteGirate = 0, Carta1 = 0, Carta2 = 0, CoppiePL1 = 0, CoppiePL2 = 0;
        int NumeroBottone; 

        private void Form_Gioco_Load(object sender, EventArgs e)
        {
            PartenzaPlayer();//Genero quale player partirà

            PunteggioPlayer1_lbl.Text = ("Punteggio " + Program.NomePlayer1 + ": " + Program.PunteggioPlayer1);
            PunteggioPlayer2_lbl.Text = ("Punteggio " + Program.NomePlayer2 + ": " + Program.PunteggioPlayer2);     //Lo comunico

            GenerazioneImmagini();  //Genero le immagini dentro le picture box
        }

        private void Home_btn_Click(object sender, EventArgs e)     //Reset variabili e ritorno alla HOME
        {
            Ripristino();

            Form_Start Start = new Form_Start();
            Start.Show();
            this.Hide();
        }

        private void Ripristino()   //azzero ogni variabile
        {
            Thor = 0;
            Wanda = 0;
            Hulk = 0;
            Captain = 0;
            TurnoPL1 = false;
            CarteGirate = 0;
            Carta1 = 0;
            Carta2 = 0;
            CoppiePL1 = 0;
            CoppiePL2 = 0;
            for (int a = 0; a < EroeGenerato.Length; a++)
            {
                EroeGenerato[a] = "";
            }
            for (int a = 0; a < QuantitàGenerate.Length; a++)
            {
                QuantitàGenerate[a] = 0;
            }
            NumeroBottone = 0;
            CoppiePL1 = 0;
            CoppiePL2 = 0;
        }

        private void Exit_btn_Click(object sender, EventArgs e)     //Chiusura programma
        {
            Application.Exit();
        }
        private void PartenzaPlayer()       //Random per far partire quel player.
        {
            Random random = new Random();

            int Partenza = random.Next(0, 2);

            switch (Partenza)
            {
                case 0:
                    Turni_lbl.Text = "Parte " + Program.NomePlayer1;
                    TurnoPL1 = true;
                    break;

                case 1:
                    Turni_lbl.Text = "Parte " + Program.NomePlayer2;
                    TurnoPL1 = false;
                    break;
            }
        }



        private void GenerazioneImmagini()
        {
            Random random = new Random();
            int Nrandom = 0;
            for (int i = 0; i < 8; i++)
            {
                Nrandom = random.Next(0, 4);    //genero un numero random
                ConteggioCarte(Nrandom);    //verifico che quel numero non fosse stato generato piu di 2 volte
                if (i > 1 && Verifica(Nrandom) == -1)
                {
                    i--;    // Se è stato generato 3 volte decremento la i e rigenero nrandom
                }
                else
                {
                    EroeGenerato[i] = TipoCarta(Nrandom);   //Assegno a quell'indice del vettore il nome dell'eroe presente nell'immagine
                }

            }
            AssegnazioneImmagini();
        }
        private void ConteggioCarte(int n)
        {
            if (QuantitàGenerate[n] < 3)
            {
                QuantitàGenerate[n]++;
            }
        }

        private int Verifica(int n)
        {
            if (QuantitàGenerate[n] == 3)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }



        private string TipoCarta(int Carta)
        {
            string TipoEroe = "";
            switch (Carta)
            {
                case 0:
                    TipoEroe = "thor";
                    break;
                case 1:
                    TipoEroe = "wanda";
                    break;
                case 2:
                    TipoEroe = "hulk";
                    break;
                case 3:
                    TipoEroe = "Captain";
                    break;
            };
            return TipoEroe;
        }



        private void AssegnazioneImmagini()     //assegno le immagini alle picturebox
        {
            Carte[0] = pictureBox1;
            Carte[1] = pictureBox2;
            Carte[2] = pictureBox3;
            Carte[3] = pictureBox4;
            Carte[4] = pictureBox5;
            Carte[5] = pictureBox6;
            Carte[6] = pictureBox7;
            Carte[7] = pictureBox8;
            Bottoni[0] = button1;
            Bottoni[1] = button2;
            Bottoni[2] = button3;
            Bottoni[3] = button4;
            Bottoni[4] = button5;
            Bottoni[5] = button6;
            Bottoni[6] = button7;
            Bottoni[7] = button8;
            int a;
            for (a = 0; a < 8; a++)
            {
                Carte[a].Image = Immagini(a);
            }

        }



        private System.Drawing.Image Immagini(int a)    //assegno l'indirizzo dell'immagine
        {
                if (EroeGenerato[a] == "thor")
                {
                    return Properties.Resources.thor;
                }
                else if (EroeGenerato[a] == "wanda")
                {
                    return Properties.Resources.wanda;
                }
                else if (EroeGenerato[a] == "hulk")
                {
                    return Properties.Resources.hulk;
                }
                else
                {
                    return Properties.Resources.Captain_america;
                }
        }



        private void button1_Click(object sender, EventArgs e)      //quando viene cliccato un bottone sparisce e compare l'immagine sottostante
        {
            button1.Visible = false;
            pictureBox1.Visible = true;     
            NumeroBottone = 1;          //Assegno il numero di bottone cosi so quale è stato attivato
            Controllo();            //Controllo quante carte sono già state girate
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            pictureBox2.Visible = true;
            NumeroBottone = 2;
            Controllo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            button3.Visible = false;
            NumeroBottone = 3;
            Controllo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            button4.Visible = false;
            NumeroBottone = 4;
            Controllo();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            button5.Visible = false;
            NumeroBottone = 5;
            Controllo();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            button6.Visible = false;
            NumeroBottone = 6;
            Controllo();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            button7.Visible = false;
            NumeroBottone = 7;
            Controllo();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            button8.Visible = false;
            NumeroBottone = 8;
            Controllo();
        }
        private void Controllo()
        {
            if (CarteGirate == 2)       //Se sono state girate 2 carte chiamo il controllo delle 2 immagini uguali
            {
                ControlloImmagine();
            }
            if (CarteGirate == 1)   //Se è stata girata solo una carta la incremento e assegno il numero della seconda carta girata
            {
                CarteGirate = 2;
                Carta2 = NumeroBottone;
            }
            if (CarteGirate == 0)   //Se non ci sono carte girate le carte vengono incrementate e assegno il numero della carta uno
            {
                CarteGirate = 1;
                Carta1 = NumeroBottone;
            }
            if (CoppiePL1+CoppiePL2 == 3)       // se sono state trovate 3 coppie e sono state girate 2 immagini chiamo il controllo delle immagini
            {
                if (CarteGirate == 2)
                {
                    ControlloImmagine();
                }
            }
        }

        private void ControlloImmagine()
        {
            if (EroeGenerato[Carta1-1] != EroeGenerato[Carta2-1])       //Se le carte sono diverse rendo di nuovo visibili i bottoni e faccio sparire le picturebox e cambio i turni
            {
                BottoniVisible();
                PictureBoxVisible();
                Turni();
            }
            else               //Se le carte sono uguali chiamo l'altra gestione del turno delle coppie uguali
            {
                TurniCoppia();
            }
            CarteGirate = 0;        //riazzero tutto
            Carta1 = 0;
            Carta2 = 0;
        }
        private void BottoniVisible()   //Faccio apparire i bottoni
        {
            switch (Carta1)
            {
                case 1:
                    button1.Visible = true;
                    break;
                case 2:
                    button2.Visible = true;
                    break;
                case 3:
                    button3.Visible = true;
                    break;
                case 4:
                    button4.Visible = true;
                    break;
                case 5:
                    button5.Visible = true;
                    break;
                case 6:
                    button6.Visible = true;
                    break;
                case 7:
                    button7.Visible = true;
                    break;
                case 8:
                    button8.Visible = true;
                    break;
            }
            switch (Carta2)
            {
                case 1:
                    button1.Visible = true;
                    break;
                case 2:
                    button2.Visible = true;
                    break;
                case 3:
                    button3.Visible = true;
                    break;
                case 4:
                    button4.Visible = true;
                    break;
                case 5:
                    button5.Visible = true;
                    break;
                case 6:
                    button6.Visible = true;
                    break;
                case 7:
                    button7.Visible = true;
                    break;
                case 8:
                    button8.Visible = true;
                    break;
            }
        }
        private void PictureBoxVisible()        
        {
            switch (Carta1)
            {
                case 1:
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    pictureBox2.Visible = true;
                    break;
                case 3:
                    pictureBox3.Visible = true;
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    break;
                case 5:
                    pictureBox5.Visible = true;
                    break;
                case 6:
                    pictureBox6.Visible = true;
                    break;
                case 7:
                    pictureBox7.Visible = true;
                    break;
                case 8:
                    pictureBox8.Visible = true;
                    break;
            }
            switch (Carta1)
            {
                case 1:
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    pictureBox2.Visible = true;
                    break;
                case 3:
                    pictureBox3.Visible = true;
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    break;
                case 5:
                    pictureBox5.Visible = true;
                    break;
                case 6:
                    pictureBox6.Visible = true;
                    break;
                case 7:
                    pictureBox7.Visible = true;
                    break;
                case 8:
                    pictureBox8.Visible = true;
                    break;
            }
        }
        private void Turni()        
        {
            if(TurnoPL1 == true)        //Turni cambio se ha sbagliato e tocca sempre al secondo giocatore
            {
                Turni_lbl.Text = "";
                Turni_lbl.Text = "Tocca a: " + Program.NomePlayer2;
                TurnoPL1 = false;
            }   
            else                       //Sele carte sono sbagliate... tocca sempre al primo giocatore
            {
                Turni_lbl.Text = "";
                Turni_lbl.Text = "Tocca a: " + Program.NomePlayer1;
                TurnoPL1 = true;
            }
        }
        private void TurniCoppia()
        {
            if (TurnoPL1 == true)   //se il player ha ffatto uguale tocca sempre a lui viene incrementato il punteggio e le coppie fatte e viene comunicato
            {
                Program.PunteggioPlayer1++;
                CoppiePL1++;
                PunteggioPlayer1_lbl.Text = "";
                PunteggioPlayer1_lbl.Text = "Punteggio " + Program.NomePlayer1 + ": " + Program.PunteggioPlayer1;
            }
            else                 //se il player ha ffatto uguale tocca sempre a lui viene incrementato il punteggio e le coppie fatte e viene comunicato
            {
                Program.PunteggioPlayer2++;
                CoppiePL2++;
                PunteggioPlayer2_lbl.Text = "";
                PunteggioPlayer2_lbl.Text = "Punteggio " + Program.NomePlayer2 + ": " + Program.PunteggioPlayer2;
            }
            if (CoppiePL2+CoppiePL1 == 4)   //Se le coppie sono 4 su 4  chiamo la funzione vincitore
            {
                Vincitore();
            }
            
        }
        private void Vincitore()    //Ripristina e manda all'altro form
        {
            Ripristino();

            Form_Vincitore vittoria = new Form_Vincitore();
            vittoria.Show();
            this.Close();
        }
    }
}
