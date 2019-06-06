using System.Windows.Media;
using LR_13.Prototype;

namespace LR_13.Figure
{
    class SquareRed : ISquare
    {
        private int sideSize;
        private readonly Color color = Color.FromRgb(255, 0, 0);

        public SquareRed()
        {
            sideSize = 50;
        }

        public int GetSideSize()
        {
            return sideSize;
        }

        public Color GetSqureColor()
        {
            return color;
        }

        public bool SetSideSize(int sideSize)
        {
            if (sideSize > 0)
            {
                this.sideSize = sideSize;
                return true;
            }
            else
            {
                return false;
            }
        }

        public IFigure Clone()
        {
            return new SquareRed();
        }
    }
}
