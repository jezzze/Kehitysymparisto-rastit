using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_peli
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekijä Jesse", "Ristinolla tietoa");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            tarkistaVoittaja();
        }
        private void tarkistaVoittaja()
        {
            bool on_voittaja = false;
            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                on_voittaja = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                on_voittaja = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                on_voittaja = true;

            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                on_voittaja = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                on_voittaja = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                on_voittaja = true;

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                on_voittaja = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                on_voittaja = true;

            if (on_voittaja)
            {

                disableButtons();

                string voittaja = "";
                if (turn)
                    voittaja = "O";
                else
                    voittaja = "X";
                MessageBox.Show(voittaja + " Voittaa!", "Jee!");
            }//if loppu
            else
            {
                if(turn_count == 9)
                    MessageBox.Show("tasapeli!", "voi ei!");

            }
        }//tarkistavoittaja loppu
        private void disableButtons()
        {
            try {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//foreach loppu

            }//try loppu
            catch { }

        }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//foreach loppu

            }//try loppu
            catch { }
        }
    }
}
