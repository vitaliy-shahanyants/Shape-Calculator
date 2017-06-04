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
    /// Class Name: Triangle
    /// Inherents: TriangleShape
    /// 
    /// Purpose: Is to calcuate Triangle shape area, and volume
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Triangle : TriangleShape
    {
        private double triangleBase;
        private double height;

        public Triangle() : base() { }

        /// <summary>
        /// SetData: Is overrided method from TriangleShape meant to uses base class TriangleShape's EnterValue() method to get user input, passing the input message and reference to get back the value,
        /// and store it to base clas property, and class the base class SetDate to continue 
        /// </summary>
        public override void SetData()
        {
            base.EnterValue("Enter the base: ", out triangleBase);
            base.Base = triangleBase;
            base.EnterValue("Enter the height: ", out height);
            base.Height = height;
            base.ThirdDimentionalObject = false;
            base.SetData();
        }
        /// <summary>
        /// ToString: is meant to display specifically formated 
        /// </summary>
        /// <returns>return formated string</returns>
        public override string ToString()
        {
            return string.Format("{0,-11}\t{1,10}\t{2,10}\t{3,-45}",
                                    this.GetType().Name, base.AreaCalculation.ToString("0.00"), "", $"{base.Base.ToString("0.00")} b x {base.Height} h");
        }
    }
}
