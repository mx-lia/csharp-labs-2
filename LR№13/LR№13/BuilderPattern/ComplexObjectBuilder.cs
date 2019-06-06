using LR_13.Factory;

namespace LR_13.BuilderPattern
{
    class ComplexObjectBuilder : Builder
    {
        private IAbstractFactory factoryRed = new FactoryRed();
        private IAbstractFactory factoryGreen = new FactoryGreen();

        public override void SetCircle()
        {
            ComplexObject.Circle = factoryRed.CreateCircle();
            ComplexObject.Circle.SetRadius(10);
        }

        public override void SetSquare()
        {
            ComplexObject.Square = factoryGreen.CreateSquare();
        }
    }
}
