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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace LMS
{
    public partial class Teacher : Form
    {
        string id = null;
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            groupBox3.Parent = gradientPanel1;
            groupBox3.BackColor = Color.Transparent;
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;

            txtFullName.Enter += new EventHandler(txtFullName_Enter);

            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from teachers";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvTeacher.DataSource = dt;
                SetColumnHeaders();
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            refresh();
        }

        private void btnDataInsert_Click(object sender, EventArgs e)
        {
            //string connetionString = null;
            //SqlConnection cnn = new SqlConnection(connetionString);
            //connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            //SqlCommand command;
            //string sql = "INSERT INTO [teachers] ([first_name],[last_name],[full_name],[dob],[gender],[nic],[email],[address],[telephone],[medium],[date_of_join])VALUES('Rogers','Mbappe','Rogers Mbappe','12-05-1978','Male','780803007v','kymb@gmail.com','Paris',0771222276,'English','21-04-2019')";
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    command = new SqlCommand(sql, cnn);
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Teacher details added successfully ! ");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! ");
            //}
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from teachers";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader(); DataTable dt = new DataTable();

                dt.Load(sqlReader);

                dgvTeacher.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvTeacher.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "DELETE FROM teachers WHERE id ='" + id + "'";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Student details successfully deleted ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
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
            string sql = "select * from teachers where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

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
                dgvTeacher.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
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

        private void dgvTeacher_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTeacher.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvTeacher.SelectedRows[0];

                this.id = selectedRows.Cells["id"].Value.ToString();
                string fname = selectedRows.Cells["first_name"].Value.ToString();
                string lname = selectedRows.Cells["last_name"].Value.ToString();
                string fullname = selectedRows.Cells["full_name"].Value.ToString();
                string gender = selectedRows.Cells["gender"].Value.ToString();
                string dob = selectedRows.Cells["dob"].Value.ToString();
                string email = selectedRows.Cells["email"].Value.ToString();
                string nic = selectedRows.Cells["nic"].Value.ToString();
                string telephone = selectedRows.Cells["telephone"].Value.ToString();
                string medium = selectedRows.Cells["medium"].Value.ToString();
                string dateofjoin = selectedRows.Cells["date_of_join"].Value.ToString();
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
                txtEmail.Text = email;
                txtNicNo.Text = nic;
                txtTelephoneNo.Text = telephone;
                cmbMedium.Text = medium;
                dtpDateofJoin.Text = dateofjoin;
                txtAddress.Text = address;
            }
        }

        private void SetColumnHeaders()
        {
            dgvTeacher.Columns["id"].HeaderText = "ID";
            dgvTeacher.Columns["first_name"].HeaderText = "First Name";
            dgvTeacher.Columns["last_name"].HeaderText = "Last Name";
            dgvTeacher.Columns["full_name"].HeaderText = "Full Name";
            dgvTeacher.Columns["gender"].HeaderText = "Gender";
            dgvTeacher.Columns["dob"].HeaderText = "Date of Birth";
            dgvTeacher.Columns["nic"].HeaderText = "NIC";
            dgvTeacher.Columns["email"].HeaderText = "Email";
            dgvTeacher.Columns["address"].HeaderText = "Address";
            dgvTeacher.Columns["telephone"].HeaderText = "Telephone";
            dgvTeacher.Columns["medium"].HeaderText = "Medium";
            dgvTeacher.Columns["date_of_join"].HeaderText = "Date of Join";
            dgvTeacher.Columns["created_at"].HeaderText = "Created At";
            dgvTeacher.Columns["updated_at"].HeaderText = "Updated At";


            foreach (DataGridViewColumn column in dgvTeacher.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtFullName.Text == "" || dtpDob.Text == "" || txtNicNo.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtTelephoneNo.Text == "" || cmbMedium.Text == "" || dtpDateofJoin.Text == "" || (!rdoBtnMale.Checked && !rdoBtnFemale.Checked))
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                string sql = "INSERT INTO [teachers] ([first_name],[last_name],[full_name],[gender],[dob],[nic],[email],[address],[telephone],[medium],[date_of_join],[created_at])VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtFullName.Text + "','" + Gender + "','" + dtpDob.Value.ToString("yyyy-MM-dd") + "','" + txtNicNo.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtTelephoneNo.Text + "','" + cmbMedium.Text + "','" + dtpDateofJoin.Value.ToString("yyyy-MM-dd") + "','"+DateTime.Now+"')";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher Details Added Successfully ! ");
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
                string sql = "UPDATE [teachers] SET [first_name]='" + txtFirstName.Text + "',[last_name]='" + txtLastName.Text + "',[full_name]='" + txtFullName.Text + "',[gender] = '" + Gender + "',[dob]='" + dtpDob.Text + "',[nic]='" + txtNicNo.Text + "',[email]='" + txtEmail.Text + "',[address]='" + txtAddress.Text + "',[telephone]='" + txtTelephoneNo.Text + "',[medium]='" + cmbMedium.Text + "',[date_of_join]='" + dtpDateofJoin.Text + "',[updated_at] = '" + DateTime.Now + "' WHERE [id]='" + this.id + "'";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher Details Updated Successfully ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.id = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtFullName.Text = null;
            dtpDob.Text = null;
            txtEmail.Text = null;
            txtNicNo.Text = null;
            txtTelephoneNo.Text = null;
            cmbMedium.Text = null;
            dtpDateofJoin.Text = null;
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

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void refresh()
        {
            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from teachers";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvTeacher.DataSource = dt;
                SetColumnHeaders();
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtFullName.Text = null;
            dtpDob.Text = null;
            txtEmail.Text = null;
            txtNicNo.Text = null;
            txtTelephoneNo.Text = null;
            cmbMedium.SelectedIndex = -1;
            dtpDateofJoin.Text = null;
            txtAddress.Text = null;
            rdoBtnMale.Checked = false;
            rdoBtnFemale.Checked = false;
        }
    }
}
