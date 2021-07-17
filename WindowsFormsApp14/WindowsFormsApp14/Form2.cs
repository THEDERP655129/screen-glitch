using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            int ssw = Screen.PrimaryScreen.Bounds.Width;
            int ssh = Screen.PrimaryScreen.Bounds.Height;

            int xpos = rnd.Next(1, ssw);
            int ypos = rnd.Next(1, ssh);
            int xsize = rnd.Next(1, 500);
            int ysize = rnd.Next(1, 500);
            TopMost = true;

            Bitmap ps = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(ps as Image);
            g.CopyFromScreen(xsize, ysize, 0, 0, ps.Size);
            //printing the screen
            pictureBox1.Image = ps;

            this.Width = xsize;
            this.Height = ysize;
            this.Location = new Point(xpos, ypos);
            pictureBox1.Width = xpos;
            pictureBox1.Height = ypos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
