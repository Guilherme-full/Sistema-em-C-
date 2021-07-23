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
    public partial class Tela_Inicial_Banco_de_Dados : Form
    {
        public Tela_Inicial_Banco_de_Dados()
        {
            InitializeComponent();
        }

        private void btnCadastarInform_Click(object sender, EventArgs e)
        {
            Cadastrar_Informações cadas = new Cadastrar_Informações();
            cadas.Show();
            this.Hide();
        }

        private void Tela_Inicial_Banco_de_Dados_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnAtualizaInfo_Click(object sender, EventArgs e)
        {
            Atualizar_Informações atua = new Atualizar_Informações();
            atua.Show();
            this.Hide();
        }

        private void ExcluirInfo_Click(object sender, EventArgs e)
        {
            Excluir_Informações exclu = new Excluir_Informações();
            exclu.Show();
            this.Hide();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Exibir_Informações exi = new Exibir_Informações();
            exi.Show();
            this.Hide();
        }

        private void Tela_Inicial_Banco_de_Dados_Load(object sender, EventArgs e)
        {
            pnlTelaInicialBanco.Location = new Point(this.Width / 2 - 412, this.Height / 2 - 133);
        }
    }
}
