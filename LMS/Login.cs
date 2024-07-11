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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //private void lblRegister_Click(object sender, EventArgs e)
        //{
        //    Register register = new Register();
        //    register.Show();
        //    this.Hide();
        //}

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    string checkUserNameSql = "SELECT COUNT(1) FROM [registers] WHERE user_name = @UserName AND password = @Password";
                    using (SqlCommand checkCommand = new SqlCommand(checkUserNameSql, cnn))
                    {
                        checkCommand.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        checkCommand.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 1)
                        {
                            //MessageBox.Show("Login successful", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void lblRegister_Click_1(object sender, EventArgs e)
        //{
        //    Register register = new Register();
        //    register.Show();
        //    this.Hide();
        //}

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
