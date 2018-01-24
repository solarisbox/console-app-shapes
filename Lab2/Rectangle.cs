using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Represents a Rectangle shape
    /// </summary>
    public class Rectangle : _2D
    {
        public double Length;
        public double Width;

        /// <summary>
        /// Represents a single Rectangle shape
        /// </summary>
        public Rectangle()
        {
            this.Type = "Rectangle";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Rectangle Dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            this.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            this.Width = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculate Surface Area of Rectangle Object
        /// </summary>
        public override double CalculateArea()
        {
            return this.Length * this.Width;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0,10} {1,08:F2}              {2,08:F2} L x {3,08:F2} W", (object)this.Type, (object)this.CalculateArea(), (object)this.Length, (object)this.Width);
        }
    }
}
