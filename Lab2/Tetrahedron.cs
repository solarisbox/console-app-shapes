using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // V = a^3 / 6root2
    // A = root 3a^2

    /// <summary>
    /// Represents Tetrahedron Object inherits from 3D
    /// </summary>
    public class Tetrahedron : _3D
    {
        public double Length;

        /// <summary>
        /// Represents single Tetrahedron object
        /// </summary>
        public Tetrahedron()
        {
            this.Type = "Tetrahedron";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Tetrahedron dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the Length: ");
            this.Length = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculates Tetrahedron Area
        /// </summary>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (this.Length * this.Length);
        }

        /// <summary>
        /// Calculates Tetrahedron Volume
        /// </summary>
        public override double CalculateVolume()
        {
            return (this.Length * this.Length * this.Length) / (6 * Math.Sqrt(2));
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:C10}  {1,02:F2}    {2,01:F2}      {3,03:F2} L", (object)this.Type, (object)this.CalculateArea(), (object) this.CalculateVolume(), (object)this.Length);
        }
    }
}
