using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(125);
            }
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
                await Task.Delay(125);
            }
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                await Task.Delay(125);
            }
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                await Task.Delay(125);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 6, pictureBox1.Location.Y);
                await Task.Delay(125);
            }
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X-3, pictureBox1.Location.Y + 6);
                await Task.Delay(125);
            }
            for (int i = 0; i < 50; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X-3, pictureBox1.Location.Y - 6);
                await Task.Delay(125);
            }
        }
    }
}
