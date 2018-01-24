using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Represents a single Triangle shape inherits from 2D
    /// </summary>
    public class Triangle : _2D
    {
        //A = (b * h) / 2

        public double Base;
        public double Height;
        
        /// <summary>
        /// Represents a single Triangle shape
        /// </summary>
        public Triangle()
        {
            this.Type = "Triangle";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Cube Dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the Base: ");
            this.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Height: ");
            this.Height = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculate Surface Area of Triangle Shape Object
        /// </summary>
        public override double CalculateArea()
        {
            return (this.Base * this.Height) / 2.0;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,10:F2}                 {2:F2} B x {3:F2} H", (object)this.Type, (object)this.CalculateArea(), (object)this.Base, (object)this.Height);
        }
    }
}
