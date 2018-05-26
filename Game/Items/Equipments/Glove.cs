using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Items.Equipments
{
    public class Glove : ArmorEquipment
    {
        public Glove(string label, Rarity rarity, int requiredLevel, List<Effect> effects, int armor) : base(label, rarity, Slot.Hand, requiredLevel, effects, armor)
        {
        }
    }
}
