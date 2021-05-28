﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class ElementBuild
    {
        public string Name
        {
            get { return Name; }
            set { this.Name = value is string ? value : null; }
        }
        public double Length
        {
            get
            {
                return Length;
            }
            set
            {
                this.Length = value;
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            set
            {
                this.Height = value;
            }
        }
        public double Width
        {
            get
            {
                return Width;
            }
            set
            {
                this.Width = value;
            }
        }
        public int X
        {
            get
            {
                return X;
            } 
            set
            {
                this.X = value;
            }
        }
        public int Y
        {
            get
            {
                return Y;
            }
            set
            {
                this.Y = value;
            }
        }

        public ElementBuild(string name, double length, double height, double width, int x, int y)
        {
            this.Name = name;
            this.Length = length;
            this.Height = height;
            this.Width = width;
            this.X = x;
            this.Y = y;
        }
    }
 
    
}