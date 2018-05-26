using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Items
{
    public interface IStackable
    {
        int Quantity { get; set; }

        int Divide(int quantity);

        int Assemble(int quantity);

    }
}
