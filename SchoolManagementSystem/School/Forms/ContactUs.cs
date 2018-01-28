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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome(); ;
            w.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrationpage r = new Registrationpage();
            r.Show();
            this.Hide();
        }

        private void ContactUs_Load(object sender, EventArgs e)
        {
           
        }
    }
}
