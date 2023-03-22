using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string str = " ";

            //checkebox1 = japan
            if (japanBox.Checked == true)
            {

                str = str + japanBox.Text;
                str += " ";
            }

            
            //checkebox2 = philippines
            if (philippineBox.Checked == true)
            {

                str = str + philippineBox.Text;
                str += " ";
            }

            
            //checkebox2 = thailand
             if (thailandBox.Checked == true)
             {

                 str = str + thailandBox.Text;
                 str += " ";
             }
             //checkebox2 = australia
             if (australiaBox.Checked == true)
             {

                 str = str + australiaBox.Text;
                 str += " ";
             }
             if (checkBox1.Checked == true)
             {

                 str = str + othersBox.Text;
                 str += " ";
             }

            if (str != null){
                MessageBox.Show("You Selected: \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                othersLabel.Visible = true;
                othersBox.Visible = true;
            }
            else {
                othersLabel.Visible = false;
                othersBox.Visible = false;
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
