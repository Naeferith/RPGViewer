using RPGViewer.Game.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Items.Equipments
{
    public abstract class Equipment : Item, IEquipable
    {
        /// <summary>
        /// The place where the <see cref="Equipment"/> belongs to
        /// </summary>
        private readonly Slot _slot;

        private readonly int _requiredLevel;

        /// <summary>
        /// Contains all the effects of the item
        /// </summary>
        protected List<Effect> _effects;

        protected Equipment(string label, Rarity rarity, Slot slot, int requiredLevel, List<Effect> effects) : base(label, rarity)
        {
            _slot = slot;
            _requiredLevel = requiredLevel;
            _effects = effects;
        }

        public virtual void Equip(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public virtual void Unequip(Equipment equipment)
        {
            throw new NotImplementedException();
        }
    }

    public enum Slot
    {
        /// <summary>
        /// This item can be stored as a one-handed weapon
        /// </summary>
        WeaponLeft,

        /// <summary>
        /// This item can be stored as a one-handed weapon
        /// </summary>
        WeaponRight,

        /// <summary>
        /// This item can be stored as a two-handed weapon
        /// </summary>
        WeaponDouble,

        /// <summary>
        /// This item can be stored as helmet
        /// </summary>
        Head,

        /// <summary>
        /// This item can be stored as shoulder protection
        /// </summary>
        Shoulder,

        /// <summary>
        /// This item can be stored as armor
        /// </summary>
        Body,

        /// <summary>
        /// This item can be stored as gloves
        /// </summary>
        Hand,

        /// <summary>
        /// This item can be stored as ring
        /// </summary>
        Finger,

        /// <summary>
        /// This item can be stored as a scarf
        /// </summary>
        Waist,

        /// <summary>
        /// This item can be stored as leg protection
        /// </summary>
        Legs,

        /// <summary>
        /// This item can be stored as boots
        /// </summary>
        Foot
    }
}
