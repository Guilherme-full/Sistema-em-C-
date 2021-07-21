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
    public partial class Adição : Form
    {
        public Adição()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            int resultado = num1 + num2;
            Result.Text = resultado.ToString();
        }

        private void Adição_FormClosed(object sender, FormClosedEventArgs e)
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
