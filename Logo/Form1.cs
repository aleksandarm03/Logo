using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Graphics g;
        Pen o = new Pen(Color.SkyBlue);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x ,y;
            for (x = 160; x <= 200; x++)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o,x,y,x+1,y);
                    continue;
                }
            }
            timer1.Stop();
            timer2.Start();
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x, y ;
            for (x = 350; x >= 310; x--)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y + 1);
                    continue;
                }
            }
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int x , y ;
            for ( y = 11; y < 51;y++ )
            {
                for (x = 200; x <= 310; x++)
                {
                    g.DrawLine(o, x, y, x+1, y);
                    continue;
                }
            }             
          timer3.Stop();
          timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int x , y ;
            for ( y = 220; y > 180;y-- )
            {
                for (x = 200; x <= 310; x++)
                {
                    g.DrawLine(o, x, y, x+1, y);
                    continue;
                }
            }             
          timer4.Stop();
          timer5.Start();
          o.Color = Color.YellowGreen;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int x , y ;
            for (x = 410; x <= 450; x++)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y);
                    continue;
                }
            }
            timer5.Stop();
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int x , y ;
            for (x = 650; x >= 610; x--)
            {
                for (y = 290; y > 10; y--)
                {
                    g.DrawLine(o, x, y, x + 1, y + 1);
                    continue;
                }
            }
            timer6.Stop();
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            for (int y = 10; y <= 80; y++)
            {
                g.DrawLine(o, 290+160, y, 370+160, y + 170);
                g.DrawLine(o, 370+160, y+170, 450+160, y);
            }
            timer7.Stop();
            timer8.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor=Color.Black;
        }
        int i = 100;
        private void timer8_Tick(object sender, EventArgs e)
        {
            
            i--;
            if (i == 65) label1.ForeColor = Color.Red;
            if (i == 33) label1.ForeColor = Color.Blue;
            if (i == 0)
            {
                label1.ForeColor = Color.White;
                timer8.Stop();
            }
        }
        
       
        
    }
}
