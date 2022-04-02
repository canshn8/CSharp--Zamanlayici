using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_dakika_hatirlatici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = Class1.msg + " Dakika Geçti!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_saniye.Text = "10";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            label_saniye.Text = "10";
            DialogResult dialog = MessageBox.Show("10 Saniye Boyunca Uzak Bir Yere Bakınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {               
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int eksik_saniye = int.Parse(label_saniye.Text) - 1;
            if (eksik_saniye == -1)
            {
                
                timer1.Stop();
                this.Hide();
                Form1 form = new Form1();                
                form.Show();
            }
            else
            {
                label_saniye.Text = (eksik_saniye).ToString();
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
