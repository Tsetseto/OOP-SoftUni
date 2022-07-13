﻿namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        private double radius;


        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            private set
            {
                radius = value;
            }
        }


        public override double CalculateArea()
        {
            return (Math.PI * Math.Pow(this.Radius, 2));
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public sealed override string Draw()
        {
            return $"{base.Draw()} Circle";
        }
    }
}