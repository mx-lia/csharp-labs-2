using LR_13.Prototype;
using System.Windows.Media;

namespace LR_13.Figure
{
    public interface ICircle : IFigure
    {
        int GetRadius();
        bool SetRadius(int radius);
        Color GetCirleColor();
    }
}
