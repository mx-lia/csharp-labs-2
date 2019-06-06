using LR_14_15.Composite;

namespace LR_14_15.Adapter
{
    class ISecondbjectToISelectableAdapter : ISelectableObject
    {
        private MySecondObject obj;

        public ISecondbjectToISelectableAdapter(MySecondObject obj)
        {
            this.obj = obj;
        }

        public void MoveTo(int x, int y)
        {
            obj.MoveTo(x, y, 0);
        }
    }
}
