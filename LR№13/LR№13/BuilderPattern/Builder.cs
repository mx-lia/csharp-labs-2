namespace LR_13.BuilderPattern
{
    public abstract class Builder
    {
        public ComplexObject ComplexObject { get; private set; }

        public void CreateComplexObject()
        {
            ComplexObject = new ComplexObject();
        }

        public abstract void SetCircle();
        public abstract void SetSquare();
    }
}
