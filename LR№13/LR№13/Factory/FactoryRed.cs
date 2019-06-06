using LR_13.Figure;

namespace LR_13.Factory
{
    class FactoryRed : IAbstractFactory
    {
        public FactoryRed()
        {

        }

        public ICircle CreateCircle()
        {
            return new CircleRed();
        }

        public ISquare CreateSquare()
        {
            return new SquareRed();
        }
    }
}
