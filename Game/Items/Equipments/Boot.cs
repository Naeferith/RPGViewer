using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Items.Equipments
{
    public class Boot : ArmorEquipment
    {
        public Boot(string label, Rarity rarity, Slot slot, int requiredLevel, List<Effect> effects, int armor) : base(label, rarity, Slot.Foot, requiredLevel, effects, armor)
        {
        }
    }
}
