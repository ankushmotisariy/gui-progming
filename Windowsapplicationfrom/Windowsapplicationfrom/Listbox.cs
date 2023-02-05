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
    public partial class Listbox : Form
    {
        public Listbox()
        {
            InitializeComponent();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            Batsman.Items.Clear();
           Batsman.Items.Add("DONI");
            Batsman.Items.Add("RUTURAJ");
            Batsman.Items.Add(" Devon Conway");
            Batsman.Items.Add("Subhranshu Senapati");
            Batsman.Items.Add("A Rahane");
            Batsman.Items.Add("Shaik Rasheed");
            
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Batsman.Items.Clear();
            Batsman.Items.Add("Rohit Sharma (c)");
            Batsman.Items.Add("Suryakumar Yadav");
            Batsman.Items.Add(" Tilak Varma");
            Batsman.Items.Add("Ramandeep Singh");
            Batsman.Items.Add("Dewald Brevis");
           
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("Virat Kohli");
            Batsman.Items.Add("Suyash Prabhudessai");
            Batsman.Items.Add(" Faf du Plessis");
            Batsman.Items.Add("Rajat Patidar");
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("DONI");
            Batsman.Items.Add("RUTURAJ");
            Batsman.Items.Add(" Devon Conway");
            Batsman.Items.Add("Subhranshu Senapati");
            Batsman.Items.Add("A Rahane");
            Batsman.Items.Add("Shaik Rasheed");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("DONI");
            Batsman.Items.Add("RUTURAJ");
            Batsman.Items.Add(" Devon Conway");
            Batsman.Items.Add("Subhranshu Senapati");
            Batsman.Items.Add("A Rahane");
            Batsman.Items.Add("Shaik Rasheed");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("DONI");
            Batsman.Items.Add("RUTURAJ");
            Batsman.Items.Add(" Devon Conway");
            Batsman.Items.Add("Subhranshu Senapati");
            Batsman.Items.Add("A Rahane");
            Batsman.Items.Add("Shaik Rasheed");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("DONI");
            Batsman.Items.Add("RUTURAJ");
            Batsman.Items.Add(" Devon Conway");
            Batsman.Items.Add("Subhranshu Senapati");
            Batsman.Items.Add("A Rahane");
            Batsman.Items.Add("Shaik Rasheed");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("Bhanuka Rajapaksa");
            Batsman.Items.Add("Shahrukh Khan");
            Batsman.Items.Add(" Shikhar Dhawan");
            Batsman.Items.Add("Prabhsimran Singh");
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("Yashasvi Jaiswal");
            Batsman.Items.Add("Devdutt Padikkal");
            Batsman.Items.Add(" Shimron Hetmyer");
            Batsman.Items.Add("Sanju Samson (c&wk)");
            Batsman.Items.Add("Dhruv Jurel (wk)");
            Batsman.Items.Add("Shaik Rasheed");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Batsman.Items.Add("Aiden Markram");
            Batsman.Items.Add("Rahul Tripathi");
            Batsman.Items.Add(" Harry Brook");
            Batsman.Items.Add("Mayank Agarwal");
            Batsman.Items.Add("Anmolpreet Singh");
            
        }
    }
}
   

