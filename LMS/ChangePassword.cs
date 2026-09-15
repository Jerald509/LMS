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

namespace LMS
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action action = new Action();
            action.Show();
            this.Hide();
        }

        private void ConfromPass_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LMS;Integrated Security=True";

            string oldPassword = oldPass.Text;
            string newPassword = NewPass.Text;
            string confirmPassword = confPass.Text;
            
            {
               
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"UPDATE LMSAdmin SET
Password=@NewPassword WHERE
UserName='admin'AND Password=@OldPassword";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect.");
                        }
                    }
                }
            }
        }
    }
}
