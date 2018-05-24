using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities.Range.Shape
{
    public abstract class RangeShape
    {

        private int _radius;

        protected RangeShape(int radius)
        {
            _radius = radius;
        }
    }
}
