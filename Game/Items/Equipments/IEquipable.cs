using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Items.Equipments
{
    public interface IEquipable
    {
        void Equip(Equipment equipment);

        void Unequip(Equipment equipment);
    }
}
