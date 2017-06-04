using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Name: Vitaliy Shahanyants
    /// Date: 16/02/2017
    /// Project: Lab 2
    /// 
    /// Purpose: The purpose of this program is to use polymorphism with abstract Shape class calculate area for 2d and calculcate area and volume of 3d objects.
    /// 
    /// Polymorphism: I was givin a abtract class called Shape, and I had to create the following classes 
    ///     Rectangle
    ///     Square
    ///     Box
	///     Cube
	///     Ellipse
	///     Circle
	///     Cylinder
	///     Sphere
	///     Triangle
	///     Tetrahedron
    /// To use polymorphism, I grouped these classes with the following classes
    ///     SquareShape (Rectangle,Square,Box,Cube)
    ///     CircleShape (Ellipse,Circle,Cylinder,Cylinder)
    ///     TriangleShape (Triangle,Tetrahedron)
    /// 
    /// Explanation: in this class, I get user input decide which shape user wish to do the calculation and I store it to the object array Shape instance of an abstract class Shape
    ///                 after the user ends the program, I show the table witht the chosen shapes and calculations, user input history.
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Program
    {
        private static string userInput = "";//Meant to store user's input such as  (A,B,C,D,E,F,G,H,I,J)
        private static Shape[] shape = new Shape[100];//abstract object array, a collection of user input using polymorphism
        private static bool usertInputResult = true;//A boolean to check wether the user entered 0 to end the program

        static void Main(string[] args)
        {
            ShowMenu();
        }
        /// <summary>
        /// ShowMenu: Method meant to loop, and each time show menu and ask user for input, until 0 is entered 
        /// </summary>
        private static void ShowMenu()
        {
            while (usertInputResult)
            {
                Menu();
            }
            //Checks if user calculated any shape's area or volume
            if(Shape.GetCount() > 0)
                ShowTable();//Displays table with user's choices (Shape, Area,Valume, and Details)
            Console.Write("\nPress Key to Exit...");
            Console.ReadKey();
        }
        /// <summary>
        /// ShowTable: Displays table with user's choices (Shape, Area,Valume, and Details), and loops through the global private object array 
        /// </summary>
        private static void ShowTable()
        {
            Console.Clear();
            WriteName();//Writes the Authors name
            Console.WriteLine("There is {0} object:",Shape.GetCount());
            Console.WriteLine("{0,-11}\t{1,-10}\t{2,-10}\t{3,-45}", "Shape","Area","Volume","Detail");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", 
                string.Concat(Enumerable.Repeat("=", 11)),
                string.Concat(Enumerable.Repeat("=", 10)),
                string.Concat(Enumerable.Repeat("=", 10)),
                string.Concat(Enumerable.Repeat("=", 45) ));
            foreach(Shape oneShape in shape)
            {
                if(oneShape != null)
                    Console.WriteLine(oneShape);
            }
        }
        /// <summary>
        /// WriteName: Displays the developer's name and project name
        /// </summary>
        private static void WriteName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vitaliy's Geometry Class:");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Menu: Displays the menu for user's to choose
        /// </summary>
        private static void Menu()
        {
            WriteName();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t\t{7}\n{8}\t{9}\n",
                              "A - Rectangle", "E - Ellipse", "I - Triangle",
                              "B - Square", "F - Circle", "J - Tetrahedron",
                              "C - Box", "G - Cylinder",
                              "D - Cube", "H - Sphere");
            Console.WriteLine("0 - List all shapes and Exit...");
            Console.ForegroundColor = ConsoleColor.White;

            UserInput();
            if (usertInputResult)
                Console.Clear();
        }
        /// <summary>
        /// UserInput: Promts the user for input
        /// </summary>
        private static void UserInput()
        {
            Console.Write("{0}", "Enter your choice: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\t({0} shapes entered so far) ", Shape.GetCount());
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(19, 7);// sets the cursor in between "Enter your choice: " and "  shapes entered so far) "
            userInput = Console.ReadLine();
            Console.WriteLine();
            ShapeChoice();
        }
        /// <summary>
        /// ShapeChoice: Checks what shapes user choose
        /// </summary>
        private static void ShapeChoice()
        {
            int shapesCounter = Shape.GetCount();//
            bool result = true;//
            bool wrongInput = false;//
            switch (userInput.ToUpper())
            {
                case "A":
                    shape[shapesCounter] = new Rectangle();
                    break;
                case "B":
                    shape[shapesCounter] = new Square();
                    break;
                case "C":
                    shape[shapesCounter] = new Box();
                    break;
                case "D":
                    shape[shapesCounter] = new Cube();
                    break;
                case "E":
                    shape[shapesCounter] = new Ellipse();
                    break;
                case "F":
                    shape[shapesCounter] = new Circle();
                    break;
                case "G":
                    shape[shapesCounter] = new Cylinder();
                    break;
                case "H":
                    shape[shapesCounter] = new Sphere();
                    break;
                case "I":
                    shape[shapesCounter] = new Triangle();
                    break;
                case "J":
                    shape[shapesCounter] = new Tetrahedron();
                    break;
                case "0":
                    result = false;
                    break;
                default:
                    WrongChoice();
                    wrongInput = true;
                    break;
            }
            if (result && !wrongInput)
                shape[shapesCounter].SetData();
            usertInputResult = result;

        }
        /// <summary>
        /// WrongChoice: Displays to users that they entered incorrect input 
        /// </summary>
        private static void WrongChoice()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is not a valid choice, please try again");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
