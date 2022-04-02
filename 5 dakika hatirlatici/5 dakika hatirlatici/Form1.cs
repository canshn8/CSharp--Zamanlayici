using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _5_dakika_hatirlatici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1.tur += 1;
            this.Text = "Tür: " + Class1.tur + " Hatırlatıcı";
            timer4.Interval = Class1.timer;
            lbl_saniye.Text = "0";
            lbl_dakika.Text = "0";
            button1.Text = "Durdur";
            timer1.Start();
            timer2.Start();
            timer4.Start();
            if (Class1.timer == 295000)
            {
                comboBox1.Text = "5 Dakika";
            }
            else if (Class1.timer == 590000)
            {
                comboBox1.Text = "10 Dakika";
            }
            else if (Class1.timer == 885000)
            {
                comboBox1.Text = "15 Dakika";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye = int.Parse(lbl_saniye.Text);
            lbl_saniye.Text = (saniye + 1).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int dakika = int.Parse(lbl_dakika.Text);
            lbl_dakika.Text = (dakika + 1).ToString();
            lbl_saniye.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Durdur")
            {
                button1.Text = "Başlat";
                timer1.Stop();
                timer2.Stop();
                timer4.Stop();
                lbl_saniye.Text = "0";
                lbl_dakika.Text = "0";
            }
            else if (button1.Text == "Başlat")
            {
                button1.Text = "Durdur";
                timer1.Start();
                timer2.Start();
                timer4.Start();
            }
        }

        
        private void timer4_Tick(object sender, EventArgs e)
        {
            
            timer2.Stop();
            timer4.Stop();
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();            
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer1.Stop();
            lbl_saniye.Text = "0";
            lbl_dakika.Text = "0";
            timer1.Start();
            timer2.Start();
            timer4.Start();

            if (comboBox1.SelectedIndex == 0)
            {
                Class1.timer = 295000;
                timer4.Interval = 295000;
                Class1.msg = 5;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Class1.timer = 590000;
                timer4.Interval = 590000;
                Class1.msg = 10;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Class1.timer = 885000;
                timer4.Interval = 885000;
                Class1.msg = 15;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
