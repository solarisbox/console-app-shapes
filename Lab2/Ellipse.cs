using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Ellipse : _2D
    {
        public double CoVertex;
        public double Vertex;

        /// <summary>
        /// Represents a single Ellipse shape
        /// </summary>
        public Ellipse()
        {
            this.Type = "Ellipse";
            this.SetData();
        }

        /// <summary>
        /// User sets Data for Rectangle Dimensions
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the Co-Vertex axis length: ");
            this.CoVertex = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the Vertex axis length: ");
            this.Vertex = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculate Surface Area of Rectangle Object
        /// </summary>
        public override double CalculateArea()
        {
            return Math.PI * this.CoVertex * this.Vertex;
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:11}  {1,10:F2}                 {2:F2} CoVertex {3:F2} Vertex", (object) this.Type, (object) this.CalculateArea(), (object) this.CoVertex, (object) this.Vertex);
        }
    }
}
