using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Sphere Class inherits from 3D class
    /// </summary>
    public class Sphere : _3D
    {
        public double Radius;
        //V = 4/3 * PI * r^3
        //A=4πr^2

        /// <summary>
        /// Represents a Sphere shape object
        /// </summary>
        public Sphere()
        {
            this.Type = "Sphere";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Sphere Radius
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("\nEnter the Radius");
            this.Radius = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculates Sphere Surface Area
        /// </summary>
        public override double CalculateArea()
        {
            return 4.0 * Math.PI * (this.Radius * this.Radius);
        }

        /// <summary>
        /// Calculates Sphere Volume
        /// </summary>
        public override double CalculateVolume()
        {
            return 4.0 / 3.0 * Math.PI * (this.Radius * this.Radius * this.Radius);
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:C11}   {1,10:F2}    {2:F2}     {3:F2} R", (object) this.Type, (object) this.CalculateArea(), (object) this.CalculateVolume(), (object) this.Radius);
        }
    }
}
