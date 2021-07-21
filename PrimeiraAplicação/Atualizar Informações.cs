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
    public partial class Atualizar_Informações : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Atualizar_Informações()
        {
            InitializeComponent();
        }

        private void Atualizar_Informações_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;database=cad_cliente;Uid=root;Pwd=xavier2004");
                strSQL = "update cliente set nome = @nome, sobrenome = @sobrenome where id = @id";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", textAtualizar.Text);
                comando.Parameters.AddWithValue("@Nome", textNomeAtualizar.Text);
                comando.Parameters.AddWithValue("@sobrenome", textNumeroAtualizar.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Atualizados com Sucesso");
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
    }
}
