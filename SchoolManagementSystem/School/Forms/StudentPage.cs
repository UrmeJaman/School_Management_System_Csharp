using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentLogin sl = new StudentLogin();
            sl.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMarksPage s = new ShowMarksPage();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClassTiming c = new ClassTiming();
            c.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeacherInfo t = new TeacherInfo();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPersonalInfo sp = new StudentPersonalInfo();
            sp.Show();
            this.Hide();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
