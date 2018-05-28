using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Exceptions
{
    public class CellOccupiedException : RPGViewerException
    {
        public CellOccupiedException() : base("Someone or something is already standing on this cell.")
        {
        }
    }
}
