﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public sealed class EntRoom : Room
    {
        private string NextRoom;
        public string thisNextRoom
        {
            get
            {
                return this.NextRoom;
            }
            set
            {
                this.NextRoom = value is string ? value : null;
            }
        }
        public EntRoom(string number, string name, string length, string height, string width, string x, string y, string purpose, string typeoffin, string doorcode, string windowcode, string nextroom) : base(number, name, length, height, width, x, y, purpose, typeoffin, doorcode, windowcode)
        {
            this.NextRoom = nextroom;
        }
    }
}
