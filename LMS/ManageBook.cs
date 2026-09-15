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
    public partial class ManageBook : Form
    {
        public ManageBook()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, EventArgs e)
        {
            Action action = new Action();
            action.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LMSEntities1 context = new LMSEntities1();

            Book book = new Book();
            book.ISBN = isbnTxt.Text;
            book.Title = titleTxt.Text;
            book.Category = catecombo.SelectedText;
            book.Quantity = Convert.ToInt32(QtyTxt.Text);
            context.Books.Add(book);
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LMSEntities1 context = new LMSEntities1();
            var book = context.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            var bookqty = book.Quantity - Convert.ToInt32(rqtytxt.Text);

            context.Books.Remove(book);
            context.SaveChanges();
            MessageBox.Show($"Book {rqtytxt.Text}Removed Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
  LMSEntities1 contex = new LMSEntities1();
            var book = contex.Books.Where(x => x.ISBN == risbntxt.Text).FirstOrDefault();
            rtitletxt.Text = book.Title;
            rcattxt.Text = book.Category;
            aqtytxt.Text = Convert.ToString(book.Quantity);
            rtitletxt.ReadOnly = true;
            rcattxt.ReadOnly = true;
            aqtytxt.ReadOnly = true;
        }
    }
}
