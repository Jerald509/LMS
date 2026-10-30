using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        private void bntSubmit(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Return_Book return_Book = new Return_Book();
            return_Book.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manage_Category manage_Category = new Manage_Category();
            manage_Category.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook();
            manageBook.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Hide();
        }
    }
}
