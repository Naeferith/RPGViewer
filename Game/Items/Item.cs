using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Items
{
    public abstract class Item
    {
        private string _label;

        private Rarity _rarity;

        protected Item(string label, Rarity rarity)
        {
            _label = label;
            _rarity = rarity;
        }
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
}
