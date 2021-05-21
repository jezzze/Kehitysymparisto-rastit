using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin1
{
    public partial class equation : Form
    {
        Double value = 0;
        string operaatio = "";
        bool operaatio_painettu = false;
        public equation()
        {
            InitializeComponent();
        }

      

        private void button_Click(object sender, EventArgs e)
        {
            if ((tulos.Text == "0")||(operaatio_painettu))
                tulos.Clear();

            operaatio_painettu = false;
            Button b = (Button)sender;
            tulos.Text = tulos.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tulos.Text = "0";
        }

        private void operaattori_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operaatio = b.Text;
            value = Double.Parse(tulos.Text);
            operaatio_painettu = true;
            yhtalo.Text = value + " " + operaatio;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            yhtalo.Text = "";
            switch (operaatio)
            {
                case "+":
                    tulos.Text = (value + Double.Parse(tulos.Text)).ToString();
                    break;
                case "-":
                    tulos.Text = (value - Double.Parse(tulos.Text)).ToString();
                    break;
                case "*":
                    tulos.Text = (value * Double.Parse(tulos.Text)).ToString();
                    break;
                case "/":
                    tulos.Text = (value / Double.Parse(tulos.Text)).ToString();
                    break;
                default:
                    break;
            }//switch loppu
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tulos.Text = "";
            value = 0;
        }
    }
}
