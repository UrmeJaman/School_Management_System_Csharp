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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Registrationpage r = new Registrationpage();
            r.Show();
                this.Hide();*/
            AdminStudent ad = new AdminStudent();
            ad.Show();
            this.Hide();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTeacher t = new AddTeacher();
            t.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStaff a = new AddStaff();
            a.Show();
            this.Show();
        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
