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
    public partial class StaffInfo : Form
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffLogin lsl = new StaffLogin();
            lsl.Show();
            this.Hide();


        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            StaffLogin s = new StaffLogin();
            using (DataClasses1DataContext DB = new DataClasses1DataContext()) {
                var result = from c in DB.STAFFs  where c.Id==this.textBox1.Text
                             select new { c.Id, c.Password ,c.Name_, c.Position, c.Salary,c.Address };
                ////DataGridview1.DataSource = result;
                dataGridView1.DataSource = result;
            }
        }




        



       public  void Get_Data()
        {
            DataClasses1DataContext cntx = new DataClasses1DataContext();
            dataGridView1.DataSource = cntx.STAFFs;





        }



    }
}