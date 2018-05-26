using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Items.Equipments
{
    public class ArmorEquipment : Equipment
    {
        private int _armor;

        protected ArmorEquipment(string label, Rarity rarity, Slot slot, int requiredLevel, List<Effect> effects, int armor) : base(label, rarity, slot, requiredLevel, effects)
        {
            _armor = armor;
        }
    }
}
