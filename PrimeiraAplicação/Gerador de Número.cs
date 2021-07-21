using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAplicação
{
    public partial class Gerador_de_Número : Form
    {
        public Gerador_de_Número()
        {
            InitializeComponent();
        }

        private void Gerador_Click(object sender, EventArgs e)
        {
            Random NumAleatorio = new Random();
            int NumeroInteiro = NumAleatorio.Next();
            double NumeroDouble = NumAleatorio.NextDouble();
            NuInt.Text = NumeroInteiro.ToString();
            NuDouble.Text = NumeroDouble.ToString();

        }

        private void Gerador_de_Número_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formularioAberto in Application.OpenForms)
                {
                    if (formularioAberto is Form1)
                    {
                        formularioAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
