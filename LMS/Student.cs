using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LMS
{
    public partial class Student : Form
    {
        string id = null;

        public Student()
        {
            InitializeComponent();
        }


        private void Student_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
            groupBox3.Parent = gradientPanel1;
            groupBox3.BackColor = Color.Transparent;



            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                // while (sqlReader.Read())
                //{
                //  MessageBox.Show(sqlReader.GetValue(0)+"-"+ sqlReader.GetValue(1) + "-" + sqlReader.GetValue(2) + "-" + sqlReader.GetValue(3) + "-" + sqlReader.GetValue(4) + "-" + sqlReader.GetValue(5));
                // }
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                dgvStudent.DataSource = dt;
                sqlReader.Close();
                SetColumnHeaders();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            // ithu kku keela irukkira coding kku reason, gradeid  a kondu vara
            string sql1 = "select * from grades";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql1, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                cmbGradeId.DataSource = dt;
                cmbGradeId.SelectedIndex = 0;
                cmbGradeId.DisplayMember = "id";
                cmbGradeId.ValueMember = "id";
                sqlReader.Close();
                SetColumnHeaders();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        //private void btnDataInsert_Click(object sender, EventArgs e)
        //{
        //    string connetionString = null;
        //    SqlConnection cnn = new SqlConnection(connetionString);
        //    connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
        //    SqlCommand command;
        //    string sql = "INSERT INTO [students] ([first_name],[last_name],[full_name],[gender],[date_of_birth],[admission_no],[stu_nic_no],[telephone_no],[grade_id],[medium],[date_of_admission],[address])VALUES('Antonio','Griezmann','Antonio Griezmann','Male','12-05-2000','18APC3443','200803007v',0771222276,'0714','English','2021-01-15','Paris')";
        //    cnn = new SqlConnection(connetionString);
        //    try
        //    {
        //        cnn.Open();
        //        command = new SqlCommand(sql, cnn);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Connection Open ! ");
        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not open connection ! ");
        //    }
        //}

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                // while (sqlReader.Read())
                //{
                //  MessageBox.Show(sqlReader.GetValue(0)+"-"+ sqlReader.GetValue(1) + "-" + sqlReader.GetValue(2) + "-" + sqlReader.GetValue(3) + "-" + sqlReader.GetValue(4) + "-" + sqlReader.GetValue(5));
                // }
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                dgvStudent.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvStudent.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "DELETE FROM students WHERE id ='" + id + "'";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Student details deleted successfully ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the column");
                return;
            }
            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from students where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                // while (sqlReader.Read())
                //{
                //  MessageBox.Show(sqlReader.GetValue(0)+"-"+ sqlReader.GetValue(1) + "-" + sqlReader.GetValue(2) + "-" + sqlReader.GetValue(3) + "-" + sqlReader.GetValue(4) + "-" + sqlReader.GetValue(5));
                // }
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvStudent.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvStudent.SelectedRows[0];

                this.id = selectedRows.Cells["id"].Value.ToString();
                string fname = selectedRows.Cells["first_name"].Value.ToString();
                string lname = selectedRows.Cells["last_name"].Value.ToString();
                string fullname = selectedRows.Cells["full_name"].Value.ToString();
                string gender = selectedRows.Cells["gender"].Value.ToString();
                string dob = selectedRows.Cells["date_of_birth"].Value.ToString();
                string admissionno = selectedRows.Cells["admission_no"].Value.ToString();
                string nic = selectedRows.Cells["stu_nic_no"].Value.ToString();
                string telephone = selectedRows.Cells["telephone_no"].Value.ToString();
                object gradeid = selectedRows.Cells["grade_id"].Value;
                string medium = selectedRows.Cells["medium"].Value.ToString();
                string dateofadmission = selectedRows.Cells["date_of_admission"].Value.ToString();
                string address = selectedRows.Cells["address"].Value.ToString();

                if (!string.IsNullOrEmpty(gender))
                {
                    if (gender == "Male")
                    {
                        rdoBtnMale.Checked = true;
                    }
                    else
                    {
                        rdoBtnFemale.Checked = true;
                    }
                }
                txtFirstName.Text = fname;
                txtLastName.Text = lname;
                txtFullName.Text = fullname;
                dtpDob.Text = dob;
                txtAdmissionNo.Text = admissionno;
                txtNicNo.Text = nic;
                txtTelephoneNo.Text = telephone;
                cmbGradeId.SelectedValue = gradeid;
                txtMedium.Text = medium;
                dtpDateofAdmission.Text = dateofadmission;
                txtAddress.Text = address;

            }
        }

        private void SetColumnHeaders()
        {
            dgvStudent.Columns["id"].HeaderText = "ID";
            dgvStudent.Columns["first_name"].HeaderText = "First Name";
            dgvStudent.Columns["last_name"].HeaderText = "Last Name";
            dgvStudent.Columns["full_name"].HeaderText = "Full Name";
            dgvStudent.Columns["gender"].HeaderText = "Gender";
            dgvStudent.Columns["date_of_birth"].HeaderText = "Date of Birth";
            dgvStudent.Columns["admission_no"].HeaderText = "Admission No";
            dgvStudent.Columns["stu_nic_no"].HeaderText = "Student NIC No";
            dgvStudent.Columns["address"].HeaderText = "Address";
            dgvStudent.Columns["telephone_no"].HeaderText = "Telephone No";
            dgvStudent.Columns["medium"].HeaderText = "Medium";
            dgvStudent.Columns["grade_id"].HeaderText = "Grade ID";
            dgvStudent.Columns["date_of_admission"].HeaderText = "Date of Admission";
            dgvStudent.Columns["created_at"].HeaderText = "Created At";
            dgvStudent.Columns["updated_at"].HeaderText = "Updated At";


            foreach (DataGridViewColumn column in dgvStudent.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (btnUpdate.Text == "Save")
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
                string sql = "INSERT INTO [students] ([first_name],[last_name],[full_name],[gender],[date_of_birth],[admission_no],[stu_nic_no],[telephone_no],[address],[grade_id],[medium],[date_of_admission],[created_at])VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtFullName.Text + "','" + Gender + "','" + dtpDob.Text + "','" + txtAdmissionNo.Text + "','" + txtNicNo.Text + "','" + txtTelephoneNo.Text + "','" + txtAddress.Text + "','" + cmbGradeId.SelectedValue + "','" + txtMedium.Text + "','" + dtpDateofAdmission.Text + "','" + DateTime.Now + "' )";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student details added successfully ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
            else
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
                string sql = "UPDATE [students] SET [first_name]='" + txtFirstName.Text + "',[last_name]='" + txtLastName.Text + "',[full_name]='" + txtFullName.Text + "',[gender] = '" + Gender + "',[date_of_birth]='" + dtpDob.Text + "',[admission_no]='" + txtAdmissionNo.Text + "',[stu_nic_no]='" + txtNicNo.Text + "',[telephone_no]='" + txtTelephoneNo.Text + "',[grade_id]='" + cmbGradeId.SelectedValue + "',[medium]='" + txtMedium.Text + "',[date_of_admission]='" + dtpDateofAdmission.Text + "',[address]='" + txtAddress.Text + "',[updated_at] = '" + DateTime.Now + "' WHERE [id]='" + this.id + "'";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student details updated successfully ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }


            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.id = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtFullName.Text = null;
            dtpDob.Text = null;
            txtAdmissionNo.Text = null;
            txtNicNo.Text = null;
            txtTelephoneNo.Text = null;
            cmbGradeId.Text = null;
            txtMedium.Text = null;
            dtpDateofAdmission.Text = null;
            txtAddress.Text = null;
            rdoBtnMale.Checked = false;
            rdoBtnFemale.Checked = false;
            btnUpdate.Text = "Save";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
        }

        private void btnStudentSubjects_Click(object sender, EventArgs e)
        {
            StudentSubject studentSubject = new StudentSubject();
            studentSubject.Show();
            this.Hide();
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }
    }
}
