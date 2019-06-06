using System.Windows.Media;
using LR_13.Prototype;

namespace LR_13.Figure
{
    class CircleRed : ICircle
    {
        private readonly Color circleColor = Color.FromRgb(255, 0, 0);
        private int radius;

        public CircleRed()
        {
            radius = 25;
        }

        public IFigure Clone()
        {
            return new CircleRed();
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
