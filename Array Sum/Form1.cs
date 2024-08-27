using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] input = new int[3];

            input[0] = (int)numericUpDown1.Value;
            input[1] = (int)numericUpDown2.Value;
            input[2] = (int)numericUpDown3.Value;

            MessageBox.Show("The sum is " + (input[0] + input[1] + input[2]).ToString() + "!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dupe())
            {
                MessageBox.Show("At least two inputs are the same!");
            }
            else
            {
                MessageBox.Show("All inputs are different!");
            }
        }

        bool dupe()
        {
            if (numericUpDown1.Value == numericUpDown2.Value ||
                numericUpDown1.Value == numericUpDown3.Value ||
                numericUpDown2.Value == numericUpDown3.Value)
            {
                return true;
            }
            return false;
        }
    }
}
