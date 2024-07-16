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
    public partial class GradeSubject : Form
    {
        string id = null;
        public GradeSubject()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvGradeSubject.DataSource = dt;
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
            // Implementation for adding a new record can be added here
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvGradeSubject.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "DELETE FROM grade_subjects WHERE id ='" + id + "'";
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show(" Successfully deleted ");
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
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_subjects where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvGradeSubject.DataSource = dt;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;

            if (btnUpdate.Text == "Save")
            {
                string sql = "INSERT INTO [grade_subjects] ([subject_id],[grade_id])VALUES('" + cmbSubjectId.SelectedValue + "','" + cmbGradeId.SelectedValue + "' )";
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully added ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
            else
            {
                string sql = "UPDATE [grade_subjects] SET [subject_id]='" + cmbSubjectId.SelectedValue + "',[grade_id]='" + cmbGradeId.SelectedValue + "' WHERE [id]='" + this.id + "'";
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
        }

        private void dgvGradeSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGradeSubject.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvGradeSubject.SelectedRows[0];

                this.id = selectedRows.Cells["id"].Value.ToString();
                object subjectid = selectedRows.Cells["subject_id"].Value;
                object gradeid = selectedRows.Cells["grade_id"].Value;

                cmbSubjectId.SelectedValue = subjectid;
                cmbGradeId.SelectedValue = gradeid;
            }
        }

        private void GradeSubject_Load(object sender, EventArgs e)
        {
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvGradeSubject.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            string sql1 = "select * from grades";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql1, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                cmbGradeId.DataSource = dt;
                cmbGradeId.DisplayMember = "id";
                cmbGradeId.ValueMember = "id";
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            string sql2 = "select * from subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql2, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                cmbSubjectId.DataSource = dt;
                cmbSubjectId.DisplayMember = "id";
                cmbSubjectId.ValueMember = "id";
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
