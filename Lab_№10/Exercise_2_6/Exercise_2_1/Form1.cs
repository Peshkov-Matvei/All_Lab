using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.DrawLine(new Pen(Color.Black, 1.0f), -200, 0, 200, 0);
            g.DrawLine(new Pen(Color.Black, 1.0f), 0, -200, 0, 200);
            int ix, iz;
            double a = 1, b = 10, n = 40, z;
            double t = Math.Round((Math.Max(a, b) - Math.Min(a, b)) / n, 2);
            for (double x = a; x <= b; x += t)
            {
                z = -1 * (x * x * x + 5 * x * x + 14 * x - 56);
                iz = (int)z; ix = (int)x;
                g.DrawEllipse(new Pen(Color.Black, 3.0f), ix, iz, 1, 1);
            }
        }
    }
}
