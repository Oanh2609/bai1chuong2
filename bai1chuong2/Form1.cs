using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1chuong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
            textBox3.ResetText();
            textBox1.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            tinhTong();
        }
        int tongchan = 0, tongle = 0, tong= 0;

       
        public void tinhTong()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

           // if (string.IsNullOrEmpty(textBox1.Text))
            //    MessageBox.Show("Bạn chưa nhập dãy số", "Warning");
            //else
            {
                int a;
                bool flag = true;
                string[] arr = textBox1.Text.Split();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!int.TryParse(arr[i], out a))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        tong += a;
                        if (a % 2 == 0)
                            tongchan += a;
                        else
                            tongle += a;
                    }
                }
                if (flag)
                {
                    textBox2.Text = textBox1.Text;
                    textBox3.Text = tong.ToString();
                   textBox4.Text = tongchan.ToString();
                    textBox5.Text = tongle.ToString();
                }
                else
                {
                    MessageBox.Show("Dãy số không đúng", "Warning");
                }
            }
        }
    }
 
        }
    
    

