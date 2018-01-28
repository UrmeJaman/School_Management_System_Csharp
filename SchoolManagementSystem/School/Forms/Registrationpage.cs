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
    public partial class Registrationpage : Form
    {
        public Registrationpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContactUs c = new ContactUs();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Hide();*/


             using (DataClasses1DataContext DB = new DataClasses1DataContext())
            {
                
               // string date = DateTime.Now.ToShortDateString();

                 STUDENT s = new STUDENT();
                 
                 s.Id = textBox8.Text;
                 s.Password = textBox9.Text;
                 s.Name = textBox1.Text;
                 s.Fatthers_Name_ = textBox2.Text;
                 s.Mathers_Name = textBox3.Text;
                 
                 s.Address = textBox5.Text;
                 s.Parents_Mibile_ = textBox6.Text;
                 //s.DOB = DateTime.Parse(dateTimePicker1);
                 s.Mail_Address = textBox5.Text;
                 
                 DB.STUDENTs.InsertOnSubmit(s);
                 DB.SubmitChanges();
                 MessageBox.Show("STUDENT ADDED");
                 AdminStudent A = new AdminStudent();
                 A.Show();
                 this.Hide();



                 



            }
        }



        

        private void Registrationpage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
