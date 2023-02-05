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
    public partial class Even : Form
    {
       
        
        public Even()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl4.Text = "";
       }
      
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("inviled value enter your value ");
            }else{

            double  num = Convert.ToDouble(txt1.Text);
                if (num < 0)
                {
                    MessageBox.Show("Enter Number Greater than Zero");
                }
                else
                {
                    if (num % 2 == 0)
                    {
                        lbl4.Text = num + "is a even ";
                    }
                    else
                    {
                        lbl4.Text = num + "is a odd ";
                    }
                }
            }
        }

        private void Even_Load(object sender, EventArgs e)
        {

        }
    }
}
