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
    public partial class StudentSubject : Form
    {
        string id = null;
        public StudentSubject()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "select * from student_subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvStudentSubject.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            string id = dgvStudentSubject.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "DELETE FROM student_subjects WHERE id ='" + id + "'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.id = null;
            cmbSubjectId.Text = null;
            cmbAdmissionNo.Text = null;
            btnUpdate.Text = "Save";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the column.");
                return;
            }

            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            string sql = "select * from grade_subjects where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvStudentSubject.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: " + ex.Message);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";

            if (btnUpdate.Text == "Save")
            {
                if (cmbSubjectId.SelectedValue == null || cmbAdmissionNo.SelectedValue == null)
                {
                    MessageBox.Show("Please select valid subject and student.");
                    return;
                }

                string sql = "INSERT INTO student_subjects (subject_id, stu_admission_no) VALUES ('" + cmbSubjectId.SelectedValue + "', '" + cmbAdmissionNo.SelectedValue + "')";

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();
                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully added.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                if (cmbSubjectId.SelectedValue == null || cmbAdmissionNo.SelectedValue == null || string.IsNullOrEmpty(this.id))
                {
                    MessageBox.Show("Please select a valid subject, student, and record.");
                    return;
                }

                string sql = "UPDATE student_subjects SET subject_id = '" + cmbSubjectId.SelectedValue + "', stu_admission_no = '" + cmbAdmissionNo.SelectedValue + "' WHERE id = '" + this.id + "'";

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();
                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully updated.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvStudentSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentSubject.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRow = dgvStudentSubject.SelectedRows[0];

                this.id = selectedRow.Cells["id"].Value.ToString();
                object subjectId = selectedRow.Cells["subject_id"].Value;
                object admissionNo = selectedRow.Cells["stu_admission_no"].Value;

                cmbSubjectId.SelectedValue = subjectId;
                cmbAdmissionNo.SelectedValue = admissionNo;
            }
        }

        private void StudentSubject_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";

            // Load data into dgvStudentSubject from student_subjects
            string sql = "select * from student_subjects";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader sqlReader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(sqlReader);
                            dgvStudentSubject.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }

            // Load data into cmbSubjectId from subjects
            string sql1 = "select * from subjects";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql1, cnn))
                    {
                        using (SqlDataReader sqlReader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(sqlReader);
                            cmbSubjectId.DataSource = dt;
                            cmbSubjectId.DisplayMember = "id";
                            cmbSubjectId.ValueMember = "id";
                            if (dt.Rows.Count > 0)
                            {
                                cmbSubjectId.SelectedIndex = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }

            // Load data into cmbAdmissionNo from students
            string sql2 = "select * from students";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql2, cnn))
                    {
                        using (SqlDataReader sqlReader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(sqlReader);
                            cmbAdmissionNo.DataSource = dt;
                            cmbAdmissionNo.DisplayMember = "admission_no";
                            cmbAdmissionNo.ValueMember = "id";
                            if (dt.Rows.Count > 0)
                            {
                                cmbAdmissionNo.SelectedIndex = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }
        }

        private void btnNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                btnNew.PerformClick();
            }
        }
    }
}
