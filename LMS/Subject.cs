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
    public partial class Subject : Form
    {
        string id = null;
        public Subject()
        {
            InitializeComponent();
        }

        private void btnDataInsert_Click(object sender, EventArgs e)
        {
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "INSERT INTO [subjects] ([subject_name],[subject_index],[subject_order],[subject_number])VALUES('Mathematics','MA1223','MA1245','MA123')";
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
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                dgvSubject.DataSource = dt;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvSubject.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "DELETE FROM subjects WHERE id ='" + id + "'";
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Subject details successfully deleted ");
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
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from subjects where " + cmbSearch.SelectedItem.ToString() + " like '%" + txtSearch.Text + "%'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);
                dgvSubject.DataSource = dt;
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

        private void dgvSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                btnUpdate.Text = "Update";
                DataGridViewRow selectedRows = dgvSubject.SelectedRows[0];

                this.id = selectedRows.Cells["id"].Value.ToString();
                string subjectname = selectedRows.Cells["subject_name"].Value.ToString();
                string subjectindex = selectedRows.Cells["subject_index"].Value.ToString();
                string subjectorder = selectedRows.Cells["subject_order"].Value.ToString();
                string subjectnumber = selectedRows.Cells["subject_number"].Value.ToString();


                txtSubjectName.Text = subjectname;
                txtSubjectIndex.Text = subjectindex;
                txtSubjectOrder.Text = subjectorder;
                txtSubjectNumber.Text = subjectnumber;
            }
        }

        private void SetColumnHeaders()
        {
            dgvSubject.Columns["id"].HeaderText = "ID";
            dgvSubject.Columns["subject_name"].HeaderText = "Subject Name";
            dgvSubject.Columns["subject_index"].HeaderText = "Subject Index";
            dgvSubject.Columns["subject_order"].HeaderText = "Subject Order";
            dgvSubject.Columns["subject_number"].HeaderText = "Subject Number";
            dgvSubject.Columns["created_at"].HeaderText = "Created At";
            dgvSubject.Columns["updated_at"].HeaderText = "Updated At";


            foreach (DataGridViewColumn column in dgvSubject.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "" || txtSubjectIndex.Text == "" || txtSubjectNumber.Text == "" || txtSubjectOrder.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnUpdate.Text == "Save")
            {
                string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                SqlConnection cnn = new SqlConnection(connetionString);
                SqlCommand command;
                string sql = "INSERT INTO [subjects] ([subject_name],[subject_index],[subject_order],[subject_number],[created_at])VALUES('" + txtSubjectName.Text + "','" + txtSubjectIndex.Text + "','" + txtSubjectOrder.Text + "','" + txtSubjectNumber.Text + "','" + DateTime.Now + "' )";
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject detail successfully added ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
            else
            {
                string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
                SqlConnection cnn = new SqlConnection(connetionString);
                SqlCommand command;
                string sql = "UPDATE [subjects] SET [subject_name]='" + txtSubjectName.Text + "',[subject_index]='" + txtSubjectIndex.Text + "',[subject_order]='" + txtSubjectOrder.Text + "',[subject_number]='" + txtSubjectNumber.Text + "',[updated_at] = '" + DateTime.Now + "' WHERE [id]='" + this.id + "'";
                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject details successfully updated");
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
            txtSubjectName.Text = null;
            txtSubjectIndex.Text = null;
            txtSubjectOrder.Text = null;
            txtSubjectNumber.Text = null;
            btnUpdate.Text = "Save";
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            string connetionString = "Server=JUNO\\SQLEXPRESS;Database=lmsDb;Trusted_Connection=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "select * from subjects";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                dgvSubject.DataSource = dt;
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
    }
}
