using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 4);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);

            g.DrawLine(redPen, 0, 0, 100, 100);
            g.FillRectangle(blackBrush, 30, 30, 100, 200);
            g.DrawRectangle(redPen, 100, 100, 200, 100);

            g.DrawEllipse(redPen, 100, 100, 200, 100);
            g.FillEllipse(blackBrush, 100, 100, 200, 100);

            g.DrawArc(redPen, 400, 20, 50, 50, 90, 180);
            g.DrawPie(redPen, 400, 100, 50, 50, 210, 60);
            g.DrawPie(redPen, 400, 100, 50, 50, 270, 60);
            g.DrawPie(redPen, 400, 100, 50, 50, 330, 60);
        }
    }
}
