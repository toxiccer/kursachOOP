﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public sealed class ClRoom : Room
    {
        public ClRoom(string number, string name, string length, string height, string width, string x, string y, string purpose, string typeoffin, string doorcode, string windowcode) : base(number, name, length, height, width, x, y, purpose, typeoffin, doorcode, windowcode)
        {

        }
    }
}
