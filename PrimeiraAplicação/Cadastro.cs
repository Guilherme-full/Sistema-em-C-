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
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=192.168.15.5;Database=logins;Uid=xavier;Pwd=xavier123");
                strSQL = "insert into usuarios(nome, sobrenome, estado, cidade, NomeUsuario, senha) values(@nome, @sobrenome, @estado, @cidade, @NomeUsuario, @senha)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@sobrenome", txtSobrenome.Text);
                comando.Parameters.AddWithValue("@estado", txtEstado.Text);
                comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@NomeUsuario", txtNomeDeUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso");
            }
            catch(Exception ex)
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

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
