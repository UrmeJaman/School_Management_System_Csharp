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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            LogIn l1 = new LogIn();
            l1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (DataClasses1DataContext DB = new DataClasses1DataContext())
            {
                var loginResult = DB.STAFFs.FirstOrDefault(x => x.Id== this.textBox3.Text && x.Password == this.textBox4.Text);
                if (loginResult != null)
                {
                    StaffInfo asp = new StaffInfo();
                    this.Hide();
                    asp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username OR Passowrd Invalid");
                }

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            ForgetPassword sls = new ForgetPassword();
            sls.Show();
            this.Hide();




        }

       

    }
}