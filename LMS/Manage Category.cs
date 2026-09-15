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
    public partial class Manage_Category : Form
    {
        public Manage_Category()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, EventArgs e)
        {
            Action action = new Action();
            action.Show();
            this.Hide();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            /*LMSEntities context=new LMSEntities();
         Category category = new Category();
        { Title=catTxt.Text};
         context.Categories.Add(category);
         MessageBox.Show("Category Added Successfully");
            */
        }
    }
}
