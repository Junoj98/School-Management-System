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
            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grade_subjects";

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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvGradeSubject.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "DELETE FROM grade_subjects WHERE id ='" + id + "'";
            cnn = new SqlConnection(connetionString);
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
            cmbSubjectId.Text = null;
            btnUpdate.Text = "Save";

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
            string sql = "select * from grade_subjects where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

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
            if (btnUpdate.Text == "Save")
            {

                string connetionString = null;
                SqlConnection cnn = new SqlConnection(connetionString);
                connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                SqlCommand command;
                string sql = "INSERT INTO [grade_subjects] ([subject_id],[grade_id],[created_at])VALUES('" + cmbSubjectId.Text + "','" + cmbGradeId.Text + "','" + DateTime.Now + "' )";
                cnn = new SqlConnection(connetionString);
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

                string connetionString = null;
                SqlConnection cnn = new SqlConnection(connetionString);
                connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                SqlCommand command;
                string sql = "UPDATE [grade_subjects] SET [subject_id]='" + cmbSubjectId.Text + "',[grade_id]='" + cmbGradeId.Text + "',[updated_at] = '" + DateTime.Now + "' WHERE [id]='" + this.id + "'";
                cnn = new SqlConnection(connetionString);
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
                string subjectid = selectedRows.Cells["subject_id"].Value.ToString();
                string gradeid = selectedRows.Cells["grade_id"].Value.ToString();


                cmbSubjectId.Text = subjectid;
                cmbGradeId.Text = gradeid;
            }
        }
    }
}
