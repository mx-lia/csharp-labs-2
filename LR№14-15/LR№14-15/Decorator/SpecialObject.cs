using System.Windows.Controls;

namespace LR_14_15.Decorator
{
    class SpecialObject : Decorator
    {
        public string Text { get; set; }

        public SpecialObject(TextBlock block, Component component, string text) : base(block, component)
        {
            Text = text;
        }


    }
}
