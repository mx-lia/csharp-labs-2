using System.Windows.Media;
using LR_13.Prototype;

namespace LR_13.Figure
{
    class CircleGreen : ICircle
    {
        private readonly Color circleColor = Color.FromRgb(0, 255, 0);
        private int radius;

        public CircleGreen()
        {
            radius = 25;
        }

        public IFigure Clone()
        {
            return new CircleGreen();
        }

        public Color GetCirleColor()
        {
            return circleColor;
        }

        public int GetRadius()
        {
            return radius;
        }

        public bool SetRadius(int radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
