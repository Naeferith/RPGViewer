using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Abilities.Range.Shape;

namespace RPGViewer.Game.Abilities.Range
{
    public class Discharge : AbilityRange, IOrientable
    {
        private Orientation _orientation;

        public Orientation Orientation { get { return _orientation; } set { _orientation = value; } }

        public Discharge(int radius) : base(0, new BoxShape(radius))
        {
        }

        
    }
}
