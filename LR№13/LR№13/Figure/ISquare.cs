using LR_13.Prototype;
using System.Windows.Media;

namespace LR_13.Figure
{
    public interface ISquare : IFigure
    {
        int GetSideSize();
        bool SetSideSize(int sideSize);
        Color GetSqureColor();
    }
}
