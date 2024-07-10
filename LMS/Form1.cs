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
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.ShowDialog();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            grade.ShowDialog();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.ShowDialog();
        }
    }
}
