﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    interface IMutable<T>
    {
        void Edit(T deltaObject);
    }
}
