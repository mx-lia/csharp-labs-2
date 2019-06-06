using System;
using System.Windows;
using System.Windows.Media;

namespace LR_13.Singleton
{
    class GoldenObject
    {
        private PointCollection points;
        private readonly Color color = Color.FromRgb(0, 0, 255);
        private static GoldenObject goldenObject;

        private GoldenObject()
        {
            points = new PointCollection();
            points.Add(new Point(0, 50));
            points.Add(new Point(50, 0));
            points.Add(new Point(0, 0));
        }

        public static GoldenObject GetInstance()
        {
            if(goldenObject == null)
            {
                goldenObject = new GoldenObject();
            }
            else
            {
                throw new Exception();
            }
            return goldenObject;
        }

        public PointCollection GetPoints()
        {
            return points;
        }

        public Color GetColor()
        {
            return color;
        }
    }
}
