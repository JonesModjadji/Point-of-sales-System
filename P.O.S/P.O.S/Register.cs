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
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
          
            Clients Client = new Clients();
            string[] User = new string[4];
            string[] Pass = new string[4];


            for (int i = 0; i < 4; ++i)
            {
                User[i] = txtUserName.Text;
                Client.UserName = User;
                MessageBox.Show(Client.UserName[1]);
            }
            for (int x = 0; x < 0; ++x)
                {
                    Pass[x] = txtPassword.Text;
                    Client.Password = Pass;
                }
                
            

        }
    }
}
