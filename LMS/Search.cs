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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void BackBnt(object sender, EventArgs e)
        {
         Action action=new Action();
            action.Show();
            this.Hide();
        }
    }
}
