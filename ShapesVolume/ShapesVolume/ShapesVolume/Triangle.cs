using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesVolume
{
    public class Triangle
    {
        private double baseSide;
        private double height;
        private double length;

        public Triangle(double baseSide, double height, double length)
        {
            this.baseSide = baseSide;
            this.height = height;
            this.length = length;
        }

        public double BaseSide { get => baseSide; }
        public double Height { get => height;}
        public double Length { get => length;}
    }
}
