using LR_13.Figure;

namespace LR_13.Factory
{
    class FactoryGreen : IAbstractFactory
    {
        public FactoryGreen()
        {

        }

        public ICircle CreateCircle()
        {
            return new CircleGreen();
        }

        public ISquare CreateSquare()
        {
            return new SquareGreen();
        }
    }
}
