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
    public partial class Grade : Form
    {
        string id = null;
        public Grade()
        {
            InitializeComponent();
        }

        private void btnDataInsert_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "INSERT INTO [grades] ([grade_name],[grade_group],[grade_order])VALUES('Two','2A','2A02')";
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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from grades";

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

                dgvGrade.DataSource = dt;
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
            string id = dgvGrade.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = null;
            SqlConnection cnn = new SqlConnection(connetionString);
            connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlCommand command;
            string sql = "DELETE FROM grades WHERE id ='" + id + "'";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Grade details deleted successfully ");
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
            string sql = "select * from grades where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

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
                dgvGrade.DataSource = dt;
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

        private void dgvGrade_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvGrade.SelectedRows[0];

                this.id = selectedRows.Cells["id"].Value.ToString();
                string gradename = selectedRows.Cells["grade_name"].Value.ToString();
                string gradegroup = selectedRows.Cells["grade_group"].Value.ToString();
                string gradeorder = selectedRows.Cells["grade_order"].Value.ToString();


                txtGradeName.Text = gradename;
                txtGradeGroup.Text = gradegroup;
                txtGradeOrder.Text = gradeorder;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Save")
            {

                string connetionString = null;
                SqlConnection cnn = new SqlConnection(connetionString);
                connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                SqlCommand command;
                string sql = "INSERT INTO [grades] ([grade_name],[grade_order],[grade_group],[created_at])VALUES('" + txtGradeName.Text + "','" + txtGradeOrder.Text + "','" + txtGradeGroup.Text + "','" + DateTime.Now + "' )";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Grade detailsadded successfully ");
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
                string sql = "UPDATE [grades] SET [grade_name]='" + txtGradeName.Text + "',[grade_order]='" + txtGradeOrder.Text + "',[grade_group]='" + txtGradeGroup.Text + "',[updated_at] = '" + DateTime.Now + "'  WHERE [id]='" + this.id + "'";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Grade details updated successfully ");
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
            txtGradeName.Text = null;
            txtGradeGroup.Text = null;
            txtGradeOrder.Text = null;
            btnUpdate.Text = "Save";
        }

        private void btnGradeSubjects_Click(object sender, EventArgs e)
        {
            GradeSubject gradeSubject = new GradeSubject();
            gradeSubject.ShowDialog();
            this.Hide();
        }
    }
}
