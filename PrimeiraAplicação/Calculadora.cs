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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Multiplicação mut = new Multiplicação();
            mut.Show();
            this.Hide();
        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            MultiplicarNumero div = new MultiplicarNumero();
            div.Show();
            this.Hide();
        }

        private void Calculadora_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            Subtração sub = new Subtração();
            sub.Show();
            this.Hide();
        }

        private void btnAdição_Click(object sender, EventArgs e)
        {
            Adição adi = new Adição();
            adi.Show();
            this.Hide();
        }
    }
}
