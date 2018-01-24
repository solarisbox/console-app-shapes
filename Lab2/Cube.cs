using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Represents a Cube inherit from Box
    /// </summary>
    public class Cube : Box
    {
        /// <summary>
        /// Represents a single Cube shape
        /// </summary>
        public Cube()
        {
            this.Type = "Cube";
        }
        
        /// <summary>
        /// User sets Data for Cube Dimensions
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("\nEnter Length: ");
            this.Length = Convert.ToDouble(Console.ReadLine());
            this.Width = this.Length;
            this.Height = this.Length;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:10}    {1,10:F2}      {2:F2}    {3:F2} L", (object) this.Type, (object) this.CalculateArea(), (object) this.CalculateVolume(), (object) this.Length);
        }
    }
}
