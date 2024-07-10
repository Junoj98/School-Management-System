namespace LMS
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            gradientPanel1 = new GradientPanel();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            label5 = new Label();
            chbShowPassword = new CheckBox();
            btnRegister = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
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
            gradientPanel1.Controls.Add(lblLogin);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(chbShowPassword);
            gradientPanel1.Controls.Add(btnRegister);
            gradientPanel1.Controls.Add(txtPassword);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(txtUserName);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(txtEmail);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(800, 450);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 341);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(606, 388);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(94, 19);
            lblLogin.TabIndex = 14;
            lblLogin.Text = "Login Here";
            lblLogin.Click += lblLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(415, 390);
            label5.Name = "label5";
            label5.Size = new Size(186, 17);
            label5.TabIndex = 6;
            label5.Text = "Already Have an Account ?";
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = SystemColors.ControlLightLight;
            chbShowPassword.Location = new Point(558, 304);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(125, 21);
            chbShowPassword.TabIndex = 4;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(4, 87, 122);
            btnRegister.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(463, 339);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(163, 35);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(416, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 28);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(416, 240);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(416, 197);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(260, 28);
            txtUserName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(416, 169);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 8;
            label4.Text = "User Name";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(416, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 28);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(416, 98);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(349, 39);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 0;
            label1.Text = "Get Started !";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label1;
        private CheckBox chbShowPassword;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtUserName;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblLogin;
    }
}