using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Represents Cylinder Object inherits from 3D
    /// </summary>
    public class Cylinder : _3D
    {
        //Area formula: V = pi*r^2*h
        //Surface area: A = 2*pi*r*h + 2*pi*r^2
        public double Radius;
        public double Height;

        /// <summary>
        /// Represents a single Cylinder Object
        /// </summary>
        public Cylinder()
        {
            this.Type = "Cylinder";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Cylinder dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the Radius: ");
            this.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the Height: ");
            this.Height = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// User sets Data for Cylinder Area
        /// </summary>
        public override double CalculateVolume()
        {
            return Math.PI * (this.Radius * this.Radius) * this.Height;
        }

        /// <summary>
        /// User sets Data for Cylinder Volume
        /// </summary>
        public override double CalculateArea()
        {
            return (2.0 * Math.PI * this.Radius * this.Height) + (2.0 * Math.PI * (this.Radius * this.Radius));
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:11} {1,10:F2}  {2,10:F2} {3,5} R x {4,5} H", (object)this.Type, (object)this.CalculateArea(), (object)this.CalculateVolume(), (object) this.Radius, (object) this.Height);
        }
    }
}
