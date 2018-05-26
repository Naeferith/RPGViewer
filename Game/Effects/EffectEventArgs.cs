using RPGViewer.Game.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public class EffectEventArgs : EventArgs
    {
        public Mob Caster { get; set; }
        public Mob Target { get; set; }
        public int Damage { get; set; }
    }
}
