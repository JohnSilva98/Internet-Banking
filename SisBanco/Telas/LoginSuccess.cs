using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisBanco
{
    public partial class LoginSuccess : Form
    {
        public LoginSuccess()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginSuccess logado = new LoginSuccess();
            MessageBox.Show("Obrigado por usar o Internet Banking !");
            this.Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

        }
    }
}
