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
    public partial class Tela_de_Login : Form
    {
        public Tela_de_Login()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            var conexao = "Server=192.168.15.5;Database=logins;Uid=xavier;Pwd=xavier123";
            var connection = new MySqlConnection(conexao);
            var comand = connection.CreateCommand();
            MySqlCommand query = new MySqlCommand("select count(*) from usuarios where NomeUsuario='" + textBox1.Text + "'and senha='" + textBox2.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach(DataRow list in dataTable.Rows)
            {
                if(Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    MessageBox.Show("Usuario valido", "validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form1 inicial = new Form1();
                    inicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Invalido", "validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }

        }

        private void Tela_de_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnVoltarL_Click(object sender, EventArgs e)
        {
            
        }
    }
}
