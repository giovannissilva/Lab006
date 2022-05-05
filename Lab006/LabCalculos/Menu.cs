using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab006.LabCalculos;


namespace Lab006.LabCalculos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFrete_Click(object sender, EventArgs e)
        {
            lab006.TelaPrincipal maior = new lab006.TelaPrincipal();
            maior.Show();

        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            lab007.TelaPrincipal frete = new lab007.TelaPrincipal();
            frete.Show();
        }
    }
}
