using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPGViewer.Game.Abilities.Range.AbilityRange;

namespace RPGViewer.Game.Abilities.Range
{
    public interface IOrientable
    {
        Orientation Orientation { get; set; }
        
    }
}
