namespace LMS
{
    partial class Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            gradientPanel1 = new GradientPanel();
            btnCancel = new Button();
            btnUpdate = new Button();
            groupBox3 = new GroupBox();
            txtSubjectOrder = new TextBox();
            label3 = new Label();
            txtSubjectNumber = new TextBox();
            label4 = new Label();
            txtSubjectIndex = new TextBox();
            label2 = new Label();
            txtSubjectName = new TextBox();
            lblFirstName = new Label();
            btnHome = new Button();
            dgvSubject = new DataGridView();
            btnClear = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearch = new ComboBox();
            btnNew = new Button();
            btnDelete = new Button();
            btnGetData = new Button();
            button1 = new Button();
            label1 = new Label();
            gradientPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
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
            gradientPanel1.Controls.Add(dgvSubject);
            gradientPanel1.Controls.Add(btnClear);
            gradientPanel1.Controls.Add(label9);
            gradientPanel1.Controls.Add(txtSearch);
            gradientPanel1.Controls.Add(cmbSearch);
            gradientPanel1.Controls.Add(btnNew);
            gradientPanel1.Controls.Add(btnDelete);
            gradientPanel1.Controls.Add(btnGetData);
            gradientPanel1.Controls.Add(button1);
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
            btnCancel.Location = new Point(1063, 554);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 39);
            btnCancel.TabIndex = 102;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(948, 554);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 39);
            btnUpdate.TabIndex = 101;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtSubjectOrder);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtSubjectNumber);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtSubjectIndex);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtSubjectName);
            groupBox3.Controls.Add(lblFirstName);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(813, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 321);
            groupBox3.TabIndex = 100;
            groupBox3.TabStop = false;
            groupBox3.Text = "Grade Details";
            // 
            // txtSubjectOrder
            // 
            txtSubjectOrder.Font = new Font("Times New Roman", 10.8F);
            txtSubjectOrder.Location = new Point(174, 220);
            txtSubjectOrder.Name = "txtSubjectOrder";
            txtSubjectOrder.Size = new Size(224, 28);
            txtSubjectOrder.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(27, 223);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 7;
            label3.Text = "Subject Order";
            // 
            // txtSubjectNumber
            // 
            txtSubjectNumber.Font = new Font("Times New Roman", 10.8F);
            txtSubjectNumber.Location = new Point(174, 165);
            txtSubjectNumber.Name = "txtSubjectNumber";
            txtSubjectNumber.Size = new Size(224, 28);
            txtSubjectNumber.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(27, 168);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Subject Number";
            // 
            // txtSubjectIndex
            // 
            txtSubjectIndex.Font = new Font("Times New Roman", 10.8F);
            txtSubjectIndex.Location = new Point(174, 110);
            txtSubjectIndex.Name = "txtSubjectIndex";
            txtSubjectIndex.Size = new Size(224, 28);
            txtSubjectIndex.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(27, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 5;
            label2.Text = "Subject Index";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Times New Roman", 10.8F);
            txtSubjectName.Location = new Point(174, 55);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(224, 28);
            txtSubjectName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 10.8F);
            lblFirstName.Location = new Point(27, 58);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(111, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Subject Name";
            // 
            // btnHome
            // 
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(285, 79);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 48);
            btnHome.TabIndex = 99;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.AllowUserToAddRows = false;
            dgvSubject.AllowUserToDeleteRows = false;
            dgvSubject.BackgroundColor = SystemColors.ControlLight;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(19, 199);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubject.Size = new Size(738, 399);
            dgvSubject.TabIndex = 98;
            dgvSubject.SelectionChanged += dgvSubject_SelectionChanged;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(418, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 35);
            btnClear.TabIndex = 97;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(386, 148);
            label9.Name = "label9";
            label9.Size = new Size(30, 27);
            label9.TabIndex = 96;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.ForeColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(205, 148);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 95;
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
            cmbSearch.Location = new Point(19, 147);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(180, 28);
            cmbSearch.TabIndex = 94;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(218, 78);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 48);
            btnNew.TabIndex = 93;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(151, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 48);
            btnDelete.TabIndex = 90;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetData
            // 
            btnGetData.BackgroundImage = (Image)resources.GetObject("btnGetData.BackgroundImage");
            btnGetData.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetData.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetData.Location = new Point(84, 79);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(61, 48);
            btnGetData.TabIndex = 87;
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(17, 79);
            button1.Name = "button1";
            button1.Size = new Size(61, 48);
            button1.TabIndex = 89;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(2, 13);
            label1.Name = "label1";
            label1.Size = new Size(1338, 47);
            label1.TabIndex = 85;
            label1.Text = "Subject Details Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 624);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += Subject_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Button btnCancel;
        private Button btnUpdate;
        private GroupBox groupBox3;
        private TextBox txtSubjectOrder;
        private Label label3;
        private TextBox txtSubjectIndex;
        private Label label2;
        private TextBox txtSubjectName;
        private Label lblFirstName;
        private Button btnHome;
        private DataGridView dgvSubject;
        private Button btnClear;
        private Label label9;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
        private Button btnNew;
        private Button btnDelete;
        private Button btnGetData;
        private Button button1;
        private Label label1;
        private TextBox txtSubjectNumber;
        private Label label4;
    }
}