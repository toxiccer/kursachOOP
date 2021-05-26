﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Door : ElementBuild // тип двери, материал 
    {
        public string TypeDoor
        {
            get
            {
                return TypeDoor;
            }
            set
            {
                this.TypeDoor = value is string ? value : null;
            }
        }

        public string Materiald
        {
            get
            {
                return Materiald;
            }
            set
            {
                this.Materiald = value is string ? value : null;
            }
        }
        public Door(string name, double length, double height, double width, int x, int y, string typedoor, string materiald) : base(name, length, height, width, x, y)
        {
            this.TypeDoor = typedoor;
            this.Materiald = materiald;
        }
    }
}
