using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace School
{
    public partial class TeacherLogin : Form
    {
        public TeacherLogin()
        {
            DataClasses1DataContext cntx = new DataClasses1DataContext();
            

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn();
            l1.Show();
            this.Hide();
        }

        private void TeacherLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            using (DataClasses1DataContext DB = new DataClasses1DataContext())
            {
                var loginResult = DB.TEACHERs.FirstOrDefault(x => x.Id== this.textBox3.Text && x.Password == this.textBox4.Text);
                if (loginResult != null)
                {
                    TeacherInfo asp = new TeacherInfo();
                    this.Hide();
                    asp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username OR Passowrd Invalid");
                }
            }

        }

           
            }
        }

        
    

