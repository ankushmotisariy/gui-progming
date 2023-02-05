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
    public partial class Cheakbox : Form
    {
        public Cheakbox()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String str  = " ";
            if (checkBoxc.Checked == true)
            {
                str += checkBoxc.Text;
                str += ",";
            }

            if (checkBoxcpluse.Checked == true)
            {
                str += checkBoxcpluse.Text;
                str += ",";
            }

            if (checkBoxjava.Checked == true)
            {
                str += checkBoxjava.Text;
                str += ",";
            }

            if (checkBoxsharap.Checked == true)
            {
                str += checkBoxsharap.Text;
                str += ",";
            }
            lblMessage.Text = "THE SELECTED PROGRIMING LANGUGE  :" +str;
            
        }

        private void checkBoxc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxsharap_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
