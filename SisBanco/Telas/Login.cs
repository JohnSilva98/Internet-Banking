using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SisBanco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Criar string de conexão
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-Q91HNJM\\SQLDEV;Initial Catalog=banco;Integrated Security=True");
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * from cadastrar where numeroConta = @numConta and senha = @senha";
            comando.Parameters.Add("@numConta", SqlDbType.Int).Value = txtNumContaLogin.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaLogi.Text;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Usuário autenticado!");
                LoginSuccess loginsucess = new LoginSuccess();
                this.Close();
                loginsucess.Show();
            }
            else {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
            conexao.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
