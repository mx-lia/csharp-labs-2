using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LR_14_15.Composite
{
    public class Squad : ISelectableObject
    {
        private List<ISelectableObject> objects;
        private TextBlock _block;

        public Squad(TextBlock block)
        {
            _block = block;
            this.objects = new List<ISelectableObject>();
        }

        public Squad(TextBlock block, List<ISelectableObject> objects)
        {
            _block = block;
            this.objects = objects;
        }

        public void Add(ISelectableObject unit)
        {
            objects.Add(unit);
        }

        public void MoveTo(int x, int y)
        {
            foreach(var unit in objects)
            {
                unit.MoveTo(x, y);
            }
        }
    }
}
