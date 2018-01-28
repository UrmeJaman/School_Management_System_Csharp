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
    public partial class ShowMarksPage : Form
    {
        public ShowMarksPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPage p = new StudentPage();
            p.Show();
            this.Hide();
        }

        private void ShowMarksPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
