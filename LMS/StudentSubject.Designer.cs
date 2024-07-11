namespace LMS
{
    partial class StudentSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSubject));
            gradientPanel1 = new GradientPanel();
            label1 = new Label();
            btnHome = new Button();
            btnClear = new Button();
            btnNew = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            btnDelete = new Button();
            dgvStudentSubject = new DataGridView();
            btnGetData = new Button();
            cmbAdmissionNo = new ComboBox();
            cmbSubjectId = new ComboBox();
            txtAdmisionNo = new Label();
            btnUpdate = new Button();
            lblFirstName = new Label();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentSubject).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(btnHome);
            gradientPanel1.Controls.Add(btnClear);
            gradientPanel1.Controls.Add(btnNew);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(txtSearch);
            gradientPanel1.Controls.Add(cmbSearch);
            gradientPanel1.Controls.Add(btnDelete);
            gradientPanel1.Controls.Add(dgvStudentSubject);
            gradientPanel1.Controls.Add(btnGetData);
            gradientPanel1.Controls.Add(cmbAdmissionNo);
            gradientPanel1.Controls.Add(cmbSubjectId);
            gradientPanel1.Controls.Add(txtAdmisionNo);
            gradientPanel1.Controls.Add(btnUpdate);
            gradientPanel1.Controls.Add(lblFirstName);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(970, 496);
            gradientPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 47);
            label1.TabIndex = 132;
            label1.Text = "Student Subject";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(25, 103);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 48);
            btnHome.TabIndex = 131;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(415, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 35);
            btnClear.TabIndex = 123;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(238, 103);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 48);
            btnNew.TabIndex = 130;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(380, 173);
            label9.Name = "label9";
            label9.Size = new Size(30, 27);
            label9.TabIndex = 129;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(199, 173);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 128;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "first_name", "last_name", "full_name", "gender", "nic", "email", "address", "telephone_no", "medium", "date_of_join" });
            cmbSearch.Location = new Point(13, 172);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(180, 28);
            cmbSearch.TabIndex = 127;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(167, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 48);
            btnDelete.TabIndex = 126;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudentSubject
            // 
            dgvStudentSubject.AllowUserToAddRows = false;
            dgvStudentSubject.AllowUserToDeleteRows = false;
            dgvStudentSubject.BackgroundColor = SystemColors.ControlLight;
            dgvStudentSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentSubject.Location = new Point(13, 212);
            dgvStudentSubject.Name = "dgvStudentSubject";
            dgvStudentSubject.RowHeadersWidth = 51;
            dgvStudentSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentSubject.Size = new Size(527, 241);
            dgvStudentSubject.TabIndex = 125;
            dgvStudentSubject.SelectionChanged += dgvStudentSubject_SelectionChanged;
            // 
            // btnGetData
            // 
            btnGetData.BackgroundImage = (Image)resources.GetObject("btnGetData.BackgroundImage");
            btnGetData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetData.Location = new Point(96, 103);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(61, 48);
            btnGetData.TabIndex = 124;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // cmbAdmissionNo
            // 
            cmbAdmissionNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdmissionNo.FormattingEnabled = true;
            cmbAdmissionNo.Location = new Point(724, 258);
            cmbAdmissionNo.Name = "cmbAdmissionNo";
            cmbAdmissionNo.Size = new Size(179, 28);
            cmbAdmissionNo.TabIndex = 121;
            // 
            // cmbSubjectId
            // 
            cmbSubjectId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubjectId.FormattingEnabled = true;
            cmbSubjectId.Location = new Point(724, 204);
            cmbSubjectId.Name = "cmbSubjectId";
            cmbSubjectId.Size = new Size(179, 28);
            cmbSubjectId.TabIndex = 122;
            // 
            // txtAdmisionNo
            // 
            txtAdmisionNo.AutoSize = true;
            txtAdmisionNo.BackColor = Color.Transparent;
            txtAdmisionNo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtAdmisionNo.ForeColor = SystemColors.ControlLightLight;
            txtAdmisionNo.Location = new Point(590, 259);
            txtAdmisionNo.Name = "txtAdmisionNo";
            txtAdmisionNo.Size = new Size(129, 23);
            txtAdmisionNo.TabIndex = 118;
            txtAdmisionNo.Text = "Admission No.";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(726, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 120;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFirstName.ForeColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(590, 205);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 119;
            lblFirstName.Text = "Subject Id";
            // 
            // StudentSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 496);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StudentSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentSubject";
            Load += StudentSubject_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Button btnHome;
        private Button btnClear;
        private Button btnNew;
        private Label label9;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private Button btnDelete;
        private DataGridView dgvStudentSubject;
        private Button btnGetData;
        private ComboBox cmbAdmissionNo;
        private ComboBox cmbSubjectId;
        private Label txtAdmisionNo;
        private Button btnUpdate;
        private Label lblFirstName;
        private Label label1;
    }
}