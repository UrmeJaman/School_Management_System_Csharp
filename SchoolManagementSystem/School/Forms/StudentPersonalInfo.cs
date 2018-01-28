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
    public partial class StudentPersonalInfo : Form
    {
        public StudentPersonalInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPage p = new StudentPage();
            p.Show();
            this.Hide();
        }

        private void StudentPersonalInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
