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
    public partial class ClassTiming : Form
    {
        public ClassTiming()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn p = new LogIn();
            p.Show();
            this.Hide();

        }

        private void ClassTiming_Load(object sender, EventArgs e)
        {
            
        }
    }
}
