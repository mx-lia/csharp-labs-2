using LR_13.Figure;

namespace LR_13.Factory
{
    interface IAbstractFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();
    }
}
