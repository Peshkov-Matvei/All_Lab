using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            Random rn = new Random();
            string[] text = richTextBox2.Text.Split(' ', '\n'), text1 = richTextBox3.Text.Split(' ', '\n');
            int n = int.Parse(text[2]), n1 = int.Parse(text[8]), n2 = int.Parse(text[15]), n3 = int.Parse(text[22]), n4 = int.Parse(text[28]), n5 = int.Parse(text[34]),
                n6 = int.Parse(text[40]), n7 = int.Parse(text[46]), n8 = int.Parse(text[52]), n9 = int.Parse(text[58]), n10 = int.Parse(text[64]);
            int r = int.Parse(text1[2]), n11 = int.Parse(text1[8]), n22 = int.Parse(text1[15]), n33 = int.Parse(text1[22]), n44 = int.Parse(text1[28]), n55 = int.Parse(text1[34]),
                n66 = int.Parse(text1[40]), n77 = int.Parse(text1[46]), n88 = int.Parse(text1[52]), n99 = int.Parse(text1[58]), n100 = int.Parse(text1[64]);
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            if (n == 5)
            {
                n = 0; r++;
                int[] s1 = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 };
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1.Max() == s1[i])
                    {
                        if (i == 0) n11 += 5;
                        if (i == 1) n22 += 5;
                        if (i == 2) n33 += 5;
                        if (i == 3) n44 += 5;
                        if (i == 4) n55 += 5;
                        if (i == 5) n66 += 5;
                        if (i == 6) n77 += 5;
                        if (i == 7) n88 += 5;
                        if (i == 8) n99 += 5;
                        if (i == 9) n100 += 5;
                    }
                }
                n1 = 0; n2 = 0; n3 = 0; n4 = 0; n5 = 0;
                n6 = 0; n7 = 0; n8 = 0; n9 = 0; n10 = 0;
            }
            else 
            { 
                n++; n1 += rn.Next(1, 6); n2 += rn.Next(1, 6); n3 += rn.Next(1, 6); n4 += rn.Next(1, 6); n10 += rn.Next(1, 6);
                n5 += rn.Next(1, 6); n6 += rn.Next(1, 6); n7 += rn.Next(1, 6); n8 += rn.Next(1, 6); n9 += rn.Next(1, 6);

            }
            richTextBox1.AppendText("Первый игрок - " + textBox2.Text + "\n \n");
            richTextBox1.AppendText("Второй игрок - " + textBox3.Text + "\n \n");
            richTextBox1.AppendText("Третий игрок - " + textBox4.Text + "\n \n");
            richTextBox1.AppendText("Четвертый игрок - " + textBox8.Text + "\n \n");
            richTextBox1.AppendText("Пятый игрок - " + textBox10.Text + "\n \n");
            richTextBox1.AppendText("Шестой игрок - " + textBox9.Text + "\n \n");
            richTextBox1.AppendText("Седьмой игрок - " + textBox6.Text + "\n \n");
            richTextBox1.AppendText("Восьмой игрок - " + textBox5.Text + "\n \n");
            richTextBox1.AppendText("Девятый игрок - " + textBox7.Text + "\n \n");
            richTextBox1.AppendText("Десятый игрок - " + textBox1.Text);
            richTextBox2.AppendText("Ход - " + n + "\n \n");
            richTextBox2.AppendText("Первый игрок имеет " + n1 + " очков" + "\n \n");
            richTextBox2.AppendText("Второй игрок имеет " + n2 + " очков" + "\n \n");
            richTextBox2.AppendText("Третий игрок имеет " + n3 + " очков" + "\n \n");
            richTextBox2.AppendText("Четвертый имеет " + n4 + " очков" + "\n \n");
            richTextBox2.AppendText("Пятый имеет " + n5 + " очков" + "\n \n");
            richTextBox2.AppendText("Шестой имеет " + n6 + " очков" + "\n \n");
            richTextBox2.AppendText("Седьмой имеет " + n7 + " очков" + "\n \n");
            richTextBox2.AppendText("Восьмой имеет " + n8 + " очков" + "\n \n");
            richTextBox2.AppendText("Девятый имеет " + n9 + " очков" + "\n \n");
            richTextBox2.AppendText("Десятый имеет " + n10 + " очков");
            richTextBox3.AppendText("Раунд - " + r + "\n \n");
            richTextBox3.AppendText("Первый игрок имеет " + n11 + " баллов" + "\n \n");
            richTextBox3.AppendText("Второй игрок имеет " + n22 + " баллов" + "\n \n");
            richTextBox3.AppendText("Третий игрок имеет " + n33 + " баллов" + "\n \n");
            richTextBox3.AppendText("Четвертый имеет " + n44 + " баллов" + "\n \n");
            richTextBox3.AppendText("Пятый имеет " + n55 + " баллов" + "\n \n");
            richTextBox3.AppendText("Шестой имеет " + n66 + " баллов" + "\n \n");
            richTextBox3.AppendText("Седьмой имеет " + n77 + " баллов" + "\n \n");
            richTextBox3.AppendText("Восьмой имеет " + n88 + " баллов" + "\n \n");
            richTextBox3.AppendText("Девятый имеет " + n99 + " баллов" + "\n \n");
            richTextBox3.AppendText("Десятый имеет " + n100 + " баллов");
            if (r == 5)
            {
                int k = 0;
                int[] s2 = { n11, n22, n33, n44, n55, n66, n77, n88, n99, n100};
                for (int i = 0; i < s2.Length; i++)
                {
                    if (s2.Max() == s2[i])
                    {
                        if (k == 0)
                        {
                            MessageBox.Show("Игрок под номером " + Convert.ToString(i + 1) + " выйграл!!!!");
                            k++;
                        }
                        else MessageBox.Show("Игрок под номером " + Convert.ToString(i + 1) + " тоже выйграл!!!!!");
                    }
                }
                richTextBox2.Clear();
                richTextBox3.Clear();
                richTextBox2.AppendText("Ход - " + 0 + "\n \n");
                richTextBox2.AppendText("Первый игрок имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Второй игрок имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Третий игрок имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Четвертый имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Пятый имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Шестой имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Седьмой имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Восьмой имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Девятый имеет " + 0 + " очков" + "\n \n");
                richTextBox2.AppendText("Десятый имеет " + 0 + " очков");
                richTextBox3.AppendText("Раунд - " + 0 + "\n \n");
                richTextBox3.AppendText("Первый игрок имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Второй игрок имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Третий игрок имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Четвертый имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Пятый имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Шестой имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Седьмой имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Восьмой имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Девятый имеет " + 0 + " баллов" + "\n \n");
                richTextBox3.AppendText("Десятый имеет " + 0 + " баллов");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
