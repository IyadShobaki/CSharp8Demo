using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public struct Rectangle
    {
        public double Length { get; set; }
        //public double Height { get; set; }
        //we can do
        private double _height;

        public double Height
        {
            readonly get { return _height; }
            set { _height = value; }
        }



        public readonly double Area()
        {
            return Length * Height;
        }
    }
}
