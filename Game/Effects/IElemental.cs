using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public interface IElemental
    {
        Element Element { get; set; }
    }

    public enum Element
    {
        Fire,
        Ice,
        Poison,
        Shadow,
        Light
    }
}
