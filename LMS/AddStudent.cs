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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = gradientPanel1;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.Parent = groupBox1;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.Parent = groupBox1;
            groupBox3.BackColor = Color.Transparent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Gender = null;
            if (rdoBtnMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "INSERT INTO [students] ([first_name],[last_name],[full_name],[gender],[dob],[addmission_no],[nic],[telephone_no],[address],[grade_id],[medium],[date_of_admission])VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtFullName.Text + "','" + Gender + "','" + dtpDob.Value + "','" + txtAdmissionNo.Text + "','" + txtNicNo.Text + "','" + txtTelephoneNo.Text + "','" + txtAddress.Text + "','" + txtGradeId.Text + "','" + txtMedium.Text + "','" + dtpDateofAdmission.Value + "' )";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
