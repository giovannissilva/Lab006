using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab006.LabCalculos.lab006
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public void MaiorDeTres()
        {
            int Valor1 = Convert.ToInt32(nudValor1.Text);
            int Valor2 = Convert.ToInt32(nudValor2.Text);
            int Valor3 = Convert.ToInt32(nudValor3.Text);
            int maior = 0;

            if (Valor1 == Valor2 && Valor2 == Valor3)
            {
                lblResultado.Text = "Os Números tem o mesmo Valor. ";
                return;
            }

            maior = Valor1;

            if (Valor2 > maior)
            {
                maior = Valor2;
            }

            if (Valor3 > maior)
            {
                maior = Valor3;
            }

            if (Valor1 > Valor2 && Valor1 > Valor3)
            {
                lblResultado.Text = "O Maior Valor É " + Valor1.ToString();
            }
            else if (Valor2 > Valor3 && Valor2 > Valor1)
            {
                lblResultado.Text = "O Maior Valor É " + Valor2.ToString();
            }
            else if (Valor3 > Valor2 && Valor3 > Valor1)
            {
                lblResultado.Text = "O Maior Valor É " + Valor3.ToString();
            }
            else if (Valor1 == Valor2 && Valor1 > Valor3)
            {
                lblResultado.Text = "Os Dois Maiores Valores São " + Valor1.ToString();
            }
            else if (Valor2 == Valor3 && Valor2 > Valor1)
            {
                lblResultado.Text = "Os Dois Maiores Valores São " + Valor2.ToString();
            }
            else if (Valor3 == Valor1 && Valor3 > Valor2)
            {
                lblResultado.Text = "Os Dois Maiores Valores São " + Valor3.ToString();
            }


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
        }
    }
}
