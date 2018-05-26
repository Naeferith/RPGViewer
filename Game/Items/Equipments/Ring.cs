using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Items.Equipments
{
    public class Ring : Equipment
    {
        public Ring(string label, Rarity rarity, int requiredLevel, List<Effect> effects) : base(label, rarity, Slot.Finger, requiredLevel, effects)
        {
        }
    }
}
