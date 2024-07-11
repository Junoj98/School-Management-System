namespace LMS
{
    partial class GradeSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeSubject));
            gradientPanel1 = new GradientPanel();
            btnHome = new Button();
            btnClear = new Button();
            btnNew = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            btnDelete = new Button();
            dgvGradeSubject = new DataGridView();
            btnGetData = new Button();
            cmbGradeId = new ComboBox();
            cmbSubjectId = new ComboBox();
            label1 = new Label();
            btnUpdate = new Button();
            lblFirstName = new Label();
            label2 = new Label();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeSubject).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(btnHome);
            gradientPanel1.Controls.Add(btnClear);
            gradientPanel1.Controls.Add(btnNew);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(txtSearch);
            gradientPanel1.Controls.Add(cmbSearch);
            gradientPanel1.Controls.Add(btnDelete);
            gradientPanel1.Controls.Add(dgvGradeSubject);
            gradientPanel1.Controls.Add(btnGetData);
            gradientPanel1.Controls.Add(cmbGradeId);
            gradientPanel1.Controls.Add(cmbSubjectId);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(btnUpdate);
            gradientPanel1.Controls.Add(lblFirstName);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(970, 496);
            gradientPanel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(24, 85);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 48);
            btnHome.TabIndex = 117;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(414, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 35);
            btnClear.TabIndex = 105;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(237, 85);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 48);
            btnNew.TabIndex = 116;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(379, 155);
            label9.Name = "label9";
            label9.Size = new Size(30, 27);
            label9.TabIndex = 115;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(198, 155);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 113;
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
            cmbSearch.Location = new Point(12, 154);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(180, 28);
            cmbSearch.TabIndex = 112;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(166, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 48);
            btnDelete.TabIndex = 110;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvGradeSubject
            // 
            dgvGradeSubject.AllowUserToAddRows = false;
            dgvGradeSubject.AllowUserToDeleteRows = false;
            dgvGradeSubject.BackgroundColor = SystemColors.ControlLight;
            dgvGradeSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradeSubject.Location = new Point(12, 194);
            dgvGradeSubject.Name = "dgvGradeSubject";
            dgvGradeSubject.RowHeadersWidth = 51;
            dgvGradeSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradeSubject.Size = new Size(527, 241);
            dgvGradeSubject.TabIndex = 109;
            dgvGradeSubject.SelectionChanged += dgvGradeSubject_SelectionChanged;
            // 
            // btnGetData
            // 
            btnGetData.BackgroundImage = (Image)resources.GetObject("btnGetData.BackgroundImage");
            btnGetData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetData.Location = new Point(95, 85);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(61, 48);
            btnGetData.TabIndex = 106;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // cmbGradeId
            // 
            cmbGradeId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeId.FormattingEnabled = true;
            cmbGradeId.Location = new Point(730, 270);
            cmbGradeId.Name = "cmbGradeId";
            cmbGradeId.Size = new Size(179, 28);
            cmbGradeId.TabIndex = 103;
            // 
            // cmbSubjectId
            // 
            cmbSubjectId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubjectId.FormattingEnabled = true;
            cmbSubjectId.Location = new Point(730, 216);
            cmbSubjectId.Name = "cmbSubjectId";
            cmbSubjectId.Size = new Size(179, 28);
            cmbSubjectId.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(616, 271);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 9;
            label1.Text = "Grade Id";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(732, 318);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 102;
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
            lblFirstName.Location = new Point(616, 217);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "Subject Id";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(24, 9);
            label2.Name = "label2";
            label2.Size = new Size(187, 47);
            label2.TabIndex = 133;
            label2.Text = "Grade Subject";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GradeSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 496);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GradeSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GradeSubject";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label lblFirstName;
        private ComboBox cmbGradeId;
        private ComboBox cmbSubjectId;
        private Label label1;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnNew;
        private Label label9;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private Button btnDelete;
        private DataGridView dgvGradeSubject;
        private Button btnGetData;
        private Button btnHome;
        private Label label2;
    }
}