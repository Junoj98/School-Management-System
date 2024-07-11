namespace LMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            gradientPanel1 = new GradientPanel();
            lblRegisterHere = new Label();
            chbShowPassword = new CheckBox();
            label4 = new Label();
            btnLogIn = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.FromArgb(4, 87, 122);
            gradientPanel1.ColorTop = Color.Teal;
            gradientPanel1.Controls.Add(lblRegisterHere);
            gradientPanel1.Controls.Add(chbShowPassword);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(btnLogIn);
            gradientPanel1.Controls.Add(txtPassword);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(txtUserName);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(827, 489);
            gradientPanel1.TabIndex = 0;
            // 
            // lblRegisterHere
            // 
            lblRegisterHere.AutoSize = true;
            lblRegisterHere.BackColor = Color.Transparent;
            lblRegisterHere.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterHere.ForeColor = SystemColors.ControlLightLight;
            lblRegisterHere.Location = new Point(625, 381);
            lblRegisterHere.Name = "lblRegisterHere";
            lblRegisterHere.Size = new Size(114, 19);
            lblRegisterHere.TabIndex = 16;
            lblRegisterHere.Text = "Register Here";
            lblRegisterHere.Click += lblRegisterHere_Click;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = SystemColors.ControlLightLight;
            chbShowPassword.Location = new Point(614, 297);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(137, 23);
            chbShowPassword.TabIndex = 15;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(458, 383);
            label4.Name = "label4";
            label4.Size = new Size(171, 17);
            label4.TabIndex = 14;
            label4.Text = "Don't Have an Account ?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(4, 87, 122);
            btnLogIn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = SystemColors.ControlLightLight;
            btnLogIn.Location = new Point(525, 334);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(163, 35);
            btnLogIn.TabIndex = 13;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(472, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 28);
            txtPassword.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(472, 233);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(472, 183);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(260, 28);
            txtUserName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(472, 155);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(380, 91);
            label5.Name = "label5";
            label5.Size = new Size(204, 32);
            label5.TabIndex = 3;
            label5.Text = "Welcome Back !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 489);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblRegisterHere;
        private CheckBox chbShowPassword;
        private Label label4;
        private Button btnLogIn;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private Label label5;
    }
}