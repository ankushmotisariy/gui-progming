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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt32(txt1.Text);
            int value2 = Convert.ToInt32(txt2.Text);
            int addtion = value1 + value2;
            MessageBox.Show(addtion.ToString());

           
        }
        
    }
}
