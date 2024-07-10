namespace LMS
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            gradientPanel1 = new GradientPanel();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            dtpDateofAdmission = new DateTimePicker();
            rdoBtnFemale = new RadioButton();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            txtMedium = new TextBox();
            label9 = new Label();
            txtGradeId = new TextBox();
            label10 = new Label();
            rdoBtnMale = new RadioButton();
            txtAddress = new TextBox();
            label7 = new Label();
            txtTelephoneNo = new TextBox();
            label6 = new Label();
            txtNicNo = new TextBox();
            label5 = new Label();
            txtAdmissionNo = new TextBox();
            label4 = new Label();
            dtpDob = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            gradientPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(groupBox1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(945, 573);
            gradientPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(dtpDateofAdmission);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMedium);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtGradeId);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rdoBtnMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTelephoneNo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNicNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAdmissionNo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDob);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 554);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details of the Student";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(464, 488);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 39);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(333, 488);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 39);
            btnSubmit.TabIndex = 31;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtpDateofAdmission
            // 
            dtpDateofAdmission.Font = new Font("Times New Roman", 10.8F);
            dtpDateofAdmission.Location = new Point(658, 432);
            dtpDateofAdmission.Name = "dtpDateofAdmission";
            dtpDateofAdmission.Size = new Size(189, 28);
            dtpDateofAdmission.TabIndex = 28;
            // 
            // rdoBtnFemale
            // 
            rdoBtnFemale.AutoSize = true;
            rdoBtnFemale.Font = new Font("Times New Roman", 10.8F);
            rdoBtnFemale.Location = new Point(297, 168);
            rdoBtnFemale.Name = "rdoBtnFemale";
            rdoBtnFemale.Size = new Size(82, 24);
            rdoBtnFemale.TabIndex = 27;
            rdoBtnFemale.TabStop = true;
            rdoBtnFemale.Text = "Female";
            rdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(476, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 282);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F);
            label8.Location = new Point(481, 438);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 24;
            label8.Text = "Date of Admission";
            // 
            // txtMedium
            // 
            txtMedium.Font = new Font("Times New Roman", 10.8F);
            txtMedium.Location = new Point(658, 391);
            txtMedium.Name = "txtMedium";
            txtMedium.Size = new Size(189, 28);
            txtMedium.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F);
            label9.Location = new Point(481, 394);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 22;
            label9.Text = "Medium";
            // 
            // txtGradeId
            // 
            txtGradeId.Font = new Font("Times New Roman", 10.8F);
            txtGradeId.Location = new Point(658, 347);
            txtGradeId.Name = "txtGradeId";
            txtGradeId.Size = new Size(189, 28);
            txtGradeId.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F);
            label10.Location = new Point(481, 350);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 19;
            label10.Text = "Grade ID";
            // 
            // rdoBtnMale
            // 
            rdoBtnMale.AutoSize = true;
            rdoBtnMale.Font = new Font("Times New Roman", 10.8F);
            rdoBtnMale.Location = new Point(211, 211);
            rdoBtnMale.Name = "rdoBtnMale";
            rdoBtnMale.Size = new Size(66, 24);
            rdoBtnMale.TabIndex = 6;
            rdoBtnMale.TabStop = true;
            rdoBtnMale.Text = "Male";
            rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 10.8F);
            txtAddress.Location = new Point(211, 428);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 28);
            txtAddress.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.Location = new Point(38, 431);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 17;
            label7.Text = "Address";
            // 
            // txtTelephoneNo
            // 
            txtTelephoneNo.Font = new Font("Times New Roman", 10.8F);
            txtTelephoneNo.Location = new Point(211, 384);
            txtTelephoneNo.Name = "txtTelephoneNo";
            txtTelephoneNo.Size = new Size(224, 28);
            txtTelephoneNo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.Location = new Point(34, 387);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 15;
            label6.Text = "Telephone Number";
            // 
            // txtNicNo
            // 
            txtNicNo.Font = new Font("Times New Roman", 10.8F);
            txtNicNo.Location = new Point(211, 340);
            txtNicNo.Name = "txtNicNo";
            txtNicNo.Size = new Size(224, 28);
            txtNicNo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F);
            label5.Location = new Point(34, 343);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "NIC Number";
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Font = new Font("Times New Roman", 10.8F);
            txtAdmissionNo.Location = new Point(211, 299);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(224, 28);
            txtAdmissionNo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(34, 299);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 11;
            label4.Text = "Admission Number";
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Times New Roman", 10.8F);
            dtpDob.Location = new Point(211, 249);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(224, 28);
            dtpDob.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(34, 255);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 9;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(34, 211);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Gender";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 10.8F);
            txtFullName.Location = new Point(211, 164);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(224, 28);
            txtFullName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(34, 167);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Full Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Times New Roman", 10.8F);
            txtLastName.Location = new Point(211, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(224, 28);
            txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 10.8F);
            lblLastName.Location = new Point(34, 123);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Times New Roman", 10.8F);
            txtFirstName.Location = new Point(211, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 28);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 10.8F);
            lblFirstName.Location = new Point(34, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(476, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 157);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoBtnFemale);
            groupBox3.Location = new Point(21, 42);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 608);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Details";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 573);
            Controls.Add(gradientPanel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            Load += AddStudent_Load;
            gradientPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        public GroupBox groupBox1;
        private Label lblFirstName;
        private Label label2;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtNicNo;
        private Label label5;
        private TextBox txtAdmissionNo;
        private Label label4;
        private DateTimePicker dtpDob;
        private Label label3;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtTelephoneNo;
        private RadioButton rdoBtnMale;
        private Label label8;
        private TextBox txtMedium;
        private Label label9;
        private TextBox txtGradeId;
        private Label label10;
        private PictureBox pictureBox1;
        private RadioButton rdoBtnFemale;
        private DateTimePicker dtpDateofAdmission;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnCancel;
        private Button btnSubmit;
    }
}