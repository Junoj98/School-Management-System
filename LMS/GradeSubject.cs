using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LMS
{
    public partial class GradeSubject : Form
    {
        string id = null;
        public GradeSubject()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "select * from grade_subjects";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGradeSubject.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGradeSubject.SelectedRows.Count > 0)
            {
                string id = dgvGradeSubject.SelectedRows[0].Cells["id"].Value.ToString();
                DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }

                string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                string sql = "DELETE FROM grade_subjects WHERE id = @id";

                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully deleted");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
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
            cmbGradeId.Text = null;
            btnUpdate.Text = "Save";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the column");
                return;
            }

            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            string sql = "select * from grade_subjects where " + cmbSearch.SelectedItem.ToString() + " like @searchText";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGradeSubject.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
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
            string sql = btnUpdate.Text == "Save" ?
                "INSERT INTO grade_subjects (subject_id, grade_id) VALUES (@subjectId, @gradeId)" :
                "UPDATE grade_subjects SET subject_id = @subjectId, grade_id = @gradeId WHERE id = @id";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@subjectId", cmbSubjectId.SelectedValue);
                        command.Parameters.AddWithValue("@gradeId", cmbGradeId.SelectedValue);
                        if (btnUpdate.Text != "Save")
                        {
                            command.Parameters.AddWithValue("@id", this.id);
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully " + (btnUpdate.Text == "Save" ? "added" : "updated"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        private void dgvGradeSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGradeSubject.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRow = dgvGradeSubject.SelectedRows[0];

                this.id = selectedRow.Cells["id"].Value.ToString();
                object subjectId = selectedRow.Cells["subject_id"].Value;
                object gradeId = selectedRow.Cells["grade_id"].Value;

                cmbSubjectId.SelectedValue = subjectId;
                cmbGradeId.SelectedValue = gradeId;
            }
        }

        private void GradeSubject_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    // Load grade_subjects
                    string sqlGradeSubjects = "select * from grade_subjects";
                    using (SqlCommand command = new SqlCommand(sqlGradeSubjects, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        dgvGradeSubject.DataSource = dt;
                    }

                    // Load grades into cmbGradeId
                    string sqlGrades = "select * from grades";
                    using (SqlCommand command = new SqlCommand(sqlGrades, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        cmbGradeId.DataSource = dt;
                        cmbGradeId.DisplayMember = "id";
                        cmbGradeId.ValueMember = "id";
                    }

                    // Load subjects into cmbSubjectId
                    string sqlSubjects = "select * from subjects";
                    using (SqlCommand command = new SqlCommand(sqlSubjects, cnn))
                    {
                        SqlDataReader sqlReader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sqlReader);
                        cmbSubjectId.DataSource = dt;
                        cmbSubjectId.DisplayMember = "id";
                        cmbSubjectId.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }
    }
}
