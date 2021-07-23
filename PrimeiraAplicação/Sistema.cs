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
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void Sistema_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Sistema_Load(object sender, EventArgs e)
        {
            pnlSistema.Location = new Point(this.Width / 2 - 397, this.Height / 2 - 193);
        }
    }
}
