using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PrimeiraAplicação
{
    
    public partial class Cadastrar_Informações : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Cadastrar_Informações()
        {
            InitializeComponent();
        }

        private void Cadastrar_Informações_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else{

                foreach(Form formularioAberto in Application.OpenForms)
                {
                    if(formularioAberto is Tela_Inicial_Banco_de_Dados)
                    {
                        formularioAberto.Show();
                        break;
                    }
                }

            }
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.5;database=cad_cliente;Uid=xavier;Pwd=xavier123");
                strSQL = "insert into cliente(nome, sobrenome) values (@nome, @sobrenome)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", textNome.Text);
                comando.Parameters.AddWithValue("@sobrenome", textNumero.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }


        }

        private void Cadastrar_Informações_Load(object sender, EventArgs e)
        {
            pnlCadastrarInfo.Location = new Point(this.Width / 2 - 351, this.Height / 2 - 160);
        }
    }
}
