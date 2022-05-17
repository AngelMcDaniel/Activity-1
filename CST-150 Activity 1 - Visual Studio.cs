using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1
{
    public partial class windowPanel : Form
    {
        private string message = "Hello! My name is Angel McDaniel.";

        public windowPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Message Box";
            MessageBox.Show(message, title);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                message = "Hi!";
            }
            else { message = "Hello! My name is Angel McDaniel."; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {  
                comboBox1.BackColor = Color.Red; 
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox1.BackColor = Color.Yellow;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox1.BackColor = Color.Blue;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox1.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox1.BackColor = Color.Purple;
            }
        }
    }
}
