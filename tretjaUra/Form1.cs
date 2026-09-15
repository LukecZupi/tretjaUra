using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //za StreamWriter ampak tud ce ne napises ti ga avtomaticno da

namespace tretjaUra
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
            if (textBox1.Text != ""){


                StreamWriter sw = File.CreateText("test.txt");
                sw.WriteLine(textBox1.Text);
                /*
                sw.Write("To je prva vrstica");
                sw.WriteLine("To je druga vrstica.");
                sw.WriteLine("To je tretja vrstica");
                */
                sw.Close();
                MessageBox.Show("podatki so zapisani");
            }
            else
            {
                MessageBox.Show("Vnesi vsebino");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Length > 1)
            {
                StreamWriter sw = File.CreateText("ime.txt");
                for (int i = 0; i < textBox2.Text.Length; i++)
                {

                    sw.WriteLine(textBox2.Text);

                }
                sw.Close ();
                MessageBox.Show("podatki so zapisani");
            }
            else
                MessageBox.Show("Vnesi ime");
        }
    }
}
