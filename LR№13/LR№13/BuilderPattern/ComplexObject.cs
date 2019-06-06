using LR_13.Figure;

namespace LR_13.BuilderPattern
{
    public class ComplexObject
    {
        public ICircle Circle { get; set; }
        public ISquare Square { get; set; }

        public ComplexObject()
        {

        }
    }
}
