using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsapplicationfrom
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                MessageBox.Show("male");
            }
            else
            {
                MessageBox.Show("female");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
           
      
        }
    }
}
