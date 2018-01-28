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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome(); ;
            w.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin s = new StudentLogin();
            s.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffLogin st = new StaffLogin();
            st.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParentsLogin p = new ParentsLogin();
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text.Equals("Admin"))
            {
            AdminLogin ad = new AdminLogin();
                ad.Show();
                this.Hide();
            }


            else if (comboBox1.Text.Equals("Teacher"))
            {
                TeacherLogin ad = new TeacherLogin();
                ad.Show();
                this.Hide();
            }

            else  if (comboBox1.Text.Equals("Students"))
            {
                StudentLogin ad = new StudentLogin();
                ad.Show();
                this.Hide();
            }
            else   if (comboBox1.Text.Equals("Parents"))
            {
                ParentsLogin ad = new ParentsLogin();
                ad.Show();
                this.Hide();
            }
            else if (comboBox1.Text.Equals("Staff"))
            {
                StaffLogin ad = new StaffLogin();
                ad.Show();
                this.Hide();
            }

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
           
        }
    }
}