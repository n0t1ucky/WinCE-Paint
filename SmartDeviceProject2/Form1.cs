using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black,5);
        }
        private void setBtnClear()
        {
            btnRed.Text = "";
            btnOrange.Text = "";
            btnYellow.Text = "";
            btnGreen.Text = "";
            btnCyan.Text = "";
            btnBlue.Text = "";
            btnViolet.Text = "";
            btnBlack.Text = "";
            btnWhite.Text = "";
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            moving = true;
            label2.Text = "Down x=" + x + ", y=" + y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (x != -1 && y != -1 && moving)
            {
                g.DrawLine(pen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                label2.Text = "MOVE x=" + e.X + ", y=" + e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x = -1;
            y = -1;
            moving = false;
            label2.Text = "UP x=" + e.X + ", y=" + e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pen.Color = btnRed.BackColor;
            setBtnClear();
            btnRed.Text = "√";
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            pen.Color = btnOrange.BackColor;
            setBtnClear();
            btnOrange.Text = "√";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            pen.Color = btnYellow.BackColor;
            setBtnClear();
            btnYellow.Text = "√";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pen.Color = btnGreen.BackColor;
            setBtnClear();
            btnGreen.Text = "√";
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            pen.Color = btnCyan.BackColor;
            setBtnClear();
            btnCyan.Text = "√";
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            pen.Color = btnBlue.BackColor;
            setBtnClear();
            btnBlue.Text = "√";
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            pen.Color = btnViolet.BackColor;
            setBtnClear();
            btnViolet.Text = "√";
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pen.Color = btnBlack.BackColor;
            setBtnClear();
            btnBlack.Text = "√";
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            pen.Color = btnWhite.BackColor;
            setBtnClear();
            btnWhite.Text = "√";
        }

    }
}