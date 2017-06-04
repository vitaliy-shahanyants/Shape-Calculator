using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 *      
 *           *  *  *  *  *  *    
 *         *              * *
 *        *              *  *
 *       *              *   *
 *      *  *  *  *  *  *    *
 *      *              *    *
 *      *     Box      *   *
 *      *              *  *
 *      *              * *
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
    /// Class Name: Box
    /// Inherents: SquareShape
    /// 
    /// Purpose: Is to calcuate Box shape surface area and volume
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Box : SquareShape
    {
        private double length;
        private double width;
        private double height;

        public Box() : base() { }

        /// <summary>
        /// SetData: Is overrided method from SquareShape meant to uses base class SquareShape's EnterValue() method to get user input, passing the input message and reference to get back the value,
        /// and store it to base clas property, and class the base class SetDate to continue 
        /// </summary>
        public override void SetData()
        {
            base.EnterValue("Enter the length: ", out length);
            base.Length = length;
            base.EnterValue("Enter the width: ", out width);
            base.Width = width;
            base.EnterValue("Enter the height: ", out height);
            base.Height = height;
            base.ThirdDimentionalObject = true;
            base.SetData();
        }
        /// <summary>
        /// CalculateArea: Is a override method  from SquareShape, meant to calculate Area
        /// </summary>
        /// <returns>Double Calculated Area</returns>
        public override double CalculateArea()
        {
            return (2*(base.Width*base.Height) + 2*(base.Height*base.Length) + 2*(base.Width*base.Height));
        }
        /// <summary>
        /// Draw: Is meant to draw the shape with the dimensions givin.
        /// Personal additons
        /// </summary>
        public override void Draw()
        {
            Console.SetCursorPosition((int)base.Width, Console.CursorTop);
            for (int i = 0; i < base.Width; i++)
            {
                if ((i == 0) || (i == base.Width))
                    Console.Write("{0}",
                        string.Concat(Enumerable.Repeat("*", (int)base.Length)));
                else
                    Console.Write("{0}{1}{2}",
                        "*",
                        string.Concat(Enumerable.Repeat(" ", (int)base.Length - 2)),
                        "*");
                /*Console.SetCursorPosition(Console.CursorLeft + i, Console.CursorTop);
                Console.Write("*");*/
                Console.WriteLine();
                Console.SetCursorPosition((int)base.Width - (i + 1), Console.CursorTop);
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < base.Height; i++)
            {
                if ((i == 0) || ((i + 1) == base.Height))
                    Console.Write("{0}",
                        string.Concat(Enumerable.Repeat("*", (int)base.Length)));
                else
                    Console.Write("{0}{1}{2}",
                        "*",
                        string.Concat(Enumerable.Repeat(" ", (int)base.Length - 2)),
                        "*");
                Console.WriteLine();
            }
            Console.SetCursorPosition((int)base.Height - 1, Console.CursorTop - 1);

            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            int cursorLeftDraw = 0;
            for (int i = 0; i < base.Width; i++)
            {
                Console.SetCursorPosition((int)base.Length + i, Console.CursorTop - i);
                Console.Write("*");
                cursorLeftDraw = Console.CursorLeft;
                Console.SetCursorPosition(cursorLeft, cursorTop);
            }
            if(base.Length == base.Width)
                Console.SetCursorPosition(Console.CursorLeft + (int)base.Length,Console.CursorTop-(int)base.Width);
            else
                Console.SetCursorPosition(Console.CursorLeft + cursorLeftDraw, Console.CursorTop - (int)base.Width);
            int cursorTopDraw = Console.CursorTop;
            //cursorLeftDraw = Console.CursorLeft;
            for(int i=0; i < base.Height; i++)
            {
                Console.SetCursorPosition(cursorLeftDraw, cursorTopDraw - i);
                Console.Write("*");
            }
            Console.SetCursorPosition(cursorLeft,cursorTop);
            Console.WriteLine();
            Console.SetCursorPosition(0, cursorTop + 1);
            base.Draw();
        }
        /// <summary>
        /// ToString: is meant to display specifically formated 
        /// </summary>
        /// <returns>return formated string</returns>
        public override string ToString()
        {
            return string.Format("{0,-11}\t{1,10}\t{2,10}\t{3,-45}",
                                    this.GetType().Name, base.AreaCalculation.ToString("0.00"), base.VolumeCalculation.ToString("0.00"), $"{base.Length.ToString("0.00")} l {base.Width.ToString("0.00")} w {base.Height.ToString("0.00")} h ");
        }
    }
}
