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
    /// Class Name: CircleShape
    /// Inherents: Abstract Shhape Class
    /// 
    /// Purpose: Is meant to group Circular Shapes
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class CircleShape : Shape
    {
        public double Major { get; protected set; }
        public double Minor { get; protected set; }
        public double Height { get; protected set; }
        public double Radius { get; protected set; }
        public bool ThirdDimentionalObject { get; protected set; }
        public double AreaCalculation { get; private set; }
        public double VolumeCalculation { get; private set; }

        public CircleShape() : base() { }
        /// <summary>
        /// SetData: Check which class overrides this method, if it's 2d, or 3d Shape class, and preforms the calculations
        /// </summary>
        public override void SetData()
        {
            if (ThirdDimentionalObject)
            {
                AreaCalculation = CalculateArea();
                VolumeCalculation = CalculateVolume();
            }
            else
            {
                AreaCalculation = CalculateArea();
            }
            //Draw();
        }
        /// <summary>
        /// CalculateArea: Calculates Area 
        /// </summary>
        /// <returns>Double calculated Area</returns>
        public override double CalculateArea()
        {
            return (2 * Shape.PI * Radius * Height) +(2 * Shape.PI * (Radius*Radius));
        }
        /// <summary>
        /// CalculateVolume: Calculates Volume 
        /// </summary>
        /// <returns>Double calculated Volume</returns>
        public override double CalculateVolume()
        {
            return (Shape.PI * (Radius * Radius) * Height);
        }
        /// <summary>
        /// Draw: Personal addition for user;s to see what they chose
        ///         Meant to be vertual so other classe that inhheret from this class can override 
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine("This is the shape you've chosen. \nPress any key to continue...");
            Console.ReadKey();
        }
        /// <summary>
        /// EnterValue: Displays message get's user input input and assins to passed reference
        /// </summary>
        /// <param name="outputText">Passed to diplay message</param>
        /// <param name="value">Reference passed to initialize</param>
        public virtual void EnterValue(string outputText, out double value)
        {
            Console.Write(outputText);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write(outputText);
            }
        }
    }
}
