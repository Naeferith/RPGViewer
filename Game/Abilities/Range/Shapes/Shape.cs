using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities.Range.Shapes
{
    public abstract class Shape
    {

        private int _radius;

        protected Shape(int radius)
        {
            _radius = radius;
        }
    }
}
