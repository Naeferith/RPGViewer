using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public abstract class ElementalDot : Effect, IElemental
    {
        protected ElementalDot(Element element, int value, int nbTurns = -1) : base(value, nbTurns)
        {
            Element = element;
        }

        public Element Element { get; set; }

        public override string ToString()
        {
            string buffer = "Inflict " + (int)_value + " " + Element.ToString() + " damages";
            buffer += (TurnsLeft != -1) ? " during " + TurnsLeft + " turns." : ".";
            return buffer + " Save throw cancel.";
        }
    }
}
