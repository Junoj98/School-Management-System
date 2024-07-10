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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtFullName_Click(object sender, EventArgs e)
        {
            txtFullName.Text = txtFirstName.Text +" "+ txtLastName.Text;
        }
    }
}
