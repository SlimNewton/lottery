using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] ss = new String[30];
        public int N;


        void EmptyTextbox(params TextBox[] g)
        {
            foreach (TextBox j in g)
            {
                j.Text = string.Empty;
            }
        }



        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Random k = new Random();
                textBox1.Text = "0";
                textBox2.Text = "9";
                textBox3.Text = k.Next(10).ToString();
                textBox4.Text = k.Next(10).ToString();
                textBox5.Text = k.Next(10).ToString();
                textBox6.Text = k.Next(10).ToString();
                textBox7.Text = k.Next(10).ToString();
                textBox8.Text = k.Next(10).ToString();
                textBox9.Text = k.Next(10).ToString();
                textBox10.Text = k.Next(10).ToString();
            }
            
            if(radioButton2.Checked)
            {
                Random x = new Random();
                label1.Text = ss[x.Next(N)];
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                timer1.Enabled = false;
                int x = int.Parse(textBox3.Text);
                int r = int.Parse(textBox4.Text);
                int t = int.Parse(textBox5.Text);
                int y = int.Parse(textBox6.Text);
                int u = int.Parse(textBox7.Text);
                int i = int.Parse(textBox8.Text);
                int o = int.Parse(textBox9.Text);
                int p = int.Parse(textBox10.Text);
                EmptyTextbox(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10);
                MessageBox.Show("This Number of the Winner is 09" + x + r + t + y + u + i + o + p);
                Class1.f2.listBox1.Items.Add("This Number of the Winner is 09" + x + r + t + y + u + i + o + p).ToString();
            }

            if(radioButton2.Checked)
            {
                timer1.Enabled = false;
                MessageBox.Show("This Number is the Winner" + label1.Text);
                Class1.f2.listBox1.Items.Add("This Number is the Winner" + label1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.f1.Hide();
            Class1.f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ss[N] = textBox11.Text;
            N++;
            textBox11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Class1.f2.listBox1.Items.Clear();
        }
    }
}
