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
    public partial class AdminStudent : Form
    {
        public AdminStudent()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //StaffLogin s = new StaffLogin();
            using (DataClasses1DataContext DB = new DataClasses1DataContext())
            {
                var result = from c in DB.STUDENTs
                             select new { c.Id, c.Name, c.Fatthers_Name_, c.Mathers_Name, c.Parents_Mibile_, c.Mail_Address, c.DOB, c.Address };
                ////DataGridview1.DataSource = result;
                dataGridView1.DataSource = result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               

           
             
                Registrationpage r = new Registrationpage();
                r.Show();
                this.Hide();
                






            }

        private void button3_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext DB = new DataClasses1DataContext()) {

                
            
            
            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext DB = new DataClasses1DataContext())
            {
                var result = from c in DB.STUDENTs where c.Id==textBox1.Text
                             select new { c.Id, c.Name, c.Fatthers_Name_, c.Mathers_Name, c.Parents_Mibile_, c.Mail_Address, c.DOB, c.Address };
                ////DataGridview1.DataSource = result;
                dataGridView1.DataSource = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        }

    }
