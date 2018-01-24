using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
    
{
    /// <summary>
    /// Represents a Square inherit from Rectangle
    /// </summary>
    public class Square : Rectangle
    {

        /// <summary>
        /// Represents a single Square shape
        /// </summary>
        public Square()
       {
            this.Type = "Square";
        }

        /// <summary>
        /// Return String with dimensions and Calculated Values
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0:C11}   {1,10:F2}               {2:F2} Length", (object)this.Type, (object)this.CalculateArea(), (object)this.Length);
        }
    }
}
