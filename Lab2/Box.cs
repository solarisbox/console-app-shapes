using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *I, Salvador Valle, #000322660 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 * Purpose: The purpose of this lab is to calculate the area (Surface area if 3-D) and volume of a shape. 
 */
namespace Lab2
{
    public class Box : _3D
    {
        public double Length;
        public double Width;
        public double Height;

        /// <summary>
        /// Represents a single Box shape
        /// </summary>
        public Box()
        {
            this.Type = "Box";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Box Dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            this.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            this.Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height: ");
            this.Height = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculate Surface Area of Box Object
        /// </summary>
        public override double CalculateArea()
        {
            return (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height) * 2.0;
        }

        /// <summary>
        /// Calculate Volume of Box Object
        /// </summary>
        public override double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:C10}      {1,10:F2} {2,10:F2}     {3:F2} l x {4:F2} W x {5:F2} H", (object)this.Type, (object)this.CalculateArea(), (object)this.CalculateVolume(), (object)this.Length, (object)this.Width, (object)this.Height);
        }
    }
}
