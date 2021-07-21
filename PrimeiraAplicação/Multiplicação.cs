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
    public partial class Multiplicação : Form
    {
        public Multiplicação()
        {
            InitializeComponent();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            int resultado = num1 * num2;
            Result.Text = resultado.ToString();
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void text1_MouseClick(object sender, MouseEventArgs e)
        {
            text1.Text = "";
        }

        private void text2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void text2_MouseClick(object sender, MouseEventArgs e)
        {
            text2.Text = "";
        }

        private void Multiplicação_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formularioAberto in Application.OpenForms)
                {
                    if (formularioAberto is Calculadora)
                    {
                        formularioAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
