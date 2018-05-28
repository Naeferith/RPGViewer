using RPGViewer.Game.Abilities.Range.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities.Range
{
    public class Melee : Scope
    {
        public Melee() : base(1, new Line(1))
        {
        }

        public override string ToString()
        {
            return "Melee";
        }
    }
}
