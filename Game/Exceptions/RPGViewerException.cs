using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Exceptions
{
    public class RPGViewerException : Exception
    {
        public RPGViewerException()
        {
        }

        public RPGViewerException(string message) : base(message)
        {
        }

        public RPGViewerException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
