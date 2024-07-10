namespace LMS
{
    partial class Grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade));
            gradientPanel1 = new GradientPanel();
            btnCancel = new Button();
            btnUpdate = new Button();
            groupBox3 = new GroupBox();
            txtGradeOrder = new TextBox();
            label3 = new Label();
            txtGradeGroup = new TextBox();
            label2 = new Label();
            txtGradeName = new TextBox();
            lblFirstName = new Label();
            btnHome = new Button();
            dgvGrade = new DataGridView();
            btnClear = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            btnNew = new Button();
            btnEdit = new Button();
            btnGetStudent = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnGetData = new Button();
            btnDataInsert = new Button();
            button1 = new Button();
            btnTestConnection = new Button();
            label1 = new Label();
            gradientPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrade).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(btnCancel);
            gradientPanel1.Controls.Add(btnUpdate);
            gradientPanel1.Controls.Add(groupBox3);
            gradientPanel1.Controls.Add(btnHome);
            gradientPanel1.Controls.Add(dgvGrade);
            gradientPanel1.Controls.Add(btnClear);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(txtSearch);
            gradientPanel1.Controls.Add(cmbSearch);
            gradientPanel1.Controls.Add(btnNew);
            gradientPanel1.Controls.Add(btnEdit);
            gradientPanel1.Controls.Add(btnGetStudent);
            gradientPanel1.Controls.Add(btnDelete);
            gradientPanel1.Controls.Add(btnAdd);
            gradientPanel1.Controls.Add(btnGetData);
            gradientPanel1.Controls.Add(btnDataInsert);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(btnTestConnection);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1343, 624);
            gradientPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnCancel.Location = new Point(905, 562);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 39);
            btnCancel.TabIndex = 84;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(790, 562);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 83;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtGradeOrder);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtGradeGroup);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtGradeName);
            groupBox3.Controls.Add(lblFirstName);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(655, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 226);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            groupBox3.Text = "Grade Details";
            // 
            // txtGradeOrder
            // 
            txtGradeOrder.Font = new Font("Times New Roman", 10.8F);
            txtGradeOrder.Location = new Point(140, 164);
            txtGradeOrder.Name = "txtGradeOrder";
            txtGradeOrder.Size = new Size(224, 28);
            txtGradeOrder.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(27, 164);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 7;
            label3.Text = "Grade Order";
            // 
            // txtGradeGroup
            // 
            txtGradeGroup.Font = new Font("Times New Roman", 10.8F);
            txtGradeGroup.Location = new Point(140, 108);
            txtGradeGroup.Name = "txtGradeGroup";
            txtGradeGroup.Size = new Size(224, 28);
            txtGradeGroup.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(27, 111);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Grade Group";
            // 
            // txtGradeName
            // 
            txtGradeName.Font = new Font("Times New Roman", 10.8F);
            txtGradeName.Location = new Point(140, 52);
            txtGradeName.Name = "txtGradeName";
            txtGradeName.Size = new Size(224, 28);
            txtGradeName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 10.8F);
            lblFirstName.Location = new Point(27, 58);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Grade Name";
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(1093, 70);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 48);
            btnHome.TabIndex = 81;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // dgvGrade
            // 
            dgvGrade.AllowUserToAddRows = false;
            dgvGrade.AllowUserToDeleteRows = false;
            dgvGrade.BackgroundColor = SystemColors.ControlLight;
            dgvGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrade.Location = new Point(19, 189);
            dgvGrade.Name = "dgvGrade";
            dgvGrade.RowHeadersWidth = 51;
            dgvGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrade.Size = new Size(600, 399);
            dgvGrade.TabIndex = 80;
            dgvGrade.SelectionChanged += dgvGrade_SelectionChanged;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(418, 134);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 35);
            btnClear.TabIndex = 79;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(386, 138);
            label9.Name = "label9";
            label9.Size = new Size(30, 27);
            label9.TabIndex = 78;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(205, 138);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 77;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "grade_name", "grade_order", "grade_group" });
            cmbSearch.Location = new Point(19, 137);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(180, 28);
            cmbSearch.TabIndex = 76;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(488, 70);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 48);
            btnNew.TabIndex = 75;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            btnEdit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(284, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(61, 48);
            btnEdit.TabIndex = 74;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnGetStudent
            // 
            btnGetStudent.BackgroundImage = (Image)resources.GetObject("btnGetStudent.BackgroundImage");
            btnGetStudent.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetStudent.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetStudent.Location = new Point(352, 70);
            btnGetStudent.Name = "btnGetStudent";
            btnGetStudent.Size = new Size(61, 48);
            btnGetStudent.TabIndex = 73;
            btnGetStudent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(420, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 48);
            btnDelete.TabIndex = 72;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(216, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 48);
            btnAdd.TabIndex = 68;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetData
            // 
            btnGetData.BackgroundImage = (Image)resources.GetObject("btnGetData.BackgroundImage");
            btnGetData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetData.Location = new Point(148, 70);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(61, 48);
            btnGetData.TabIndex = 69;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // btnDataInsert
            // 
            btnDataInsert.BackgroundImage = (Image)resources.GetObject("btnDataInsert.BackgroundImage");
            btnDataInsert.BackgroundImageLayout = ImageLayout.Zoom;
            btnDataInsert.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDataInsert.Location = new Point(80, 69);
            btnDataInsert.Name = "btnDataInsert";
            btnDataInsert.Size = new Size(61, 48);
            btnDataInsert.TabIndex = 70;
            btnDataInsert.UseVisualStyleBackColor = true;
            btnDataInsert.Click += btnDataInsert_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 69);
            button1.Name = "button1";
            button1.Size = new Size(61, 48);
            button1.TabIndex = 71;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackgroundImage = (Image)resources.GetObject("btnTestConnection.BackgroundImage");
            btnTestConnection.BackgroundImageLayout = ImageLayout.Zoom;
            btnTestConnection.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnection.Location = new Point(-136, 13);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(61, 48);
            btnTestConnection.TabIndex = 67;
            btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(1338, 47);
            label1.TabIndex = 2;
            label1.Text = "Grade Details Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Grade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 624);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Grade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label1;
        private Button btnTestConnection;
        private Button btnNew;
        private Button btnEdit;
        private Button btnGetStudent;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnGetData;
        private Button btnDataInsert;
        private Button button1;
        private Button btnClear;
        private Label label9;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private DataGridView dgvGrade;
        private Button btnHome;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtGradeGroup;
        private Label label2;
        private TextBox txtGradeName;
        private Label lblFirstName;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtGradeOrder;
    }
}