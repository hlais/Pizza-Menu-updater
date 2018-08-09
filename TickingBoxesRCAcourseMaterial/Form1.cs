using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickingBoxesRCAcourseMaterial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //default true. Contructor Gets Run automatically
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButton1.Checked)
            {
                listBox1.Items.Add(radioButton1.Text);

            }
            if (radioButton2.Checked)
            {
                listBox1.Items.Add(radioButton2.Text);
            }
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            radioButton1.Checked = true;

        }
    }
}
