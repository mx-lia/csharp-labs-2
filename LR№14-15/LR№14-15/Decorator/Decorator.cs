using System.Windows.Controls;

namespace LR_14_15.Decorator
{
    class Decorator : Component
    {
        protected Component component;

        public Decorator(TextBlock block, Component component) : base(block)
        {
            this.component = component;
        }
    }
}
