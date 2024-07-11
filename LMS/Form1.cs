using System.Reflection.Emit;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
            pictureBox1.Parent = gradientPanel1;
            pictureBox1.BackColor = Color.Transparent;
            btnLogout.Parent = gradientPanel1;
            btnLogout.BackColor = Color.Transparent;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            grade.Show();
            this.Hide();

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.Show();
            this.Hide();
        }

        private void btnGradeSubject_Click(object sender, EventArgs e)
        {
            GradeSubject gradeSubject = new GradeSubject();
            gradeSubject.Show();
            this.Hide();
        }

        private void btnStudentSubject_Click(object sender, EventArgs e)
        {
            StudentSubject studentSubject = new StudentSubject();
            studentSubject.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
