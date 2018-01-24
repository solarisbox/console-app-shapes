using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *I, Salvador Valle, #000322660 certify that this material is my original work. 
 *No other person's work has been used without due acknowledgement.
 * 
 * Purpose: The purpose of this lab is to calculate the area (Surface area if 3-D and volume ) of a shape. 
 * Before the user exits the program will display all the shapes in the array.
 * 
 * Date: 19/02/2016
 */
namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
            Shape[] shapeArray = new Shape[100]; //Array for Shapes.
            string userInput;                    //String User Input

            do
            {
                userInput = Lab2.Options();
                Lab2.CreateShape(shapeArray, userInput);
            }
            while(userInput != "0");
            Lab2.Display(shapeArray);
            System.Threading.Thread.Sleep(10000);
        }

        /// <summary>
        /// Creates shape from User Input
        /// </summary>
        private static void CreateShape(Shape[] shapes, string choice)
        {
            switch (choice)
            {
                case "A":
                case "a":
                    shapes[Shape.GetCount()] = (Shape)new Rectangle();
                    break;
                case "B":
                case "b":
                    shapes[Shape.GetCount()] = (Shape)new Square();
                    break;
                case "C":
                case "c":
                    shapes[Shape.GetCount()] = (Shape)new Box();
                    break;
                case "D":
                case "d":
                    shapes[Shape.GetCount()] = (Shape)new Cube();
                    break;
                case "E":
                case "e":
                    shapes[Shape.GetCount()] = (Shape)new Ellipse();
                    break;
                case "F":
                case "f":
                    shapes[Shape.GetCount()] = (Shape)new Circle();
                    break;
                case "G":
                case "g":
                    shapes[Shape.GetCount()] = (Shape)new Cylinder();
                    break;
                case "H":
                case "h":
                    shapes[Shape.GetCount()] = (Shape)new Sphere();
                    break;
                case "I":
                case "i":
                    shapes[Shape.GetCount()] = (Shape)new Triangle();
                    break;
                case "J":
                case "j":
                    shapes[Shape.GetCount()] = (Shape)new Tetrahedron();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter a valid letter from the option list...");
                    Console.Write("Press any key to continue... ");
                    Console.ReadKey();
                    break;
            }
        }

        /// <summary>
        /// Display input options for user.
        /// </summary>
        private static string Options()
        {
            Console.Clear();
            Console.WriteLine("Salvador's Geometry Class");
            Console.WriteLine("A - Rectangle     E - Ellipse     I - Triangle");
            Console.WriteLine("B - Square        F - Circle      J - Tetrahedron");
            Console.WriteLine("C - Box           G - Cylinder");
            Console.WriteLine("D - Cube          H - Sphere");
            Console.WriteLine("\n 0 - List all shapes and Exit...");
            Console.Write("\n\t\t\t({0} shape{1} entered so far)\rEnter your choice: ", (object)Shape.GetCount(), Shape.GetCount() == 1 ? (object)"" : (object)"s");
            string str = Console.ReadLine();
            Console.WriteLine();
            return str;
        }

        /// <summary>
        /// Display all the shapes in the Array
        /// </summary>
        private static void Display(Shape[] shapeArray)
        {
            Console.Clear();
            Console.WriteLine("Salvador's Geometry Class:");
            Console.WriteLine("\nThere {0} {1} object{2}:\n", Shape.GetCount() == 1 ? (object)"is" : (object)"are", (object)Shape.GetCount(), Shape.GetCount() == 1 ? (object)"" : (object)"s");
            if (Shape.GetCount() == 0)
                return;
            Console.WriteLine("Shape       Area       Volume     Details");
            Console.WriteLine("=========== ========== ========== =================================");
            for (int index = 0; index < shapeArray.Length && shapeArray[index] != null; ++index)
                Console.WriteLine((object)shapeArray[index]);
            Console.WriteLine();
        }
        
    }
}
