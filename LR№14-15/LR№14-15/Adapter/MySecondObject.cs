using System;
using System.Windows.Controls;

namespace LR_14_15.Adapter
{
    class MySecondObject : ISecondObject
    {
        private TextBlock block;

        public MySecondObject(TextBlock block)
        {
            this.block = block;
        }

        public void MoveTo(int x, int y, int z)
        {
            block.Text += $"MyObject move to {x}, {y}, {z}\n";
        }
    }
}
