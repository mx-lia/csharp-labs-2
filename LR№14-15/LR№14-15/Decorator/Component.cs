using System.Windows.Controls;

namespace LR_14_15.Decorator
{
    public abstract class Component
    {
        protected TextBlock _block;

        public Component(TextBlock block)
        {
            _block = block;
        }
    }
}
