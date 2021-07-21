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
    public partial class CarregarImagem : Form
    {
        public CarregarImagem()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textName.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarImagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach(Form formularioAberto in Application.OpenForms)
                {
                    if(formularioAberto is Form1)
                    {
                        formularioAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
