using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.O.S
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            this.Hide();
            Register.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Clients Client1 = new Clients();
            if (Client1.UserName[1] == txtUser.Text)
            {
                MessageBox.Show("hgh");
            }
            else { MessageBox.Show("UserName Does not exist");
                txtUser.Text = "";
            }
            MessageBox.Show(Client1.UserName[1]);
        }
    }
}
