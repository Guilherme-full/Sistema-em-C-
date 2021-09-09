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
    public partial class Excluir_Informações : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Excluir_Informações()
        {
            InitializeComponent();
        }

        private void Excluir_Informações_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=cad_cliente;Uid=xavier;Pwd=xavier123");
                strSQL = "delete from cliente where id = @id";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", textExcluir.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados deletados com sucesso");
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

        private void Excluir_Informações_Load(object sender, EventArgs e)
        {
            pnlExcluirInfo.Location =  new Point(this.Width / 2 - 299, this.Height / 2 - 125);
        }
    }
}
