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
    public partial class Calculter : Form
    {
        float inpt1;
        float inpt2;
        public Calculter()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            float ans = inpt1 + inpt2;
            Console.WriteLine(txt3.Text = ans.ToString());
        }

        private void Calculter_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            inpt1 = Single.Parse(txt1.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            inpt2 = Single.Parse(txt2.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            float ans = inpt1 - inpt2;
            Console.WriteLine(txt3.Text = ans.ToString());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            float ans = inpt1 / inpt2;
            Console.WriteLine(txt3.Text = ans.ToString());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            float ans = inpt1 * inpt2;
            Console.WriteLine(txt3.Text = ans.ToString());
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            
        }

      // * private void btn5_Click(object sender, EventArgs e)
        //{
            //float ans = inpt1 + inpt2;
            //Console.WriteLine(txt3.Text = ans.ToString());
        //}*//
    }
}
