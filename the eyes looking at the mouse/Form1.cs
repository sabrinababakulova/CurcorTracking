using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_eyes_looking_at_the_mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point pointX = rightEye.PointToScreen(Point.Empty);
            Point pointY = rightEye.PointToScreen(Point.Empty);
            Point leftX = leftEye.PointToScreen(Point.Empty);
            Point leftY = leftEye.PointToScreen(Point.Empty);
            int X = 4; // the move


            if (Cursor.Position.X <= pointX.X && rightEye.Left != 0)
            {
                rightEye.Left -= X;
            }
            if(Cursor.Position.Y <=pointY.Y && rightEye.Top != 0)
            {
                rightEye.Top -= X;
            }
            if(Cursor.Position.X >=pointX.X && rightEye.Left != 32)
            {
                rightEye.Left += X;
            }
            if (Cursor.Position.Y >= pointY.Y && rightEye.Top != 24) rightEye.Top += X;



            //left Eye that is right eye
            if (Cursor.Position.X <= leftX.X && leftEye.Left != 0)
            {
                leftEye.Left -= X;
            }
            if (Cursor.Position.Y <= leftY.Y && leftEye.Top != 0)
            {
                leftEye.Top -= X;
            }
            if (Cursor.Position.X >= leftX.X && leftEye.Left != 32)
            {
                leftEye.Left += X;
            }
            if (Cursor.Position.Y >= leftY.Y && leftEye.Top != 24) leftEye.Top += X;




        }


    }
}
