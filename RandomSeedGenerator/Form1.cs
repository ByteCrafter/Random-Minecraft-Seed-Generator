using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSeedGenerator
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Generator.SeedGenerator(Generator.SeedOption.Small).ToString();
                MessageBox.Show(textBox1.Text);
                Clipboard.SetText(textBox1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                textBox1.Text = Generator.SeedGenerator(Generator.SeedOption.Big).ToString();
                MessageBox.Show(textBox1.Text);
                Clipboard.SetText(textBox1.Text);
            }

            }
    }



    }

