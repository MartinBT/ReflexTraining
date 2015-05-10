using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexTraining
{
    public class Circle
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        static readonly int RADIUS = 15;

        public bool isClicked;

        Brush brush, brushClicked;

        public Circle(int X, int Y)
        {
            brush = new SolidBrush(Color.Red);
            this.positionX = X;
            this.positionY = Y;
            isClicked = false;
        }

        public void Draw(Graphics g)
        {
            if (!isClicked)
                g.FillEllipse(brush, positionX - RADIUS, positionY - RADIUS, RADIUS * 2, RADIUS * 2);
            else
                g.FillEllipse(brushClicked, positionX - RADIUS, positionY - RADIUS, RADIUS * 2, RADIUS * 2);
        }

        public bool Clicked(float x, float y)
        {
            double d = Math.Sqrt((positionX - x) * (positionX - x) + (positionY - y) * (positionY - y));
            return d <= RADIUS;
        }

        public void changeBrush(Color color)
        {
            brushClicked = new SolidBrush(color);
        }

        public void changeToRed()
        {
            brush = new SolidBrush(Color.Red);
        }

        public void changeToYellow()
        {
            brush = new SolidBrush(Color.Yellow);
        }

        public Color GetColor()
        {
            return new Pen(brush).Color;
        }

        public void changePosition(int x, int y)
        {
            positionX = x;
            positionY = y;
        }
    }
}
