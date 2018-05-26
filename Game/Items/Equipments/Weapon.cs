using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Items.Equipments
{
    public abstract class Weapon : Equipment
    {
        private readonly Kind _kind;
        private int _lowerDamage;
        private int _higherDamage;

        protected Weapon(string label, Rarity rarity, Slot slot, int requiredLevel, List<Effect> effects, Kind kind) : base(label, rarity, slot, requiredLevel, effects)
        {
            _kind = kind;
        }
    }

    public enum Kind
    {
        Sword,
        Axe,
        Staff,
        Shield,
        Hammer,
        Dagger,
        Bow
    }
}
