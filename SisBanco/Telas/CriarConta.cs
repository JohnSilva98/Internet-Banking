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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void CriarConta_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numconta = new Random();
            int numeroCOnta = numconta.Next(9999);
            txtNumConta.Text = numeroCOnta.ToString();
            


        }

        private void txtNumConta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Criar string de conexão
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-Q91HNJM\\SQLDEV;Initial Catalog=Banco;Integrated Security=True");
           

            //Criar string de inserção sql
            string sql = "insert into cadastrar (Nome, Cpf, Sexo, Telefone, Celular, Senha, numeroConta) values (@Nome, @Cpf, @Sexo, @Telefone, @Celular, @Senha, @numeroConta)";
            
            try
            {
                //criar comandos sql
                SqlCommand comando = new SqlCommand(sql, conexao);
               

                //inserção de dados da txtbox
                //comando.Parameters.Add(new SqlParameter("@idCadastro", numeroID.Next()));
                comando.Parameters.Add(new SqlParameter("@Nome", this.txtNome.Text));
                comando.Parameters.Add(new SqlParameter("@Cpf", this.txtCPF.Text));
                comando.Parameters.Add(new SqlParameter("@Sexo", this.cmBoxSex.Text));
                comando.Parameters.Add(new SqlParameter("@Telefone", this.txtTel.Text));
                comando.Parameters.Add(new SqlParameter("@Celular", this.txtCel.Text));
                comando.Parameters.Add(new SqlParameter("@Senha", this.txtSenha.Text));
                comando.Parameters.Add(new SqlParameter("@numeroConta", this.txtNumConta.Text));
                
                //abrir conexao
                conexao.Open();
              

                //Executar comando no banco
                comando.ExecuteNonQuery();

                //Fechar conexao
                conexao.Close();

                MessageBox.Show("Dados cadastrados com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally {
                conexao.Close();
            }

        }

        private void cmBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
