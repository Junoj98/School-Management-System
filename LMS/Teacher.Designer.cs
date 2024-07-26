namespace LMS
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            gradientPanel1 = new GradientPanel();
            btnClear = new Button();
            btnNew = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            btnHome = new Button();
            btnUpdate = new Button();
            groupBox3 = new GroupBox();
            cmbMedium = new ComboBox();
            label5 = new Label();
            dtpDateofJoin = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtTelephoneNo = new TextBox();
            label7 = new Label();
            txtNicNo = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            dtpDob = new DateTimePicker();
            label4 = new Label();
            rdoBtnFemale = new RadioButton();
            rdoBtnMale = new RadioButton();
            label3 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnDelete = new Button();
            dgvTeacher = new DataGridView();
            btnGetData = new Button();
            btnTestConnection = new Button();
            label1 = new Label();
            gradientPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(btnClear);
            gradientPanel1.Controls.Add(btnNew);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(txtSearch);
            gradientPanel1.Controls.Add(cmbSearch);
            gradientPanel1.Controls.Add(btnHome);
            gradientPanel1.Controls.Add(btnUpdate);
            gradientPanel1.Controls.Add(groupBox3);
            gradientPanel1.Controls.Add(btnDelete);
            gradientPanel1.Controls.Add(dgvTeacher);
            gradientPanel1.Controls.Add(btnGetData);
            gradientPanel1.Controls.Add(btnTestConnection);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1343, 624);
            gradientPanel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(410, 133);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 35);
            btnClear.TabIndex = 67;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(208, 73);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 48);
            btnNew.TabIndex = 81;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(375, 138);
            label9.Name = "label9";
            label9.Size = new Size(30, 27);
            label9.TabIndex = 80;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(194, 138);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 78;
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
            cmbSearch.Location = new Point(8, 137);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(180, 28);
            cmbSearch.TabIndex = 77;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(275, 72);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 48);
            btnHome.TabIndex = 76;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(887, 561);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 73;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(cmbMedium);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dtpDateofJoin);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtTelephoneNo);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtNicNo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(dtpDob);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(rdoBtnFemale);
            groupBox3.Controls.Add(rdoBtnMale);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtFullName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtLastName);
            groupBox3.Controls.Add(lblLastName);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(lblFirstName);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(554, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(781, 415);
            groupBox3.TabIndex = 72;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // cmbMedium
            // 
            cmbMedium.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedium.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Items.AddRange(new object[] { "Tamil", "English", "Sinhala" });
            cmbMedium.Location = new Point(540, 239);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(224, 27);
            cmbMedium.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F);
            label5.Location = new Point(18, 176);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 45;
            label5.Text = "Email";
            // 
            // dtpDateofJoin
            // 
            dtpDateofJoin.Font = new Font("Times New Roman", 10.8F);
            dtpDateofJoin.Location = new Point(131, 288);
            dtpDateofJoin.Name = "dtpDateofJoin";
            dtpDateofJoin.Size = new Size(224, 28);
            dtpDateofJoin.TabIndex = 44;
            // 
            // label12
            // 
            label12.Font = new Font("Times New Roman", 10.8F);
            label12.Location = new Point(18, 294);
            label12.Name = "label12";
            label12.Size = new Size(118, 41);
            label12.TabIndex = 43;
            label12.Text = "Date of Join";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.8F);
            label13.Location = new Point(426, 246);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 41;
            label13.Text = "Medium";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 10.8F);
            txtAddress.Location = new Point(540, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 28);
            txtAddress.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F);
            label8.Location = new Point(416, 193);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 37;
            label8.Text = "Address";
            // 
            // txtTelephoneNo
            // 
            txtTelephoneNo.Font = new Font("Times New Roman", 10.8F);
            txtTelephoneNo.Location = new Point(131, 230);
            txtTelephoneNo.Name = "txtTelephoneNo";
            txtTelephoneNo.Size = new Size(224, 28);
            txtTelephoneNo.TabIndex = 36;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.Location = new Point(18, 221);
            label7.Name = "label7";
            label7.Size = new Size(100, 48);
            label7.TabIndex = 35;
            label7.Text = "Telephone Number";
            // 
            // txtNicNo
            // 
            txtNicNo.Font = new Font("Times New Roman", 10.8F);
            txtNicNo.Location = new Point(540, 137);
            txtNicNo.Name = "txtNicNo";
            txtNicNo.Size = new Size(224, 28);
            txtNicNo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.Location = new Point(416, 140);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 33;
            label6.Text = "NIC Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 10.8F);
            txtEmail.Location = new Point(131, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 28);
            txtEmail.TabIndex = 32;
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Times New Roman", 10.8F);
            dtpDob.Location = new Point(540, 84);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(224, 28);
            dtpDob.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(416, 87);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 29;
            label4.Text = "Date of Birth";
            // 
            // rdoBtnFemale
            // 
            rdoBtnFemale.AutoSize = true;
            rdoBtnFemale.Font = new Font("Times New Roman", 10.8F);
            rdoBtnFemale.Location = new Point(273, 128);
            rdoBtnFemale.Name = "rdoBtnFemale";
            rdoBtnFemale.Size = new Size(82, 24);
            rdoBtnFemale.TabIndex = 28;
            rdoBtnFemale.TabStop = true;
            rdoBtnFemale.Text = "Female";
            rdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMale
            // 
            rdoBtnMale.AutoSize = true;
            rdoBtnMale.Font = new Font("Times New Roman", 10.8F);
            rdoBtnMale.Location = new Point(131, 128);
            rdoBtnMale.Name = "rdoBtnMale";
            rdoBtnMale.Size = new Size(66, 24);
            rdoBtnMale.TabIndex = 8;
            rdoBtnMale.TabStop = true;
            rdoBtnMale.Text = "Male";
            rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(18, 131);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 10.8F);
            txtFullName.Location = new Point(131, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(224, 28);
            txtFullName.TabIndex = 6;
            txtFullName.Enter += txtFullName_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Full Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Times New Roman", 10.8F);
            txtLastName.Location = new Point(540, 31);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(224, 28);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 10.8F);
            lblLastName.Location = new Point(415, 34);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Times New Roman", 10.8F);
            txtFirstName.Location = new Point(131, 35);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 28);
            txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 10.8F);
            lblFirstName.Location = new Point(18, 41);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(141, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 48);
            btnDelete.TabIndex = 71;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTeacher
            // 
            dgvTeacher.AllowUserToAddRows = false;
            dgvTeacher.AllowUserToDeleteRows = false;
            dgvTeacher.BackgroundColor = SystemColors.ControlLight;
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(8, 171);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeacher.Size = new Size(527, 399);
            dgvTeacher.TabIndex = 70;
            dgvTeacher.SelectionChanged += dgvTeacher_SelectionChanged;
            // 
            // btnGetData
            // 
            btnGetData.BackgroundImage = (Image)resources.GetObject("btnGetData.BackgroundImage");
            btnGetData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetData.Location = new Point(74, 73);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(61, 48);
            btnGetData.TabIndex = 67;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackgroundImage = (Image)resources.GetObject("btnTestConnection.BackgroundImage");
            btnTestConnection.BackgroundImageLayout = ImageLayout.Zoom;
            btnTestConnection.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnection.Location = new Point(7, 72);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(61, 48);
            btnTestConnection.TabIndex = 69;
            btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(1343, 47);
            label1.TabIndex = 2;
            label1.Text = "Teachers Details Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 624);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            Load += Teacher_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label1;
        private Label label9;
        private Button btnEdit;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private Button btnHome;
        private Button btnGetTeacher;
        private Button btnCancel;
        private Button btnUpdate;
        private GroupBox groupBox3;
        private DateTimePicker dtpDateofJoin;
        private Label label12;
        private Label label13;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtTelephoneNo;
        private Label label7;
        private TextBox txtNicNo;
        private Label label6;
        private TextBox txtEmail;
        private DateTimePicker dtpDob;
        private Label label4;
        private RadioButton rdoBtnFemale;
        private RadioButton rdoBtnMale;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnDelete;
        private DataGridView dgvTeacher;
        private Button btnAdd;
        private Button btnGetData;
        private Button btnDataInsert;
        private Button btnTestConnection;
        private Label label5;
        private Button btnNew;
        private Button btnClear;
        private ComboBox cmbMedium;
    }
}