using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPGViewer.Game.Abilities.Range.Scope;

namespace RPGViewer.Game
{
    public interface IOrientable
    {
        Orientation Orientation { get; set; }
        
    }

    public enum Orientation : byte
    {
        North = 0b00,
        East  = 0b01,
        West  = 0b10,
        South = 0b11
    }
}
