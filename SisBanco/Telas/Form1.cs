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
    public partial class intInicio : Form
    {
        public intInicio()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            CriarConta CriarConta = new CriarConta();
            CriarConta.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
        }
    }
}
