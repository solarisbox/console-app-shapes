using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Circle : _2D
    {
        public double Radius;

        /// <summary>
        /// Represents a Circle Shape inherits from 2D shape
        /// </summary>
        public Circle()
        {
            this.Type = "Circle";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Circle Radius
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the Radius of Circle: ");
            this.Radius = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculates Circle Area
        /// </summary>
        public override double CalculateArea()
        {
            return 0.5 * (2 * Math.PI * Radius) * Radius;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:11}   {1,10:F2}                {2:F2} R ", (object) this.Type, (object) this.CalculateArea(), (object) this.Radius);
        }
    }
}
