using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisBanco.Telas
{
    public partial class TelaDeposito : Form
    {
       
        public TelaDeposito()
        {
            
            InitializeComponent();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
             
            

            //Criar string de conexão
            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-Q91HNJM\\SQLDEV;Initial Catalog=Banco;Integrated Security=True");

           
            //Criar string de inserção sql
            string sql = "update cadastrar set saldoConta = 20 where numeroConta=@numeroConta";

            try { 
            //criar comandos sql
            SqlCommand comando = new SqlCommand(sql, conexao);

            //inserção de dados da txtbox
            comando.Parameters.Add(new SqlParameter("@saldoConta",20));

            //abrir conexao
            conexao.Open();


            //Executar comando no banco
            comando.ExecuteNonQuery();

            //Fechar conexao
            conexao.Close();

            MessageBox.Show("Depósito efetuado com sucesso!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
