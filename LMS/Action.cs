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
            if (SearchRadio.Checked){
                Search search = new Search();
                search.Show();
                this.Hide();
            }
            if (ReturnRadio.Checked)
            {
                Return_Book return_Book = new Return_Book();
                return_Book.Show();
                this.Hide() ;
            }
            if(CatRadio.Checked)
            {
                Manage_Category manage_Category = new Manage_Category();
                manage_Category.Show();
                this.Hide();
            }
            if (AddRadios.Checked)
            {
                ManageBook manageBook = new ManageBook();
                manageBook.Show();
                this.Hide();
            }
            if (PassRadios.Checked)
            {
                ChangePassword changePassword = new ChangePassword();
                changePassword.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

     
    }
}
