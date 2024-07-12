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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";


                using (SqlConnection cnn = new SqlConnection(connectionString))
                {


                    try
                    {
                        cnn.Open();

                        string checkUserNameSql = "SELECT COUNT(*) FROM [registers] WHERE [email] = @Email";
                        using (SqlCommand checkCommand = new SqlCommand(checkUserNameSql, cnn))
                        {
                            checkCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            int emailCount = (int)checkCommand.ExecuteScalar();

                            if (emailCount > 0)
                            {
                                MessageBox.Show("Email already exists!");
                                return;
                            }
                        }


                        string insertSql = "INSERT INTO [registers] ([email],[user_name],[password],[created_at]) VALUES (@Email, @UserName, @Password, @CreatedAt)";
                        using (SqlCommand insertCommand = new SqlCommand(insertSql, cnn))
                        {
                            insertCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                            insertCommand.Parameters.AddWithValue("@UserName", txtUserName.Text);
                            insertCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                            insertCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Registration successfully completed!");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                
            }
        }

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
    }

}
