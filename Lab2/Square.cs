using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 *      *  *  *  *  *  *    
 *      *              *    
 *      *    Square    *   
 *      *              *  
 *      *              * 
 *      *  *  *  *  *  *
 * 
 * 
 * 
 */
namespace Lab2
{
    /// <summary>
    /// Name: Vitaliy Shahanyants
    /// Date: 16/02/2017
    /// Project: Lab 2
    /// 
    /// Class Name: Square
    /// Inherents: SquareShape
    /// 
    /// Purpose: Is to calcuate Cube shape area, and volume
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Square : SquareShape
    {
        private double length;

        public Square() : base() { }

        /// <summary>
        /// SetData: Is overrided method from SquareShape meant to uses base class SquareShape's EnterValue() method to get user input, passing the input message and reference to get back the value,
        /// and store it to base clas property, and class the base class SetDate to continue 
        /// </summary>
        public override void SetData()
        {
            base.EnterValue("Enter the length: ", out length);
            base.Width = length;
            base.Length = length;
            base.ThirdDimentionalObject = false;
            base.SetData();
        }
        /// <summary>
        /// Draw: Is meant to draw the shape with the dimensions givin.
        /// Personal additons
        /// </summary>
        public override void Draw()
        {
            for(int i=0; i < base.Length; i++)
            {
                if ((i == 0) || ((i + 1) == base.Length))
                    Console.Write("{0}",
                        string.Concat(Enumerable.Repeat("*", (int)base.Length)));
                else
                    Console.Write("{0}{1}{2}",
                        "*",
                        string.Concat(Enumerable.Repeat(" ", (int)base.Length - 2)),
                        "*");
                Console.WriteLine();
            }
            base.Draw();
        }
        /// <summary>
        /// ToString: is meant to display specifically formated 
        /// </summary>
        /// <returns>return formated string</returns>
        public override string ToString()
        {
            return string.Format("{0,-11}\t{1,10}\t{2,10}\t{3,-45}",
                                    this.GetType().Name, base.AreaCalculation.ToString("0.00"), "", $"{base.Length.ToString("0.00")} l");
        }
    }
}

