using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LMS
{
    public partial class Grade : Form
    {
        string id = null;
        public Grade()
        {
            InitializeComponent();
        }

        private void btnDataInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "INSERT INTO [grades] ([grade_name],[grade_group],[grade_order]) VALUES ('Two', '2A', '2A02')";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Grade details inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "SELECT * FROM grades";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGrade.DataSource = dt;
                        sqlReader.Close();
                        SetColumnHeaders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add functionality for adding new grade data
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                string id = dgvGrade.SelectedRows[0].Cells["id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }

                string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                string sql = "DELETE FROM grades WHERE id = '" + id + "'";

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();
                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Grade details deleted successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open connection: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
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

            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "SELECT * FROM grades WHERE " + cmbSearch.SelectedItem.ToString() + " LIKE '%" + txtSearch.Text + "%'";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGrade.DataSource = dt;
                        sqlReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
        }

        private void dgvGrade_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvGrade.SelectedRows[0];
                this.id = selectedRows.Cells["id"].Value.ToString();
                txtGradeName.Text = selectedRows.Cells["grade_name"].Value.ToString();
                txtGradeGroup.Text = selectedRows.Cells["grade_group"].Value.ToString();
                txtGradeOrder.Text = selectedRows.Cells["grade_order"].Value.ToString();
            }
        }

        private void SetColumnHeaders()
        {
            dgvGrade.Columns["id"].HeaderText = "ID";
            dgvGrade.Columns["grade_name"].HeaderText = "Grade Name";
            dgvGrade.Columns["grade_group"].HeaderText = "Grade Group";
            dgvGrade.Columns["grade_order"].HeaderText = "Grade Order";

            foreach (DataGridViewColumn column in dgvGrade.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Add functionality for editing grade data
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql;

            if (btnUpdate.Text == "Save")
            {
                sql = "INSERT INTO [grades] ([grade_name],[grade_order],[grade_group],[created_at]) VALUES ('" +
                    txtGradeName.Text + "','" + txtGradeOrder.Text + "','" + txtGradeGroup.Text + "','" + DateTime.Now + "')";
            }
            else
            {
                sql = "UPDATE [grades] SET [grade_name]='" + txtGradeName.Text + "',[grade_order]='" + txtGradeOrder.Text +
                    "',[grade_group]='" + txtGradeGroup.Text + "',[updated_at]='" + DateTime.Now + "' WHERE [id]='" + this.id + "'";
            }

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Grade details updated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.id = null;
            txtGradeName.Text = "";
            txtGradeGroup.Text = "";
            txtGradeOrder.Text = "";
            btnUpdate.Text = "Save";
        }

        private void btnGradeSubjects_Click(object sender, EventArgs e)
        {
            GradeSubject gradeSubject = new GradeSubject();
            gradeSubject.Show();
            this.Hide();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "SELECT * FROM grades";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGrade.DataSource = dt;
                        sqlReader.Close();
                        SetColumnHeaders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection: " + ex.Message);
                }
            }
        }
    }
}
