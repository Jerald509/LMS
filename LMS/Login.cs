using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            LMSEntities1 content = new LMSEntities1();
            if (UsrTxt.Text != string.Empty && PassTxt.Text != string.Empty)
            {
                var user = content.LMSAdmins.Where(x => x.UserName.Equals(UsrTxt.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(PassTxt.Text))
                    {
                        
                        Action action = new Action();
                        action.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");

                }
             
            }

        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            if (PassTxt.PasswordChar == '\0')
            {
                HidePass.BringToFront();
                PassTxt.PasswordChar = '*';
            }
        }
        private void HidePass_Click(object sender, EventArgs e)
        {
            if (PassTxt.PasswordChar == '*')
            {
                ShowPass.BringToFront();
                PassTxt.PasswordChar = '\0';
            }
        }
    }
}