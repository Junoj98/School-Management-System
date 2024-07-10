namespace LMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gradientPanel1 = new GradientPanel();
            pictureBox1 = new PictureBox();
            btnSubject = new Button();
            btnGrade = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            label1 = new Label();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(btnSubject);
            gradientPanel1.Controls.Add(btnGrade);
            gradientPanel1.Controls.Add(btnTeacher);
            gradientPanel1.Controls.Add(btnStudent);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(969, 498);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(93, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 239);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSubject
            // 
            btnSubject.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(673, 173);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(123, 94);
            btnSubject.TabIndex = 1;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnGrade
            // 
            btnGrade.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrade.Location = new Point(815, 173);
            btnGrade.Name = "btnGrade";
            btnGrade.Size = new Size(123, 94);
            btnGrade.TabIndex = 1;
            btnGrade.Text = "Grade";
            btnGrade.UseVisualStyleBackColor = true;
            btnGrade.Click += btnGrade_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(531, 173);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(123, 94);
            btnTeacher.TabIndex = 1;
            btnTeacher.Text = "Teachers";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.Control;
            btnStudent.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(389, 173);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(123, 94);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(969, 47);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 498);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label1;
        private Button btnGrade;
        private Button btnTeacher;
        private Button btnStudent;
        private PictureBox pictureBox1;
        private Button btnSubject;
    }
}
