using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexTraining
{
    public class CircleTreta
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        static readonly int RADIUS = 5;
        int radius;

        public bool isClicked, isPulsing, missedTiming;

        Brush brush, brushClicked;

        public CircleTreta(int X, int Y)
        {
            radius = RADIUS;
            brush = new SolidBrush(Color.Red);
            this.positionX = X;
            this.positionY = Y;
            isClicked = false;
            isPulsing = true;
            missedTiming = false;
        }

        public void Draw(Graphics g)
        {
            if (!isClicked)
                g.FillEllipse(brush, positionX - radius, positionY - radius, radius * 2, radius * 2);
            else
                g.FillEllipse(brushClicked, positionX - radius, positionY - radius, radius * 2, radius * 2);
        }

        public bool Clicked(float x, float y)
        {
            double d = Math.Sqrt((positionX - x) * (positionX - x) + (positionY - y) * (positionY - y));
            return d <= radius;
        }

        public void Pulse()
        {
            if (isPulsing)
            {
                radius += 1;
                if (radius >= RADIUS * (1 + 150 / 100.0))
                {
                    isPulsing = false;
                }
            }
            else
            {
                radius -= 1;
                if (radius <= 3)
                {
                    brush = brushClicked;
                    if (!isClicked)
                        missedTiming = true;
                }
            }
        }

        public bool timeToBeRemoved()
        {
            if (radius <= 3 && !isClicked)
                return true;
            else
                return false;
        }

        public void changeBrush(Color color)
        {
            brushClicked = new SolidBrush(color);
        }
    }
}
