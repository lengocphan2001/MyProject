using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHongHam
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
            String ans = "";
            if (checkBox1.Checked)
            {
                ans += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked)
            {
                ans += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked)
            {
                ans += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked)
            {
                ans += checkBox4.Text + "\n";
            }
            if (checkBox5.Checked)
            {
                ans += checkBox5.Text + "\n";
            }
            if (ans.Length == 0)
            {
                MessageBox.Show("Bạn không có sở thích");
            }
            else MessageBox.Show("Sở thích của bạn là:\n" + ans);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ans = "";
            if (radioButton1.Checked)
            {
                ans += radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                ans += radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                ans += radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                ans += radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                ans += radioButton5.Text;
            }
            if (ans.Length == 0)
            {
                MessageBox.Show("Hồng đâu mất tiêu rồi!!");
            }
            else MessageBox.Show("Hồng mà bạn thích là:\n" + ans);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/hi/hongtrohe.jpg");
            pictureBox2.Image = Image.FromFile("C:/hi/phanvui.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
