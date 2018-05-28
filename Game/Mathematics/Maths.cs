using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Mathematics
{
    public static class Maths
    {
        public static Orientation GetOppositeOrientation(Orientation orientation) => (Orientation)(~((byte)orientation | 0b11111100));
    }
}
